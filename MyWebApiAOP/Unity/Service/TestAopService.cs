using MyWebApiAOP.Unity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApiAOP.Unity.Service
{
    public class TestAopService: ITestAop
    {
        public int GetNum(int x, int y)
        {
            return x + y;
        }
    }
}