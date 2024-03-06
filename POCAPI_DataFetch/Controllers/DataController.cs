using POCAPI_DataFetch.IService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace POCAPI_DataFetch.Controllers
{
    [RoutePrefix("api/zsk45")]
    public class DataController: ApiController
    {
        IDataService dataService;
        //public DataController(IDataService data)
        //{
        //    this.dataService = data;

        //}
        public DataController()
        {
           // this.dataService = data;

        }
        [HttpGet]
        [Route("Get")]
        public async Task<HttpResponseMessage> Get()
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            msg.ReasonPhrase = "success";
          

            return msg;
          //  return await dataService.GetBatchData(request);
        }
        [HttpGet]
        [Route("Snow")]
        public async Task<HttpResponseMessage> Snow()
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            msg.ReasonPhrase = "success";


            return msg;
            //  return await dataService.GetBatchData(request);
        }
        [HttpGet]
        [Route("Flake")]
        public string Flake()
        {

            string msg = "Success";

            return msg;
            //  return await dataService.GetBatchData(request);
        }

    }
}