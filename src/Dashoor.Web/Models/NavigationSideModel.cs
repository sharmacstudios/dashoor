using Dashoor.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashoor.Web.Models
{
    public class NavigationSideModel
    {
        public IEnumerable<Dashoor.Web.Extensions.TreeItem<Dashoor.Model.Models.Category>> CategoryTree { get; set; }

        public IEnumerable<ContentPage> ContentPages { get; set; }
    }
}
