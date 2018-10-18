using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmAsyncApp
{
    public class XiaomiPhone : AbstractPhone
    {
        public override void Show()
        {
            Console.WriteLine("这是一个小米手机基础版本！");
        }
    }
}
