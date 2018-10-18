namespace FrmAsyncApp
{
    partial class DecoratorPhone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDecoratorPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDecoratorPlay
            // 
            this.btnDecoratorPlay.Location = new System.Drawing.Point(61, 55);
            this.btnDecoratorPlay.Name = "btnDecoratorPlay";
            this.btnDecoratorPlay.Size = new System.Drawing.Size(113, 25);
            this.btnDecoratorPlay.TabIndex = 0;
            this.btnDecoratorPlay.Text = "装饰手机游戏";
            this.btnDecoratorPlay.UseVisualStyleBackColor = true;
            this.btnDecoratorPlay.Click += new System.EventHandler(this.btnDecoratorPlay_Click);
            // 
            // Decorator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 272);
            this.Controls.Add(this.btnDecoratorPlay);
            this.Name = "Decorator";
            this.Text = "Decorator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDecoratorPlay;
    }
}