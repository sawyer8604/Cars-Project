namespace Cars.Services.Data
{
    using System;
    using System.Collections.Generic;

	public interface IMakesService
	{
        IEnumerable<KeyValuePair<string, string>> GetAllMakesAsKeyValuePairs();
    }
}
