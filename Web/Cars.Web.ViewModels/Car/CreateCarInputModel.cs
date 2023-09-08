namespace Cars.Web.ViewModels.Car
{
    using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

    using global::Cars.Data.Models;

    public class CreateCarInputModel
    {
        public int MakeId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> MakesItems { get; set; }

        [Display(Name = "Model")]

        public virtual Model Model { get; set; }

        public int FuelTypeId { get; set; }

        public virtual FuelType FuelType { get; set; }

        public int TransmissionId { get; set; }

        public virtual Transmission Transmission { get; set; }

        [Display(Name = "Price in EUR")]
        [Range(1, 1_000_000_000)]
        public double Price { get; set; }

        public int AreaId { get; set; }

        [MinLength(4)]
        public virtual Area Area { get; set; }

        public DateTime YearOfManufacture { get; set; }

        public int ColorId { get; set; }

        [MinLength(4)]
        public virtual Color Color { get; set; }

        [Range(50, 10000)]
        public int EnginePower { get; set; }

        [Range(0, 1000000)]
        public int Mileage { get; set; }

        [MinLength(10)]
        public string Description { get; set; }

        public string AddedByUserID { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        [Phone]
        public string SellersPhoneNumber { get; set; }
    }
}
