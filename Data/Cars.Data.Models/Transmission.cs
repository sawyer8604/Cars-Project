namespace Cars.Data.Models
{
    using System.Collections.Generic;

    using Cars.Data.Common.Models;

    public class Transmission : BaseDeletableModel<int>
    {
        public Transmission()
        {
            this.Cars = new HashSet<Car>();
        }

        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
