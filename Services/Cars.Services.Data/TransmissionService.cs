namespace Cars.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Cars.Data.Common.Repositories;
    using Cars.Data.Models;

	public class TransmissionService : ITransmissionService
	{
		private readonly IDeletableEntityRepository<Transmission> transmissionRepository;

		public TransmissionService(IDeletableEntityRepository<Transmission> transmissionRepository)
        {
			this.transmissionRepository = transmissionRepository;
		}
        public IEnumerable<KeyValuePair<string, string>> GetAllTransmissionsAsKeyValuePairs()
		{
			return this.transmissionRepository.All().Select(x => new
			{
				x.Name,
				x.Id
			}).ToList().Select(x => new KeyValuePair<string, string>(x.Name.ToString(), x.Id.ToString()));
		}
	}
}
