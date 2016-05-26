using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Couchbase;
using Couchbase.Configuration.Client;

namespace Starter
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            throw new NotImplementedException("Initialize ClusterHelper with ClientConfiguration");
        }

        protected void Application_End()
        {
            throw new NotImplementedException("Clean up ClusterHelper with Close");
        }
    }
}
