namespace Cars.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using Cars.Data;
    using Cars.Web.ViewModels;
    using Cars.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {

            var viewModel = new IndexViewModel
            {
                CarsCount = this.dbContext.Cars.Count(),
                MakesCount = this.dbContext.Makes.Count(),
                ModelsCount = this.dbContext.Models.Count(),
                ColorCount = this.dbContext.Colors.Count(),

            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
