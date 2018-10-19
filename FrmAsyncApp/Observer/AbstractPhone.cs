using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmAsyncApp.Observer
{
    public abstract class AbstractPhone
    {  
        public event Action PhonePlayHandler;
        protected virtual void ValidatePhone(int num)
        {
            if (num > 5 && PhonePlayHandler != null)
            {
                PhonePlayHandler.Invoke();
            }
        }
        public virtual void Show(int i)
        {
            ValidatePhone(i);
        }
    }
}
