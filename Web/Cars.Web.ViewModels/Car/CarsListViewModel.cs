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

        public bool HasPreviousPage => this.PageNumber > 1;

		public bool HasNextPage => this.PageNumber < this.PagesCount;


		public int PreviousPageNumber => this.PageNumber - 1;

		public int NextPageNumber => this.PageNumber + 1;

		public int PagesCount => (int)Math.Ceiling((double)this.CarsCount / this.ItemsPerPage);

        public int CarsCount { get; set; }

		public int ItemsPerPage { get; set; }

	}
}
