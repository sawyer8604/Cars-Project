namespace Cars.Web.Controllers
{
	using Cars.Services.Data;
	using Cars.Web.ViewModels.Car;
    using Microsoft.AspNetCore.Mvc;

	public class CarController : Controller
    {
        private readonly IMakesService makesService;

        public CarController(IMakesService makesService)
        {

            this.makesService = makesService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateCarInputModel();
            viewModel.MakesItems = this.makesService.GetAllMakesAsKeyValuePairs();

			return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateCarInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.MakesItems = this.makesService.GetAllMakesAsKeyValuePairs();
				return this.View(input);
            }

            //TODO: Create car using service method
            //TODO: Redirect to car infopage

            return this.Redirect("/");
        }
    }
}
