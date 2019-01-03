using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProjectAOP.Controllers
{
    public class MyHandler : IHttpHandler
    {
        public bool IsReusable =>  true;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("这是我的测试Handler");
        }
    }
}