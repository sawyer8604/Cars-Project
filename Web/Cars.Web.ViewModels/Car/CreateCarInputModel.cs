namespace Cars.Web.ViewModels.Car
{
    using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

    public class CreateCarInputModel
    {
        [Display(Name = "Make")]
        public int MakeId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> MakesItems { get; set; }

		[Display(Name = "Model")]

		public int ModelId { get; set; }

		public IEnumerable<KeyValuePair<string, string>> ModelsItems { get; set; }


		[Display(Name = "Fuel Type")]

		public int FuelTypeId { get; set; }

		public IEnumerable<KeyValuePair<string, string>> FuelsItems { get; set; }

		[Display(Name = "Transmission Type")]
		public int TransmissionId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> TransmissionsItems { get; set; }

        [Display(Name = "Price in EUR")]
        [Range(1, 1_000_000_000)]
        public double Price { get; set; }

        [Display(Name = "Area")]
        public int AreaId { get; set; }

		[Required]
		[MinLength(4)]
        public string Area { get; set; }

		[DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
		[Display(Name = "Year Of Manufacture")]
		[DataType(DataType.Date)]
		public DateTime YearOfManufacture { get; set; }

		[Display(Name = "Color")]

		public int ColorId { get; set; }

        [Required]
        [MinLength(3)]
        public string Color { get; set; }

		[Display(Name = "Engine Power")]
		[Range(50, 10000)]
        public int EnginePower { get; set; }

        [Range(0, 1000000)]
        public int Mileage { get; set; }

		[Required]
		[MinLength(10)]
        public string Description { get; set; }

        [Phone]
        public string SellersPhoneNumber { get; set; }
    }
}
