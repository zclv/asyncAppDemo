using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAsyncApp.DecoratorByInterface
{
    public partial class DecoratorIPhone : Form
    {
        public DecoratorIPhone()
        {
            InitializeComponent();
        }

        private void btnDecoratorPlay_Click(object sender, EventArgs e)
        {
            IPhone xiaomiPhone = new XiaomiPhone();
            IPhone phone = new DecoratorPhonePlay(xiaomiPhone);
            phone.Show();
        }
    }
}
