using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MyProjectAOP.Controllers
{
    public class MyRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new MyHttpHandler(requestContext);
        }
    }
    public class MyHttpHandler : IHttpHandler
    {
        public MyHttpHandler(RequestContext requestContext)
        {
            Console.WriteLine("构造MyHttpHandler");
        }
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            string url = context.Request.Url.AbsoluteUri;
            context.Response.Write($"这里是我定制的{this.GetType().Name}");
            context.Response.Write($"当前地址为{url}");
            context.Response.End();
        }
    }
}