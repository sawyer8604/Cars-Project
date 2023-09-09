namespace Cars.Web.Controllers
{
	using Cars.Services.Data;
	using Cars.Web.ViewModels.Car;
    using Microsoft.AspNetCore.Mvc;
	using System.Threading.Tasks;

	public class CarController : Controller
    {
        private readonly IMakesService makesService;
		private readonly IModelService modelService;
		private readonly IFuelService fuelService;
		private readonly ITransmissionService transmissionService;
		private readonly ICarService carService;

		public CarController(IMakesService makesService, IModelService modelService, IFuelService fuelService,
			ITransmissionService transmissionService, ICarService carService)
		{

            this.makesService = makesService;
			this.modelService = modelService;
			this.fuelService = fuelService;
			this.transmissionService = transmissionService;
			this.carService = carService;
		}

        public IActionResult Create()
        {
            var viewModel = new CreateCarInputModel();
            viewModel.MakesItems = this.makesService.GetAllMakesAsKeyValuePairs();
            viewModel.ModelsItems = this.modelService.GetAllModelsAsKeyValuePairs();
            viewModel.FuelsItems = this.fuelService.GetAllFuelsAsKeyValuePairs();
            viewModel.TransmissionsItems = this.transmissionService.GetAllTransmissionsAsKeyValuePairs();

			return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCarInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.MakesItems = this.makesService.GetAllMakesAsKeyValuePairs();
				return this.View(input);
            }

            await this.carService.Create(input);

            //TODO: Redirect to car infopage

            return this.Redirect("/");
        }
    }
}
