namespace Cars.Data.Models
{
    using System.Collections.Generic;

    using Cars.Data.Common.Models;

    public class Make : BaseDeletableModel<int>
    {
        public Make()
        {
            this.Cars = new HashSet<Car>();
            this.Models = new HashSet<Model>();
        }

        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }

        public ICollection<Model> Models { get; set; }


    }
}
