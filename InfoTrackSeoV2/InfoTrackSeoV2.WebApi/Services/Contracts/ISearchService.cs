using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrackSeoV2.WebApi.Services.Contracts
{
    public interface ISearchService<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="searchTerms"></param>
        /// <returns></returns>
        Task<T> SearchAsync(string uri, string searchTerms);
    }
}
