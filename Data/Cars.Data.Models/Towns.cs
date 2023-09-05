namespace Cars.Data.Models
{
    using Cars.Data.Common.Models;

    public class Towns : BaseDeletableModel<int>
    {

        public string Name { get; set; }

        public int AreaId { get; set; }

        public virtual Area Area { get; set; }

    }
}
