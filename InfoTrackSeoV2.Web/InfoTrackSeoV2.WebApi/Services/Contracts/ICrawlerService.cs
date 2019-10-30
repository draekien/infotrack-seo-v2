using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoTrackSeoV2.WebApi.Models.CrawlerServiceModel;

namespace InfoTrackSeoV2.WebApi.Services.Contracts
{
    public interface ICrawlerService
    {
        Task<CrawlerServiceModel> CrawlAsync(string uri);
    }
}
