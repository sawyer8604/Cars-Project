namespace Cars.Services.Data
{
    using System.Linq;
    using Cars.Data.Common.Repositories;
    using Cars.Data.Models;
    using Cars.Web.ViewModels.Home;

    public class GetCountService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<Car> carsRepository;
        private readonly IDeletableEntityRepository<Make> makesRepository;
        private readonly IDeletableEntityRepository<Model> modelsRepository;
        private readonly IDeletableEntityRepository<Color> colorsRepository;

        public GetCountService(
            IDeletableEntityRepository<Car> carsRepository,
            IDeletableEntityRepository<Make> makesRepository,
            IDeletableEntityRepository<Model> modelsRepository,
            IDeletableEntityRepository<Color> colorsRepository)
        {
            this.carsRepository = carsRepository;
            this.makesRepository = makesRepository;
            this.modelsRepository = modelsRepository;
            this.colorsRepository = colorsRepository;
        }

        public IndexViewModel GetCounts()
        {
            var data = new IndexViewModel
            {
                CarsCount = this.carsRepository.All().Count(),
                MakesCount = this.makesRepository.All().Count(),
                ModelsCount = this.modelsRepository.All().Count(),
                ColorCount = this.colorsRepository.All().Count(),

            };

            return data;
        }
    }
}
