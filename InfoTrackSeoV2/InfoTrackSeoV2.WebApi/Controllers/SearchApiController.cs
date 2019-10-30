using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InfoTrackSeoV2.WebApi.Models.SearchServiceModel;
using InfoTrackSeoV2.WebApi.Services.Contracts;

namespace InfoTrackSeoV2.WebApi.Controllers
{
    public class SearchApiController : ApiController
    {
        private readonly ISearchService<GoogleSearchServiceModel> _googleSearchService;

        public SearchApiController(ISearchService<GoogleSearchServiceModel> googleSearchService)
        {
            _googleSearchService = googleSearchService;
        }

        
        public GoogleSearchServiceModel Get(string uri, string searchTerms)
        {
            _googleSearchService.SearchAsync(uri, searchTerms);
            return new GoogleSearchServiceModel();
        }
    }
}