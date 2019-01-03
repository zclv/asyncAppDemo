using MyProjectAOP.App_Start;
using MyProjectAOP.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyProjectAOP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
        public static void RegisterRefuse(RouteCollection routes)
        {
            routes.Add("myRoute",new MyRoute());
        }
        public static void RegisterMyRoute(RouteCollection routes)
        {
            Route route = new Route("MyRoute/{other}",new MyRouteHandler());
            RouteTable.Routes.Add(route); 
        }
    }
}
