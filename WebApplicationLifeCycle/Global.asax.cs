using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApplicationLifeCycle;

[assembly: PreApplicationStartMethod(typeof(MvcApplication), "Register")]
namespace WebApplicationLifeCycle
{
    
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void Register()
        {
            HttpApplication.RegisterModule(typeof(LogModule));
            
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_End()
        {
            Debug.WriteLine("Application End");
        }
        protected void Application_BeginRequest()
        {
            Debug.WriteLine("Begin request");
        }
        protected void Application_MapRequestHandler()
        {
            Debug.WriteLine("Begin request");
        }
        protected void Application_PostMapRequestHandler()
        {
            Debug.WriteLine("Begin request");
        }
        protected void Application_AcquireRequestState()
        {
            Debug.WriteLine("Begin request");
        }
        protected void Application_PreRequestHadlerExecute()
        {
            Debug.WriteLine("Begin request");
        }
        protected void Application_PostRequestHandlerExecute()
        {
            Debug.WriteLine("Begin request");
        }
        protected void Application_EndRequest()
        {
            Debug.WriteLine("Begin request");
        }
        protected void Application_RequestCompleted()
        {
            Debug.WriteLine("Begin request");
        }
    }

}
