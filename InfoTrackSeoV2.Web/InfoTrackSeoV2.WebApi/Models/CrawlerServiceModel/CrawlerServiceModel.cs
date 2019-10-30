using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoTrackSeoV2.WebApi.Models.CrawlerServiceModel
{
    public class CrawlerServiceModel
    {
        public string Response { get; set; }

        public bool IsSuccess { get; set; }

        public string ErrorMessage { get; set; }
    }
}