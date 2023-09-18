namespace Cars.Services.Data
{
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
	}
}
