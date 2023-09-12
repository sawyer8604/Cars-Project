namespace Cars.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Cars.Data.Common.Repositories;
    using Cars.Data.Models;

	public class TownService : ITownService
	{
		private readonly IDeletableEntityRepository<Town> townsRepository;

		public TownService(IDeletableEntityRepository<Town> townsRepository)
        {
			this.townsRepository = townsRepository;
		}
        public IEnumerable<KeyValuePair<string, string>> GetAllTownsAsKeyValuepairs()
		{
			return this.townsRepository.All().Select(x => new
			{
				x.Name,
				x.Id
			}).ToList().Select(x => new KeyValuePair<string, string>(x.Name.ToString(), x.Id.ToString()));
		}
	}
}
