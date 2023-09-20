namespace Cars.Services.Data
{
	using System.Collections.Generic;
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
        public async Task Create(CreateCarInputModel input, string userId)
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
	}
}
