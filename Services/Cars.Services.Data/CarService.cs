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
		private readonly IDeletableEntityRepository<Town> areasRepository;
		private readonly IDeletableEntityRepository<CarColor> colorRepository;
		private readonly IDeletableEntityRepository<Town> townsRepository;

		public CarService(IDeletableEntityRepository<Car> carsRepository, IDeletableEntityRepository<Town> areasRepository,
			IDeletableEntityRepository<CarColor> colorRepository, IDeletableEntityRepository<Town> townsRepository)
        {
			this.carsRepository = carsRepository;
			this.areasRepository = areasRepository;
			this.colorRepository = colorRepository;
			this.townsRepository = townsRepository;
		}
        public async Task Create(CreateCarInputModel input)
		{
			var car = new Car();
			car.MakeId = input.MakeId;
			car.ModelId = input.ModelId;
			car.FuelTypeId = input.FuelTypeId;
			car.TransmissionId = input.TransmissionId;
			car.Price = input.Price;
			car.TownId = input.TownId;
			car.YearOfManufacture = input.YearOfManufacture;
			car.ColorId = input.CarColorId;
			car.EnginePower = input.EnginePower;
			car.Mileage = input.Mileage;
			car.Description = input.Description;
			car.SellersPhoneNumber = input.SellersPhoneNumber;

			await this.carsRepository.AddAsync(car);
			await this.carsRepository.SaveChangesAsync();
		}
	}
}
