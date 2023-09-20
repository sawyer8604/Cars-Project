namespace Cars.Data.Models
{
    using System.Collections.Generic;

    using Cars.Data.Common.Models;

    public class Model : BaseDeletableModel<int>
    {
        public Model()
        {
            this.Cars = new HashSet<MyCar>();
        }
        public string Name { get; set; }

        public ICollection<MyCar> Cars { get; set; }

    }
}
