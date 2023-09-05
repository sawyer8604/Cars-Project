﻿namespace Cars.Data.Models
{
    using System.Collections.Generic;   

    using Cars.Data.Common.Models;

    public class FuelType : BaseDeletableModel<int>
    {
        public FuelType()
        {
            this.Cars = new HashSet<Car>();
        }

        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
