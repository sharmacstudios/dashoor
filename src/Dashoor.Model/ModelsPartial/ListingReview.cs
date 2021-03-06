﻿using Dashoor.Model.Enum;
using Dashoor.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashoor.Model.Models
{
    [MetadataType(typeof(ListingReviewMetaData))]
    public partial class ListingReview
    {
        public string RatingClass
        {
            get
            {
                return "s" + Math.Round(Rating * 2);
            }
        }
    }

    public class ListingReviewMetaData
    {
    }
}
