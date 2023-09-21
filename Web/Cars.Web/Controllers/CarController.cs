﻿namespace Cars.Web.Controllers
{
    using Cars.Data.Models;
    using Cars.Services.Data;
	using Cars.Web.ViewModels.Car;
    using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Hosting;
	using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
	using System;
	using System.Security.Claims;
    using System.Threading.Tasks;

	public class CarController : Controller
    {
        private readonly IMakesService makesService;
		private readonly IModelService modelService;
		private readonly IFuelService fuelService;
		private readonly ITransmissionService transmissionService;
		private readonly ICarService carService;
		private readonly ICarColorService carColorService;
		private readonly ITownService townService;
        private readonly UserManager<ApplicationUser> userManager;
		private readonly IWebHostEnvironment environment;

		public CarController(IMakesService makesService, IModelService modelService, IFuelService fuelService,
			ITransmissionService transmissionService, ICarService carService, ICarColorService carColorService,
			ITownService townService, UserManager<ApplicationUser> userManager,
            IWebHostEnvironment environment)
		{

            this.makesService = makesService;
			this.modelService = modelService;
			this.fuelService = fuelService;
			this.transmissionService = transmissionService;
			this.carService = carService;
			this.carColorService = carColorService;
			this.townService = townService;
            this.userManager = userManager;
			this.environment = environment;
		}

		[Authorize]
        public IActionResult Create()
        {
            var viewModel = new CreateCarInputModel();
            viewModel.MakesItems = this.makesService.GetAllMakesAsKeyValuePairs();
            viewModel.ModelsItems = this.modelService.GetAllModelsAsKeyValuePairs();
            viewModel.FuelsItems = this.fuelService.GetAllFuelsAsKeyValuePairs();
            viewModel.TransmissionsItems = this.transmissionService.GetAllTransmissionsAsKeyValuePairs();
            viewModel.CarColorsItems = this.carColorService.GetAllColorsAsKeyValuePairs();
            viewModel.TownsItems = this.townService.GetAllTownsAsKeyValuepairs();

			return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateCarInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.MakesItems = this.makesService.GetAllMakesAsKeyValuePairs();
				input.ModelsItems = this.modelService.GetAllModelsAsKeyValuePairs();
				input.FuelsItems = this.fuelService.GetAllFuelsAsKeyValuePairs();
				input.TransmissionsItems = this.transmissionService.GetAllTransmissionsAsKeyValuePairs();
				input.CarColorsItems = this.carColorService.GetAllColorsAsKeyValuePairs();
				input.TownsItems = this.townService.GetAllTownsAsKeyValuepairs();
				return this.View(input);
            }

            //var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value; //get from cookie
            var user = await this.userManager.GetUserAsync(this.User);
            try
            {
				await this.carService.Create(input, user.Id, $"{this.environment.WebRootPath}/images");

			}
			catch (Exception ex)
            {

                this.ModelState.AddModelError(string.Empty, ex.Message);
				input.MakesItems = this.makesService.GetAllMakesAsKeyValuePairs();
				input.ModelsItems = this.modelService.GetAllModelsAsKeyValuePairs();
				input.FuelsItems = this.fuelService.GetAllFuelsAsKeyValuePairs();
				input.TransmissionsItems = this.transmissionService.GetAllTransmissionsAsKeyValuePairs();
				input.CarColorsItems = this.carColorService.GetAllColorsAsKeyValuePairs();
				input.TownsItems = this.townService.GetAllTownsAsKeyValuepairs();
				return this.View(input);
			}

            //TODO: Redirect to car infopage

            return this.RedirectToAction(nameof(ThankYou));
        }

		public IActionResult ThankYou()
		{
			return this.View();
		}

        public IActionResult All(int id = 1)
        {
            const int itemsPerPage = 12;
            var viewModel = new CarsListViewModel
            {
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                CarsCount = this.carService.GetCount(),
                Cars = this.carService.GetAll<CarInListViewModel>(id, itemsPerPage),

            };
            return this.View(viewModel);
        }
	}
}
