namespace Cars.Data.Models
{
    using System.Collections.Generic;

    using Cars.Data.Common.Models;

	public class CarColor : BaseDeletableModel<int>
	{
        public CarColor()
        {
            this.Cars = new HashSet<Car>();
        }

        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
