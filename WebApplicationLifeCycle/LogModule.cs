using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplicationLifeCycle
{
    public class LogModule:IHttpModule
    {
        public LogModule()
        {
            Debug.WriteLine("This was logged");
        }

           void IHttpModule.Dispose()
        {
            Debug.WriteLine("This was disposed");
          //  throw new NotImplementedException();
        }

          void IHttpModule.Init(HttpApplication context)
        {
            Debug.WriteLine("This was init");
            //throw new NotImplementedException();
        }
    }
}