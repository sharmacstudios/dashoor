﻿using Dashoor.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashoor.Web.Models
{
    public class CustomFieldListingModel
    {
        public List<MetaCategory> MetaCategories { get; set; }

        public int ListingID { get; set; }
    }
}
