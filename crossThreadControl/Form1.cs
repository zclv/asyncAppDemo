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

namespace crossThreadControl
{
    public partial class FrmCrossThread : Form
    {
        public FrmCrossThread()
        {
            InitializeComponent();
        }

        private void btnExecute1_Click(object sender, EventArgs e)
        {
            int a = 0;
            Thread objThread = new Thread(() =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    a += i;
                    if (this.lblTaskRes1.InvokeRequired)//判断是否调用Invoke方法(判断我要访问的控件是否是不是必须要使用Invoke方法才能访问到)
                    {
                        //Invoke() 方法第一个参数是返回值为void的委托，第二个是给委托对应的方法传递参数的
                        this.lblTaskRes1.Invoke(new Action<string>(p=> { this.lblTaskRes1.Text = p; }),a.ToString());
                    }
                    Thread.Sleep(200);//当前这个Thread为主程序的线程
                }
            });
            objThread.IsBackground = true;
            objThread.Start();
        }

        private void btnExecute2_Click(object sender, EventArgs e)
        {
            int a = 0;
            Thread objThread = new Thread(() =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    a += i;
                    if (this.lblTaskRes2.InvokeRequired)//判断是否调用Invoke方法(判断我要访问的控件是否是不是必须要使用Invoke方法才能访问到)
                    {
                        //Invoke() 方法第一个参数是返回值为void的委托，第二个是给委托对应的方法传递参数的
                        this.lblTaskRes2.Invoke(new Action<string>(p => { this.lblTaskRes2.Text = p; }), a.ToString());
                    }
                    Thread.Sleep(200);//当前这个Thread为主程序的线程
                }
            });
            objThread.IsBackground = true;
            objThread.Start();
        }
    }
}
