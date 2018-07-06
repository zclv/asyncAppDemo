namespace crossThreadControl
{
    partial class FrmCrossThread
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
            this.lblTask1 = new System.Windows.Forms.Label();
            this.lblTask2 = new System.Windows.Forms.Label();
            this.lblTaskRes1 = new System.Windows.Forms.Label();
            this.lblTaskRes2 = new System.Windows.Forms.Label();
            this.btnExecute1 = new System.Windows.Forms.Button();
            this.btnExecute2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTask1
            // 
            this.lblTask1.AutoSize = true;
            this.lblTask1.Location = new System.Drawing.Point(65, 76);
            this.lblTask1.Name = "lblTask1";
            this.lblTask1.Size = new System.Drawing.Size(107, 12);
            this.lblTask1.TabIndex = 0;
            this.lblTask1.Text = "任务1执行的结果：";
            // 
            // lblTask2
            // 
            this.lblTask2.AutoSize = true;
            this.lblTask2.Location = new System.Drawing.Point(65, 135);
            this.lblTask2.Name = "lblTask2";
            this.lblTask2.Size = new System.Drawing.Size(107, 12);
            this.lblTask2.TabIndex = 1;
            this.lblTask2.Text = "任务2执行的结果：";
            // 
            // lblTaskRes1
            // 
            this.lblTaskRes1.AutoSize = true;
            this.lblTaskRes1.Location = new System.Drawing.Point(297, 76);
            this.lblTaskRes1.Name = "lblTaskRes1";
            this.lblTaskRes1.Size = new System.Drawing.Size(11, 12);
            this.lblTaskRes1.TabIndex = 2;
            this.lblTaskRes1.Text = "0";
            // 
            // lblTaskRes2
            // 
            this.lblTaskRes2.AutoSize = true;
            this.lblTaskRes2.Location = new System.Drawing.Point(297, 135);
            this.lblTaskRes2.Name = "lblTaskRes2";
            this.lblTaskRes2.Size = new System.Drawing.Size(11, 12);
            this.lblTaskRes2.TabIndex = 3;
            this.lblTaskRes2.Text = "0";
            // 
            // btnExecute1
            // 
            this.btnExecute1.Location = new System.Drawing.Point(67, 232);
            this.btnExecute1.Name = "btnExecute1";
            this.btnExecute1.Size = new System.Drawing.Size(75, 23);
            this.btnExecute1.TabIndex = 4;
            this.btnExecute1.Text = "执行任务1";
            this.btnExecute1.UseVisualStyleBackColor = true;
            this.btnExecute1.Click += new System.EventHandler(this.btnExecute1_Click);
            // 
            // btnExecute2
            // 
            this.btnExecute2.Location = new System.Drawing.Point(299, 232);
            this.btnExecute2.Name = "btnExecute2";
            this.btnExecute2.Size = new System.Drawing.Size(75, 23);
            this.btnExecute2.TabIndex = 5;
            this.btnExecute2.Text = "执行任务2";
            this.btnExecute2.UseVisualStyleBackColor = true;
            this.btnExecute2.Click += new System.EventHandler(this.btnExecute2_Click);
            // 
            // FrmCrossThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 308);
            this.Controls.Add(this.btnExecute2);
            this.Controls.Add(this.btnExecute1);
            this.Controls.Add(this.lblTaskRes2);
            this.Controls.Add(this.lblTaskRes1);
            this.Controls.Add(this.lblTask2);
            this.Controls.Add(this.lblTask1);
            this.Name = "FrmCrossThread";
            this.Text = "跨线程访问";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTask1;
        private System.Windows.Forms.Label lblTask2;
        private System.Windows.Forms.Label lblTaskRes1;
        private System.Windows.Forms.Label lblTaskRes2;
        private System.Windows.Forms.Button btnExecute1;
        private System.Windows.Forms.Button btnExecute2;
    }
}

