using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmAsyncApp.DecoratorByInterface
{
    public class DecoratorPhonePlay : IPhone
    {
        private IPhone _phone;
        public DecoratorPhonePlay(IPhone phone)
        {
            _phone = phone;
        }
        public void Show()
        {
            Console.WriteLine("装饰前的手机，给手机添加个玩游戏的功能！");
            this._phone.Show();
            Console.WriteLine("然后给手机再加装个手机保护壳！");
        }
    }
}
