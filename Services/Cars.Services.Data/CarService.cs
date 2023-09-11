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
		private readonly IDeletableEntityRepository<Area> areasRepository;
		

		public CarService(IDeletableEntityRepository<Car> carsRepository, IDeletableEntityRepository<Area> areasRepository)
        {
			this.carsRepository = carsRepository;
			this.areasRepository = areasRepository;
		}
        public async Task Create(CreateCarInputModel input)
		{
			var car = new Car();
			car.MakeId = input.MakeId;
			car.ModelId = input.ModelId;
			car.FuelTypeId = input.FuelTypeId;
			car.TransmissionId = input.TransmissionId;
			car.Price = input.Price;

			var area = this.areasRepository.All().FirstOrDefault(x => x.Name == input.Area);

			if(area == null)
			{
				area = new Area();
				area.Name = input.Area;
			}

			car.AreaId = area.Id;

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
