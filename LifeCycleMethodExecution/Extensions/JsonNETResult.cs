using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeCycleMethodExecution.Extensions
{
    public class JsonNETResult:ActionResult
    {

        public object Data { get; set; }


        public override void ExecuteResult(ControllerContext context)
        {
            HttpContext.Current.Application["CustomFilterValue"] += "ExecuteResult"+DateTime.Now.ToLongTimeString()+"<br>";
            var response = context.HttpContext.Response;
            //response.ContentType = "application/json";
            //response.Write(JsonConvert.SerializeObject(Data) );
            response.Write(HttpContext.Current.Application["CustomFilterValue"].ToString());
        }
    }
}