namespace Cars.Web.ViewModels.Car
{
    using System.Linq;

    using AutoMapper;
    using Cars.Data.Models;
    using Cars.Services.Mapping;

	public class CarInListViewModel : IMapFrom<MyCar>, IHaveCustomMappings
	{
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public string MakeName { get; set; }

        public int MakeId { get; set; }

        public string ModelName { get; set; }

		public string FuelTypeName { get; set; }

		public int FuelTypeId { get; set; }

		public string TransmissionName { get; set; }

		public int TransmissionId { get; set; }

		public double Price { get; set; }

        public string TownName { get; set; }

		public int TownId { get; set; }

		public string ColorName { get; set; }

		public int Mileage { get; set; }

		public string Description { get; set; }

		public string SellersPhoneNumber { get; set; }

		public void CreateMappings(IProfileExpression configuration)
		{
			configuration.CreateMap<MyCar, CarInListViewModel>()
				.ForMember(x => x.ImageUrl, opt =>
				opt.MapFrom
				(car => "images/cars/" + car.Images.FirstOrDefault().Id + "." + car.Images.FirstOrDefault().Extension));
		}
	}
}
