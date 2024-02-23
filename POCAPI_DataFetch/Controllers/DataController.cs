using POCAPI_DataFetch.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace POCAPI_DataFetch.Controllers
{
    public class DataController: ApiController
    {
        IDataService dataService;
        public DataController(IDataService data)
        {
            this.dataService = data;

        }
        [HttpPost]
        [Route("")]
        public async Task<HttpResponseMessage> Post(HttpRequestMessage request)
        {
            return await dataService.GetBatchData(request);
        }
    }
}