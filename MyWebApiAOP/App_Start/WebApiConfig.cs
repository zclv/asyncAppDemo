using MyWebApiAOP.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MyWebApiAOP
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            //把webapi的DependencyResolver换成自己的Unity版本的
            config.DependencyResolver = new UnityDependencyResolver(UnityContainerFactory.GetContainer());

            // Web API 路由
            config.MapHttpAttributeRoutes();

            //一般不指定action 因为restful，是以资源为目标，没有操作的概念，操作由httpmethod来识别
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
               name: "WebApi",
               routeTemplate: "rest/{controller}/{action}/{id}",
               defaults: new { id = RouteParameter.Optional }
           );
        }
    }
}
