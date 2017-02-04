using LifeCycleResultExecution.Extensions;
using LifeCycleResultExecution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeCycleResultExecution.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FooModel fooModel = new FooModel();
            fooModel.FooName = "Test Name";
            fooModel.FooType = "Test Type";
            return new JsonNETResult(){Data=fooModel};
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