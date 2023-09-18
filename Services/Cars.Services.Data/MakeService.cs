namespace Cars.Services.Data
{
	using System.Collections.Generic;
	using System.Linq;
	using Cars.Data.Common.Repositories;
	using Cars.Data.Models;

	public class MakeService : IMakesService
	{
		private readonly IDeletableEntityRepository<Make> makesRepository;

		public MakeService(IDeletableEntityRepository<Make> makesRepository)
		{
			this.makesRepository = makesRepository;
		}
		public IEnumerable<KeyValuePair<string, string>> GetAllMakesAsKeyValuePairs()
		{
			return this.makesRepository.All().Select(x => new
			{
				x.Name,
				x.Id
			})
				.OrderBy(x => x.Name)
				.ToList().Select(x => new KeyValuePair<string, string>(x.Name.ToString(), x.Id.ToString()));
		}
	}
}
