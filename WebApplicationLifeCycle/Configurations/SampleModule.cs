using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationLifeCycle.Configurations
{
    public class SampleModule:IHttpModule
    {
        private HttpApplication _context;
        public void Dispose()
        {
            
        }

        public void Init(HttpApplication context)
        {
            _context = context;
            context.MapRequestHandler += context_MapRequestHandler;            
        }

        void context_MapRequestHandler(object sender, EventArgs e)
        {
            var currentUrl = _context.Request.RequestContext.HttpContext.Request.RawUrl;
            if(currentUrl.Contains("contact"))
            {
                _context.Response.Write("This is from handler not handled by MVC Handler");
                //_context.Response.Redirect("/Home/Index");                
            }
            
        }
    }
}