using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAsyncApp.Observer
{
    public partial class PhoneObserver : Form
    {
        public PhoneObserver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 6;
            AbstractPhone xiaoMiPhone = new XiaomiPhone();
            xiaoMiPhone.PhonePlayHandler += () => Console.WriteLine("小米手机开发布会了，快来看了！");
            xiaoMiPhone.PhonePlayHandler += () => Console.WriteLine("红米NOT3！");
            xiaoMiPhone.PhonePlayHandler += () => Console.WriteLine("红米NOT4！");
            xiaoMiPhone.PhonePlayHandler += () => Console.WriteLine("红米NOT5！");
            xiaoMiPhone.Show(i);
        }
    }
}
