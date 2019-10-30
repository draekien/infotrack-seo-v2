using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using InfoTrackSeoV2.WebApi.Models.SearchServiceModel;
using InfoTrackSeoV2.WebApi.Services.Contracts;

namespace InfoTrackSeoV2.WebApi.Services.SearchService
{
    public class GoogleSearchService : ISearchService<SearchServiceModelBase>
    {
        public Task<SearchServiceModelBase> SearchAsync(string uri, string searchTerms)
        {
            throw new NotImplementedException();
        }
    }
}