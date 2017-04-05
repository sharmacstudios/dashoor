using Dashoor.Model.Models;
using GridMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashoor.Web.Models.Grids
{
    public class CustomFieldsGrid : Grid<MetaField>
    {
        public CustomFieldsGrid(IQueryable<MetaField> items)
            : base(items)
        {
        }
    }
}
