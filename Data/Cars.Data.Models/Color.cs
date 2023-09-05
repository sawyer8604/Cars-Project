namespace Cars.Data.Models
{
    using System.Collections.Generic;

    using Cars.Data.Common.Models;

    public class Color : BaseDeletableModel<int>
    {
        public Color()
        {
                this.Cars = new HashSet<Car>();
        }

        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
