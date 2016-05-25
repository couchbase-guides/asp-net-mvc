using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Couchbase;
using Couchbase.Configuration.Client;
using StructureMap.Web.Pipeline;

namespace Starter
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            throw new NotImplementedException("Set Up ClientConfiguration and Initialize ClusterHelper");
        }

        protected void Application_End()
        {
            throw new NotImplementedException("Close the ClusterHelper");
        }
    }
}
