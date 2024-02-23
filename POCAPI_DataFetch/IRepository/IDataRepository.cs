using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace POCAPI_DataFetch.IRepository
{
    public interface IDataRepository
    {
        new Task<DataSet> GetRawDataDetailsForBatch();
    }
}