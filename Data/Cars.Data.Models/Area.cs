namespace Cars.Data.Models
{
    using System.Collections.Generic;

    using Cars.Data.Common.Models;

    public class Area : BaseDeletableModel<int>
    {

        public Area()
        {
            this.Cars = new HashSet<Car>();
            this.Towns = new HashSet<Towns>();
        }

        public int Name { get; set; }

        public ICollection<Car> Cars { get; set; }

        public ICollection<Towns> Towns { get; set; }

    }
}
