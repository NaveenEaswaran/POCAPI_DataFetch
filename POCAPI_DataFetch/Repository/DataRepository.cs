using POCAPI_DataFetch.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace POCAPI_DataFetch.Repository
{
    public class DataRepository: IDataRepository
    {
        public async Task<DataSet> GetRawDataDetailsForBatch()
        {
           // return await ExecuteSQLProcedure("ConZSK30", "sp_ZSK30SampleData_Statistics_EquipInt", parameters)
            return null;
        }
    }
}