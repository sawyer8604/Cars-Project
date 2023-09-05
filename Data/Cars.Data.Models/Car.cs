namespace Cars.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Cars.Data.Common.Models;

    public class Car : BaseDeletableModel<int> // Soft Deleting
    {

        public Car()
        {
                this.Images = new HashSet<Image>();
        }

        public int MakeId { get; set; }

        public virtual Make Make { get; set; }

        public int FuelTypeId { get; set; }

        public virtual FuelType FuelType { get; set; }

        public int TransmissionId { get; set; }

        public virtual Transmission Transmission { get; set; }

        public double Price { get; set; }

        public int AreId { get; set; }

        public virtual Area Area { get; set; }

        public DateTime YearOfManufacture { get; set; }

        public int ColorId { get; set; }

        public virtual Color Color { get; set; }

        public int EnginePower { get; set; }

        public int Mileage { get; set; }

        public string Description { get; set; }

        public string AddedByUserID { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public ICollection<Image> Images { get; set; }

        public int SellersPhoneNumber { get; set; }
    }
}
