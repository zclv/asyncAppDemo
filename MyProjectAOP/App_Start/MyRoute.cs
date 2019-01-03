using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyProjectAOP.App_Start
{
    public class MyRoute : RouteBase
    {
        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            if (httpContext.Request.UserAgent.Contains("Chrome/71.0.3578.98"))
            {
                RouteData rd = new RouteData(this,new MvcRouteHandler());
                rd.Values.Add("controller","Pipe");
                rd.Values.Add("action", "Index");
                return rd;
            }
            return null;
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            return null;
        }
    }
}