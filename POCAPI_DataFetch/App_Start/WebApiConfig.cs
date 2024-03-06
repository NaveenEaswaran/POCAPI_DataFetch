using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace POCAPI_DataFetch
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.MapHttpAttributeRoutes();
         //config.Filters.Add(new AuthFilterAttribute());
        }
    }
}
