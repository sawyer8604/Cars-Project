namespace Cars.Web.ViewModels.Car
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

	public class CarsListViewModel
	{
        public IEnumerable<CarInListViewModel> Cars { get; set; }

        public int PageNumber { get; set; }
    }
}
