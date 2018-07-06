namespace threadApp
{
    partial class FrmThread
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExecute1 = new System.Windows.Forms.Button();
            this.btnExecute2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExecute1
            // 
            this.btnExecute1.Location = new System.Drawing.Point(58, 115);
            this.btnExecute1.Name = "btnExecute1";
            this.btnExecute1.Size = new System.Drawing.Size(86, 52);
            this.btnExecute1.TabIndex = 0;
            this.btnExecute1.Text = "执行任务1";
            this.btnExecute1.UseVisualStyleBackColor = true;
            this.btnExecute1.Click += new System.EventHandler(this.btnExecute1_Click);
            // 
            // btnExecute2
            // 
            this.btnExecute2.Location = new System.Drawing.Point(320, 115);
            this.btnExecute2.Name = "btnExecute2";
            this.btnExecute2.Size = new System.Drawing.Size(86, 52);
            this.btnExecute2.TabIndex = 1;
            this.btnExecute2.Text = "执行任务2";
            this.btnExecute2.UseVisualStyleBackColor = true;
            this.btnExecute2.Click += new System.EventHandler(this.btnExecute2_Click);
            // 
            // FrmThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 269);
            this.Controls.Add(this.btnExecute2);
            this.Controls.Add(this.btnExecute1);
            this.Name = "FrmThread";
            this.Text = "多线程执行任务";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecute1;
        private System.Windows.Forms.Button btnExecute2;
    }
}

