namespace Cars.Web.ViewModels.Car
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cars.Web.ViewModels;

    public class CarsListViewModel : PagingViewModel
	{
        public IEnumerable<CarInListViewModel> Cars { get; set; }

	}
}
