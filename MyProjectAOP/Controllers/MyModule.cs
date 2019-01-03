using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProjectAOP.Controllers
{
    public class MyModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.ResolveRequestCache += new EventHandler(MyModuleEvent);
        }
        public void MyModuleEvent(Object sender,EventArgs args)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext httpContext = application.Context;
            httpContext.Response.Write("This is My Specile Module!!!");
            httpContext.Response.End();
        }
    }
}