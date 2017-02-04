using LifeCycleControllerFactory.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeCycleControllerFactory
{
    public class MyCustomDependencyResolver:IDependencyResolver
    {

        public object GetService(Type serviceType)
        {

            if (serviceType == typeof(IControllerFactory))
            {
                return new DefaultControllerFactory();
            }
     if(serviceType==typeof(IControllerActivator))
     {
         return new MyCustomControllerActivator();
     }
     if (serviceType == typeof(ContactController))
     {
         return new ContactController(new LogService());
     }
            if (serviceType == typeof(ITempDataProvider))
     {
         return new SessionStateTempDataProvider();
     }
            if (serviceType == typeof(System.Web.Mvc.Async.IAsyncActionInvoker))
            {
                return new System.Web.Mvc.Async.AsyncControllerActionInvoker();
            }
           
     return System.Activator.CreateInstance(serviceType);
         // return new DefaultControllerFactory();
            
            
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return null;
        }
    }
    public class MyCustomControllerActivator:IControllerActivator
    {
        private MyCustomDependencyResolver _resolver;

        public MyCustomDependencyResolver Current
        {
            get
            {
                if(_resolver==null)
                {
                    _resolver = new MyCustomDependencyResolver();
                }
                return _resolver;
            } 
    }
        public IController Create(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return (IController)Current.GetService(controllerType);
        }
    }
}