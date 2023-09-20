namespace Cars.Services.Data
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Cars.Data.Common.Repositories;
	using Cars.Data.Models;
	using Cars.Web.ViewModels.Car;

	public class CarService : ICarService
	{
		private readonly IDeletableEntityRepository<Car> carsRepository;

		public CarService(IDeletableEntityRepository<Car> carsRepository)
        {
			this.carsRepository = carsRepository;

		}
        public async Task Create(CreateCarInputModel input, string userId)
		{
            var car = new Car
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

            await this.carsRepository.AddAsync(car);
			await this.carsRepository.SaveChangesAsync();
		}

		public IEnumerable<CarInListViewModel> GetAll(int page, int itemsPerPage = 12)
		{
			var cars = this.carsRepository.AllAsNoTracking()
				.OrderBy(x => x.Id)
				.Skip((page - 1) * itemsPerPage ).Take(itemsPerPage)
				.Select(x => new CarInListViewModel
				{
					Id = x.Id,
					Make = x.Make.Name,
					MakeId = x.MakeId,
					Model = x.Model.Name,
					FuelType = x.FuelType.Name,
					FuelTypeId = x.FuelTypeId,
					Transmission = x.Transmission.Name,
					TransmissionId = x.TransmissionId,
					Price = x.Price,
					Town = x.Town.Name,
					TownId = x.TownId,
					Color = x.Color.Name,
					Mileage = x.Mileage,
					Description = x.Description,
					SellersPhoneNumber = x.SellersPhoneNumber,
					ImageUrl = "images/cars/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension,

				}).ToList();

			return cars;
				
		}
	}
}
