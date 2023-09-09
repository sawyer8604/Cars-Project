namespace Cars.Services.Data
{
	using Cars.Data.Common.Repositories;
	using Cars.Data.Models;

	using System.Collections.Generic;
	using System.Linq;

	public class ModelService : IModelService
	{
		private readonly IDeletableEntityRepository<Model> modelsRepository;

		public ModelService(IDeletableEntityRepository<Model> modelsRepository)
        {
			this.modelsRepository = modelsRepository;
        }
        public IEnumerable<KeyValuePair<string, string>> GetAllModelsAsKeyValuePairs()
		{
			return this.modelsRepository.All().Select(x => new
			{
				x.Name,
				x.Id
			}).ToList().Select(x => new KeyValuePair<string, string>(x.Name.ToString(), x.Id.ToString()));
		}
	}
}
