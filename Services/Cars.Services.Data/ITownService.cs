namespace Cars.Services.Data
{
    using System.Collections.Generic;

	public interface ITownService
	{
		IEnumerable<KeyValuePair<string, string>> GetAllTownsAsKeyValuepairs();
	}
}
