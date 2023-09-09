namespace Cars.Services.Data
{
    using System.Collections.Generic;
	using System.Linq;
	using Cars.Data.Common.Repositories;
    using Cars.Data.Models;

	public class FuelService : IFuelService
	{
		private readonly IDeletableEntityRepository<FuelType> fuelTypeRepository;

		public FuelService(IDeletableEntityRepository<FuelType> fuelTypeRepository)
        {
			this.fuelTypeRepository = fuelTypeRepository;
		}
        public IEnumerable<KeyValuePair<string, string>> GetAllFuelsAsKeyValuePairs()
		{
			return this.fuelTypeRepository.All().Select(x => new
			{
				x.Name,
				x.Id
			}).ToList().Select(x => new KeyValuePair<string, string>(x.Name.ToString(), x.Id.ToString()));

		}
	}
}
