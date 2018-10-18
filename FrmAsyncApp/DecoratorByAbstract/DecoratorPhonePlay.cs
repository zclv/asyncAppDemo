using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmAsyncApp.Decorator
{
    public class DecoratorPhonePlay:AbstractPhone
    {
        private AbstractPhone _phone;
        public DecoratorPhonePlay(AbstractPhone phone) 
        {
            _phone = phone;
        }
        public override void Show()
        {
            Console.WriteLine("This phone can play games.");
            this._phone.Show();
            Console.WriteLine("给手机加个外壳，保护一下.");
        }
    }
}
