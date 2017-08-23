using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ContosoMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected void Application_Start()
        {
            //log.Info("Welcome to Logging world!");
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        public void Application_Error(object sender, EventArgs e)
        {
           var exe = Server.GetLastError();
            //Log this error to the text file using log4net.

            log.Info(exe);


            //Send the notification to the concerned parties.
           // Server.ClearError();
            
        }
        public void Application_BeginRequest()
        {

        }
    }
}
