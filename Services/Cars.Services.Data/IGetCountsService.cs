namespace Cars.Services.Data
{
    using Cars.Web.ViewModels.Home;

    public interface IGetCountsService
    {
        // Use viewModel
        IndexViewModel GetCounts();
    }
}
