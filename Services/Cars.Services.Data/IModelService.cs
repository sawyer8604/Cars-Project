namespace Cars.Services.Data
{
    using System.Collections.Generic;
	public interface IModelService
	{
		IEnumerable<KeyValuePair<string, string>> GetAllModelsAsKeyValuePairs();
	}
}
