using Dashoor.Model.Models;
using GridMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashoor.Web.Models.Grids
{
    public class ListingModelGrid : Grid<ListingItemModel>
    {
        public ListingModelGrid(IQueryable<ListingItemModel> items)
            : base(items)
        {
        }
    }
}
