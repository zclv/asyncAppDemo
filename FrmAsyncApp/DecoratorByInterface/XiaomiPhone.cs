using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmAsyncApp.DecoratorByInterface
{
    public class XiaomiPhone : IPhone
    {
        public void Show()
        {
            Console.WriteLine("这是一个小米手机！");
        }
    }
}
