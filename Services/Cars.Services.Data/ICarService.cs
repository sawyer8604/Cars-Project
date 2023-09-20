namespace Cars.Services.Data
{
    using Cars.Web.ViewModels.Car;
	using System.Collections;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	public interface ICarService
	{
		Task Create(CreateCarInputModel input, string userId);

		IEnumerable<CarInListViewModel> GetAll(int page, int itemsPerPage = 12);
	}
}
