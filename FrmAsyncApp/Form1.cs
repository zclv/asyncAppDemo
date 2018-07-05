using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAsyncApp
{
    public partial class frmAsync : Form
    {
        public frmAsync()
        {
            InitializeComponent();
        }
        public string Execute1(int a, int b)
        {
            Thread.Sleep(5000);
            return (a + b).ToString();
        }
        public string Execute2(int a, int b)
        {
            return (a + b).ToString();
        }
        private void btnExecut_Click(object sender, EventArgs e)
        {
            lblText1.Text = "正在计算中......";
            asyncAdd asAdd = Execute1;
            IAsyncResult asRes = asAdd.BeginInvoke(1, 2,null, null);
            lblText2.Text= Execute2(2, 2);
            lblText1.Text = asAdd.EndInvoke(asRes);
        }
    }
    public delegate string asyncAdd(int a, int b);
}
