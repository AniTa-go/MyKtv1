namespace MyKtv
{
    partial class frmAbout
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
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.pboxa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(43, 26);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(113, 12);
            this.lbla.TabIndex = 0;
            this.lbla.Text = "北大青鸟恩驰校区：";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(43, 49);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(59, 12);
            this.lblb.TabIndex = 0;
            this.lblb.Text = "MyKtv项目";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(43, 72);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(77, 12);
            this.lblc.TabIndex = 0;
            this.lblc.Text = "版权：@zxd组";
            // 
            // pboxa
            // 
            this.pboxa.Image = global::MyKtv.Properties.Resources.defalut;
            this.pboxa.Location = new System.Drawing.Point(45, 105);
            this.pboxa.Name = "pboxa";
            this.pboxa.Size = new System.Drawing.Size(365, 169);
            this.pboxa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxa.TabIndex = 1;
            this.pboxa.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 299);
            this.Controls.Add(this.pboxa);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于我们";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pboxa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.PictureBox pboxa;
    }
}