﻿using Dashoor.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashoor.Web.Models
{
    public class MetaFieldModel
    {
        public MetaField MetaField { get; set; }

        public List<Category> Categories { get; set; }
    }
}
