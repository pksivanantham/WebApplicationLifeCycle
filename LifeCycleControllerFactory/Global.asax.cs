using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace LifeCycleControllerFactory
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public void Application_PreRequestHandlerExecute()
        {
            Debug.WriteLine("Pre request");
        }
        public void Application_PostRequestHandlerExecute()
        {

            Debug.WriteLine("Pre request-->DependencyResolver-->" + DependencyResolver.Current.GetType().Name.ToString());
            Debug.WriteLine("Pre request-->DependencyResolver-->" + ControllerBuilder.Current.GetType().Name.ToString());
        }
        protected void Application_Start()
        {

            DependencyResolver.SetResolver(new MyCustomDependencyResolver());
//            ControllerBuilder.Current.SetControllerFactory(new MyCustomControllerFactory());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
