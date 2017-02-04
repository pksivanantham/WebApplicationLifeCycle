﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationLifeCycle.Handlers
{
    public class SampleHandler:IHttpHandler
    {

        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<b>This is from sample controller");
        }
    }
}