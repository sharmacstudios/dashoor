using Dashoor.Core.Plugins;
using Dashoor.Model.Enum;
using Dashoor.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashoor.Web.Areas.Admin.Models
{
    public class PaymentSettingModel
    {
        public Setting Setting { get; set; }

        public List<PluginDescriptor> PaymentPlugins { get; set; }
    }
}
