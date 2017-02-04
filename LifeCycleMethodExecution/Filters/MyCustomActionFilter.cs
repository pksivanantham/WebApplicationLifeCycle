using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace LifeCycleMethodExecution.Filters
{
    public class MyCustomActionFilter:FilterAttribute,IActionFilter
    {
         void IActionFilter.OnActionExecuting(ActionExecutingContext onActionExecutingContext)
        {
            HttpContext.Current.Application["CustomFilterValue"] += "MyAction FilterOnActionExecuting"+DateTime.Now.ToLongTimeString()+"<br>";
        }
         void IActionFilter.OnActionExecuted(ActionExecutedContext onActionExecutingContext)
        {
            HttpContext.Current.Application["CustomFilterValue"] += "MyAction FilterOnActionExecuted"+DateTime.Now.ToLongTimeString()+"<br>";
        }
    }
    public class MyCustomActionFilter1 : FilterAttribute, IActionFilter
    {
         void IActionFilter.OnActionExecuting(ActionExecutingContext onActionExecutingContext)
        {
            HttpContext.Current.Application["CustomFilterValue"] += "MyAction Filter 1 OnActionExecuting"+DateTime.Now.ToLongTimeString()+"<br>";
        }
         void IActionFilter.OnActionExecuted(ActionExecutedContext onActionExecutingContext)
        {
            HttpContext.Current.Application["CustomFilterValue"] += "MyAction Filter 2  OnActionExecuted"+DateTime.Now.ToLongTimeString()+"<br>";
        }
    }

    public class MyAuthenticationFilter:FilterAttribute,IAuthenticationFilter
    {


        public void OnAuthentication(AuthenticationContext filterContext)
        {
            HttpContext.Current.Application["CustomFilterValue"] += "OnAuthentication"+DateTime.Now.ToLongTimeString()+"<br>";
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
          
            HttpContext.Current.Application["CustomFilterValue"] += "OnAuthenticationChallenge"+DateTime.Now.ToLongTimeString()+"<br>" ;
        }
    }
    public class MyAuthorizationFilter:FilterAttribute,IAuthorizationFilter
    {

        public void OnAuthorization(AuthorizationContext filterContext)
        {
          //filterContext.HttpContext.Response.StatusCode = 401;
            //filterContext.Result = new HttpStatusCodeResult(404);
            HttpContext.Current.Application["CustomFilterValue"] += "OnAuthorization"+DateTime.Now.ToLongTimeString()+"<br>";
        }
    }

    public class MyActionResultFilter:FilterAttribute, IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            HttpContext.Current.Application["CustomFilterValue"] += "OnResultExecuting"+DateTime.Now.ToLongTimeString()+"<br>";
        }
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            HttpContext.Current.Application["CustomFilterValue"] += "OnResultExecuted"+DateTime.Now.ToLongTimeString()+"<br>";
        }
    }
}