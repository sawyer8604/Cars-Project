namespace Cars.Services.Data
{
	using Cars.Data.Common.Repositories;
	using Cars.Data.Models;
    using System.Collections.Generic;
    using System.Linq;
 

	public class CarColorService : ICarColorService
	{
		private readonly IDeletableEntityRepository<CarColor> carColorsRepository;

		public CarColorService(IDeletableEntityRepository<CarColor> carColorsRepository)
        {
			this.carColorsRepository = carColorsRepository;
		}
        public IEnumerable<KeyValuePair<string, string>> GetAllColorsAsKeyValuePairs()
		{
			return this.carColorsRepository.All().Select(x => new
			{
				x.Name,
				x.Id
			}).ToList().Select(x => new KeyValuePair<string, string>(x.Name.ToString(), x.Id.ToString()));
		}
	}
}
