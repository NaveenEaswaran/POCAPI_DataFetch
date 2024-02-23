using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace POCAPI_DataFetch.IService
{
    public interface IDataService
    {
        Task<HttpResponseMessage> GetBatchData(HttpRequestMessage request);
    }
}
