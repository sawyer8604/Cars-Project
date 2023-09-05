namespace Cars.Data.Models
{
    using System.Collections.Generic;

    using Cars.Data.Common.Models;

    public class Model : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public int MakeID { get; set; }

        public virtual Make Make { get; set; }

    }
}
