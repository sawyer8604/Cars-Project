namespace Cars.Services.Data
{
    using System.Collections.Generic;

	public interface IFuelService
	{
        IEnumerable<KeyValuePair<string, string>> GetAllFuelsAsKeyValuePairs();
	}
}
