namespace Cars.Data.Models
{
    using System.Collections.Generic;

    using Cars.Data.Common.Models;

    public class Model : BaseDeletableModel<int>
    {
        public Model()
        {
            this.Cars = new HashSet<Car>();
        }
        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }

    }
}
