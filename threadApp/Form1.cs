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

namespace threadApp
{
    public partial class FrmThread : Form
    {
        public FrmThread()
        {
            InitializeComponent();
        }

        private void btnExecute1_Click(object sender, EventArgs e)
        {
            Thread threadExe1 = new Thread(delegate ()
            {
                for (int i =1; i < 11; i++)
                {
                    Console.WriteLine(i.ToString());
                    Thread.Sleep(1000);
                }
            });
            threadExe1.IsBackground = true;
            threadExe1.Start();
        }

        private void btnExecute2_Click(object sender, EventArgs e)
        {
            Thread threadExe2 = new Thread(()=>//limbda表达式写法 
            {
                for (int i = 1; i < 51; i++)
                {
                    Console.WriteLine("第二个进程{0}",i);
                    Thread.Sleep(100);
                }
            });
            threadExe2.IsBackground = true;
            threadExe2.Start();
        }
    }
}
