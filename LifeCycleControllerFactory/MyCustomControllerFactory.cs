using LifeCycleControllerFactory.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeCycleControllerFactory
{
    public class MyCustomControllerFactory:IControllerFactory
    {
        public IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            if (controllerName=="contact")
            {
               return  new ContactController(new LogService());
            }
            else
            {
                return new HomeController();
            }
        }

        public System.Web.SessionState.SessionStateBehavior GetControllerSessionBehavior(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            return System.Web.SessionState.SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            
        }
    }
    public class LogService:ILoggingService
    {
        
    }
}