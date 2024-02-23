using POCAPI_DataFetch.IRepository;
using POCAPI_DataFetch.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace POCAPI_DataFetch.Service
{
    public class DataService : IDataService
    {
        IDataRepository dataRepoLoad;
        public DataService( IDataRepository dataRepo)
        {
            this.dataRepoLoad = dataRepo;
        }
        public async Task<HttpResponseMessage> GetBatchData(HttpRequestMessage request)
        {
            return null;
        }
    }
}