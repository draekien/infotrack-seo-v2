using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using InfoTrackSeoV2.WebApi.Models.CrawlerServiceModel;
using InfoTrackSeoV2.WebApi.Services.Contracts;
using Newtonsoft.Json;

namespace InfoTrackSeoV2.WebApi.Services.CrawlerService
{
    public class CrawlerService : ICrawlerService
    {
        private readonly HttpClient _httpClient;

        public CrawlerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CrawlerServiceModel> CrawlAsync(string uri)
        {
            using(var request = CreateHttpRequestMessage(uri, HttpMethod.Get, null))
            using (var response = await _httpClient.SendAsync(request))
            {
                if (!response.IsSuccessStatusCode)
                {
                    return new CrawlerServiceModel()
                    {
                        ErrorMessage = $"{response.StatusCode}: Failed to find resource"
                    };
                }

                var content = await response.Content.ReadAsStringAsync();
                return new CrawlerServiceModel()
                {
                    Response = content,
                    IsSuccess = true
                };
            }
        }

        private static HttpRequestMessage CreateHttpRequestMessage(string uri, HttpMethod httpMethod,
            HttpContent content)
        {
            var request = new HttpRequestMessage()
            {
                Method = httpMethod,
                RequestUri = new Uri(uri)
            };

            if (content != null)
            {
                request.Content = content;
            }

            return request;
        }
    }
}