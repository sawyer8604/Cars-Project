namespace Cars.Services.Data
{
    using Cars.Web.ViewModels.Car;
	using System.Threading.Tasks;

	public interface ICarService
	{
		Task Create(CreateCarInputModel input, string userId);
	}
}
