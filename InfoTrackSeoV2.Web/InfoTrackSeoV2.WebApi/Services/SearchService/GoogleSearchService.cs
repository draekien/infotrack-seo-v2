using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using InfoTrackSeoV2.WebApi.Models.SearchServiceModel;
using InfoTrackSeoV2.WebApi.Services.Contracts;

namespace InfoTrackSeoV2.WebApi.Services.SearchService
{
    public class GoogleSearchService : ISearchService<GoogleSearchServiceModel>
    {
        private readonly ICrawlerService _crawlerService;
        private const string GoogleSearchUri = "https://www.google.com.au/search?gl=au&hl=en&pws=0&num=100&q=";
        public GoogleSearchService(ICrawlerService crawlerService)
        {
            _crawlerService = crawlerService;
        }

        public async Task<GoogleSearchServiceModel> SearchAsync(string uri, string searchTerms)
        {
            var crawlerResponse = await _crawlerService.CrawlAsync(GoogleSearchUri + HttpUtility.UrlEncode(searchTerms));
            
            return new GoogleSearchServiceModel()
            {
                Response = crawlerResponse.Response,
                IsSuccess = crawlerResponse.IsSuccess,
                ErrorMessage = crawlerResponse.ErrorMessage
            };
        }
    }
}