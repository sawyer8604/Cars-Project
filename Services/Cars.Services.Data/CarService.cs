namespace Cars.Services.Data
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Threading.Tasks;
	using Cars.Data.Common.Repositories;
	using Cars.Data.Models;
	using Cars.Services.Mapping;
	using Cars.Web.ViewModels.Car;

	public class CarService : ICarService
	{
		private readonly IDeletableEntityRepository<MyCar> carsRepository;

		public CarService(IDeletableEntityRepository<MyCar> carsRepository)
		{
			this.carsRepository = carsRepository;

		}
		public async Task Create(CreateCarInputModel input, string userId, string imagePath)
		{

			var car = new MyCar
			{
				MakeId = input.MakeId,
				ModelId = input.ModelId,
				FuelTypeId = input.FuelTypeId,
				TransmissionId = input.TransmissionId,
				Price = input.Price,
				TownId = input.TownId,
				YearOfManufacture = input.YearOfManufacture,
				ColorId = input.CarColorId,
				EnginePower = input.EnginePower,
				Mileage = input.Mileage,
				Description = input.Description,
				SellersPhoneNumber = input.SellersPhoneNumber,
				AddedByUserID = userId,
			};

			Directory.CreateDirectory($"{imagePath}/cars");

			var allowedExtensions = new[] { "jpg", "png", "gif" };
			// /wwwroot/images/cars{id}.{ext}

			foreach (var image in input.Images)
			{
				var extension = Path.GetExtension(image.FileName).TrimStart('.');

				if (!allowedExtensions.Any(x => extension.EndsWith(x)))
				{
					throw new Exception($"Invalid image extension {extension}");
				}
				var dbImage = new Image
				{
					AddedByUserId = userId,
					Extension = extension,
				};
				car.Images.Add(dbImage);

				var physicalPath = $"{imagePath}/cars/{dbImage.Id}.{extension}";
				using (Stream fileStream = new FileStream(physicalPath, FileMode.Create))
				{
					await image.CopyToAsync(fileStream);
				}
			}
			await this.carsRepository.AddAsync(car);
			await this.carsRepository.SaveChangesAsync();
		}

		public IEnumerable<Т> GetAll<Т>(int page, int itemsPerPage = 12)
		{
			var cars = this.carsRepository.AllAsNoTracking()
				.OrderBy(x => x.Id)
				.Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
				.To<Т>()
				.ToList();

			return cars;

		}

		public int GetCount()
		{
			return this.carsRepository.All().Count();
		}
	}
}
