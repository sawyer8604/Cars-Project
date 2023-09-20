using Cars.Services.Mapping;

namespace Cars.Web.ViewModels.Car
{
	public class CarInListViewModel 
	{
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public string Make { get; set; }

        public int MakeId { get; set; }

        public string Model { get; set; }

		public string FuelType { get; set; }

		public int FuelTypeId { get; set; }

		public string Transmission { get; set; }

		public int TransmissionId { get; set; }

		public double Price { get; set; }

        public string Town { get; set; }

		public int TownId { get; set; }

		public string Color { get; set; }

		public int Mileage { get; set; }

		public string Description { get; set; }

		public string SellersPhoneNumber { get; set; }

	}
}
