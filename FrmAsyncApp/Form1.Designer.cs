namespace FrmAsyncApp
{
    partial class frmAsync
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
            this.btnExecut = new System.Windows.Forms.Button();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExecut
            // 
            this.btnExecut.Location = new System.Drawing.Point(49, 184);
            this.btnExecut.Name = "btnExecut";
            this.btnExecut.Size = new System.Drawing.Size(75, 23);
            this.btnExecut.TabIndex = 0;
            this.btnExecut.Text = "开始执行";
            this.btnExecut.UseVisualStyleBackColor = true;
            this.btnExecut.Click += new System.EventHandler(this.btnExecut_Click);
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(47, 54);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(11, 12);
            this.lblText1.TabIndex = 1;
            this.lblText1.Text = "0";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Location = new System.Drawing.Point(47, 104);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(11, 12);
            this.lblText2.TabIndex = 2;
            this.lblText2.Text = "0";
            // 
            // frmAsync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 276);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.btnExecut);
            this.Name = "frmAsync";
            this.Text = "异步执行程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecut;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
    }
}

