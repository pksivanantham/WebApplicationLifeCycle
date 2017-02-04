using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeCycleControllerFactory.Controllers
{
    public class ContactController : IController
    {
        public ContactController(ILoggingService loggingServicee)
        {

        }

        public void Execute(System.Web.Routing.RequestContext requestContext)
        {
            HttpContext.Current.Response.Write("This is from controller factory");
        }
    }
}