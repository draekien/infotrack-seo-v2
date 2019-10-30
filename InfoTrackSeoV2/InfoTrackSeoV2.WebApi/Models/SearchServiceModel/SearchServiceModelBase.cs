using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoTrackSeoV2.WebApi.Models.SearchServiceModel
{
    public class SearchServiceModelBase
    {
        public DateTime TimeStamp { get; set; }

        public bool IsSuccess { get; set; }

        public string ErrorMessage { get; set; }
    }
}