namespace MyKtv
{
    partial class frmPhotoPath
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
            this.btnLj = new System.Windows.Forms.Button();
            this.lblLja = new System.Windows.Forms.Label();
            this.lblLjb = new System.Windows.Forms.Label();
            this.txtLja = new System.Windows.Forms.TextBox();
            this.txtLjb = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLj
            // 
            this.btnLj.Location = new System.Drawing.Point(89, 96);
            this.btnLj.Name = "btnLj";
            this.btnLj.Size = new System.Drawing.Size(75, 23);
            this.btnLj.TabIndex = 0;
            this.btnLj.Text = "浏览";
            this.btnLj.UseVisualStyleBackColor = true;
            this.btnLj.Click += new System.EventHandler(this.btnLj_Click);
            // 
            // lblLja
            // 
            this.lblLja.AutoSize = true;
            this.lblLja.Location = new System.Drawing.Point(28, 27);
            this.lblLja.Name = "lblLja";
            this.lblLja.Size = new System.Drawing.Size(65, 12);
            this.lblLja.TabIndex = 1;
            this.lblLja.Text = "当前路径：";
            // 
            // lblLjb
            // 
            this.lblLjb.AutoSize = true;
            this.lblLjb.Location = new System.Drawing.Point(42, 63);
            this.lblLjb.Name = "lblLjb";
            this.lblLjb.Size = new System.Drawing.Size(53, 12);
            this.lblLjb.TabIndex = 1;
            this.lblLjb.Text = "新路径：";
            // 
            // txtLja
            // 
            this.txtLja.Location = new System.Drawing.Point(89, 24);
            this.txtLja.Name = "txtLja";
            this.txtLja.ReadOnly = true;
            this.txtLja.Size = new System.Drawing.Size(349, 21);
            this.txtLja.TabIndex = 2;
            // 
            // txtLjb
            // 
            this.txtLjb.Location = new System.Drawing.Point(89, 60);
            this.txtLjb.Name = "txtLjb";
            this.txtLjb.Size = new System.Drawing.Size(349, 21);
            this.txtLjb.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "保存";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(363, 142);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPhotoPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 177);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLjb);
            this.Controls.Add(this.txtLja);
            this.Controls.Add(this.lblLjb);
            this.Controls.Add(this.lblLja);
            this.Controls.Add(this.btnLj);
            this.Name = "frmPhotoPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置歌手照片路径";
            this.Load += new System.EventHandler(this.frmPhotoPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLj;
        private System.Windows.Forms.Label lblLja;
        private System.Windows.Forms.Label lblLjb;
        private System.Windows.Forms.TextBox txtLja;
        private System.Windows.Forms.TextBox txtLjb;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}