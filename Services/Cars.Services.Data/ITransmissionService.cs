namespace Cars.Services.Data
{
    using System.Collections.Generic;

	public interface ITransmissionService
	{
		IEnumerable<KeyValuePair<string, string>> GetAllTransmissionsAsKeyValuePairs();
	}
}
