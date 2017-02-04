using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplicationLifeCycle.Handlers;

namespace WebApplicationLifeCycle
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.Add(new Route("home/about", new SampleRouteController()));

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
        public  class SampleRouteController:IRouteHandler
        {

            public IHttpHandler GetHttpHandler(RequestContext requestContext)
            {
                return new SampleHandler();
            }
        }
    }
}
