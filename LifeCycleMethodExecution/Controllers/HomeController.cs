using LifeCycleMethodExecution.Extensions;
using LifeCycleMethodExecution.Filters;
using LifeCycleMethodExecution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeCycleMethodExecution.Controllers
{
    public class HomeController : Controller
    {
        [IsMobileRequest]
        public ActionResult Index()
        {
            return View();
        }
        [MyAuthenticationFilter(Order=1)]
        [MyAuthorizationFilter(Order = 2)]
        [MyCustomActionFilter(Order = 3)]
        [MyCustomActionFilter1(Order = 4)]
        [MyActionResultFilter]
        public ActionResult Index(string name)
        {
            HttpContext.Application["CustomFilterValue"] += "Index calling to return view"+DateTime.Now.ToLongTimeString()+"<br>";
            //return View();
            FooModel fooModel = new FooModel();
            fooModel.FooName = "Test Name";
            fooModel.FooType = "Test Type";
            return new JsonNETResult() { Data = fooModel };

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}