namespace Cars.Data.Models
{
    using System.Collections.Generic;

    using Cars.Data.Common.Models;

	public class CarColor : BaseDeletableModel<int>
	{
        public CarColor()
        {
            this.Cars = new HashSet<MyCar>();
        }

        public string Name { get; set; }

        public ICollection<MyCar> Cars { get; set; }
    }
}
