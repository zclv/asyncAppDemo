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

namespace asyncAppCallback
{
    public partial class FrmAsyncCallback : Form
    {
        public FrmAsyncCallback()
        {
            InitializeComponent();
            //【3】给实例赋值建立委托和方法的关系
            deteExecute = ExecuteTask;
        }
        //【1】定义一个委托
        public delegate int MyDelegate(int num,int ms);
        //【2】根据委托定义一个方法
        private int ExecuteTask(int num, int ms)
        {
            Thread.Sleep(ms);
            return num * num;
        }
        //【3】创建一个委托的实例
        private MyDelegate deteExecute = null;
        //【4】同时分发多个任务
        private void btnExecute_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <=10; i++)
            {
                deteExecute.BeginInvoke(10*i,1000*i, MyCallBack, i);
            }
        }
        //【5】监视任务执行状态，并将计算结果返回
        private void MyCallBack(IAsyncResult result)
        {
            int res = deteExecute.EndInvoke(result);
            Console.WriteLine("第{0}个计算结果为{1}",result.AsyncState,res);
        }
    }
}
