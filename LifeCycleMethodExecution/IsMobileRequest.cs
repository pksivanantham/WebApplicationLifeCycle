﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeCycleMethodExecution
{
    public class IsMobileRequest:ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo)
        {
            return controllerContext.HttpContext.Request.Browser.IsMobileDevice;
        }
    }
}