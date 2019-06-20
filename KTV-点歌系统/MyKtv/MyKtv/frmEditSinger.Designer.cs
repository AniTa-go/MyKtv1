namespace MyKtv
{
    partial class frmEditSinger
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
            this.lblSingerName = new System.Windows.Forms.Label();
            this.lblSingerSex = new System.Windows.Forms.Label();
            this.lblSingerType = new System.Windows.Forms.Label();
            this.lblSingerMs = new System.Windows.Forms.Label();
            this.btnAddSinger = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSingerName = new System.Windows.Forms.TextBox();
            this.plSex = new System.Windows.Forms.Panel();
            this.rdoZh = new System.Windows.Forms.RadioButton();
            this.rdoNv = new System.Windows.Forms.RadioButton();
            this.rdoNan = new System.Windows.Forms.RadioButton();
            this.cboSingerType = new System.Windows.Forms.ComboBox();
            this.txtSingerMs = new System.Windows.Forms.TextBox();
            this.btnSingerPhoto = new System.Windows.Forms.Button();
            this.pboxSingerPhoto = new System.Windows.Forms.PictureBox();
            this.plSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSingerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSingerName
            // 
            this.lblSingerName.AutoSize = true;
            this.lblSingerName.Location = new System.Drawing.Point(71, 49);
            this.lblSingerName.Name = "lblSingerName";
            this.lblSingerName.Size = new System.Drawing.Size(29, 12);
            this.lblSingerName.TabIndex = 0;
            this.lblSingerName.Text = "姓名";
            // 
            // lblSingerSex
            // 
            this.lblSingerSex.AutoSize = true;
            this.lblSingerSex.Location = new System.Drawing.Point(71, 83);
            this.lblSingerSex.Name = "lblSingerSex";
            this.lblSingerSex.Size = new System.Drawing.Size(29, 12);
            this.lblSingerSex.TabIndex = 0;
            this.lblSingerSex.Text = "性别";
            // 
            // lblSingerType
            // 
            this.lblSingerType.AutoSize = true;
            this.lblSingerType.Location = new System.Drawing.Point(47, 117);
            this.lblSingerType.Name = "lblSingerType";
            this.lblSingerType.Size = new System.Drawing.Size(53, 12);
            this.lblSingerType.TabIndex = 0;
            this.lblSingerType.Text = "歌手类型";
            // 
            // lblSingerMs
            // 
            this.lblSingerMs.AutoSize = true;
            this.lblSingerMs.Location = new System.Drawing.Point(47, 151);
            this.lblSingerMs.Name = "lblSingerMs";
            this.lblSingerMs.Size = new System.Drawing.Size(53, 12);
            this.lblSingerMs.TabIndex = 0;
            this.lblSingerMs.Text = "歌手描述";
            // 
            // btnAddSinger
            // 
            this.btnAddSinger.Location = new System.Drawing.Point(297, 258);
            this.btnAddSinger.Name = "btnAddSinger";
            this.btnAddSinger.Size = new System.Drawing.Size(75, 23);
            this.btnAddSinger.TabIndex = 1;
            this.btnAddSinger.Text = "保存";
            this.btnAddSinger.UseVisualStyleBackColor = true;
            this.btnAddSinger.Click += new System.EventHandler(this.btnAddSinger_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(378, 258);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSingerName
            // 
            this.txtSingerName.Location = new System.Drawing.Point(106, 46);
            this.txtSingerName.Name = "txtSingerName";
            this.txtSingerName.Size = new System.Drawing.Size(211, 21);
            this.txtSingerName.TabIndex = 2;
            // 
            // plSex
            // 
            this.plSex.Controls.Add(this.rdoZh);
            this.plSex.Controls.Add(this.rdoNv);
            this.plSex.Controls.Add(this.rdoNan);
            this.plSex.Location = new System.Drawing.Point(107, 73);
            this.plSex.Name = "plSex";
            this.plSex.Size = new System.Drawing.Size(210, 34);
            this.plSex.TabIndex = 3;
            // 
            // rdoZh
            // 
            this.rdoZh.AutoSize = true;
            this.rdoZh.Location = new System.Drawing.Point(136, 8);
            this.rdoZh.Name = "rdoZh";
            this.rdoZh.Size = new System.Drawing.Size(47, 16);
            this.rdoZh.TabIndex = 0;
            this.rdoZh.TabStop = true;
            this.rdoZh.Text = "组合";
            this.rdoZh.UseVisualStyleBackColor = true;
            // 
            // rdoNv
            // 
            this.rdoNv.AutoSize = true;
            this.rdoNv.Location = new System.Drawing.Point(84, 8);
            this.rdoNv.Name = "rdoNv";
            this.rdoNv.Size = new System.Drawing.Size(35, 16);
            this.rdoNv.TabIndex = 0;
            this.rdoNv.TabStop = true;
            this.rdoNv.Text = "女";
            this.rdoNv.UseVisualStyleBackColor = true;
            // 
            // rdoNan
            // 
            this.rdoNan.AutoSize = true;
            this.rdoNan.Location = new System.Drawing.Point(35, 8);
            this.rdoNan.Name = "rdoNan";
            this.rdoNan.Size = new System.Drawing.Size(35, 16);
            this.rdoNan.TabIndex = 0;
            this.rdoNan.TabStop = true;
            this.rdoNan.Text = "男";
            this.rdoNan.UseVisualStyleBackColor = true;
            // 
            // cboSingerType
            // 
            this.cboSingerType.FormattingEnabled = true;
            this.cboSingerType.Location = new System.Drawing.Point(106, 114);
            this.cboSingerType.Name = "cboSingerType";
            this.cboSingerType.Size = new System.Drawing.Size(211, 20);
            this.cboSingerType.TabIndex = 4;
            // 
            // txtSingerMs
            // 
            this.txtSingerMs.Location = new System.Drawing.Point(106, 148);
            this.txtSingerMs.Multiline = true;
            this.txtSingerMs.Name = "txtSingerMs";
            this.txtSingerMs.Size = new System.Drawing.Size(347, 87);
            this.txtSingerMs.TabIndex = 5;
            // 
            // btnSingerPhoto
            // 
            this.btnSingerPhoto.Location = new System.Drawing.Point(353, 112);
            this.btnSingerPhoto.Name = "btnSingerPhoto";
            this.btnSingerPhoto.Size = new System.Drawing.Size(100, 23);
            this.btnSingerPhoto.TabIndex = 1;
            this.btnSingerPhoto.Text = "浏览";
            this.btnSingerPhoto.UseVisualStyleBackColor = true;
            this.btnSingerPhoto.Click += new System.EventHandler(this.btnSingerPhoto_Click);
            // 
            // pboxSingerPhoto
            // 
            this.pboxSingerPhoto.Location = new System.Drawing.Point(353, 17);
            this.pboxSingerPhoto.Name = "pboxSingerPhoto";
            this.pboxSingerPhoto.Size = new System.Drawing.Size(100, 89);
            this.pboxSingerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSingerPhoto.TabIndex = 6;
            this.pboxSingerPhoto.TabStop = false;
            this.pboxSingerPhoto.Click += new System.EventHandler(this.pboxSingerPhoto_Click);
            // 
            // frmEditSinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 303);
            this.Controls.Add(this.pboxSingerPhoto);
            this.Controls.Add(this.txtSingerMs);
            this.Controls.Add(this.cboSingerType);
            this.Controls.Add(this.plSex);
            this.Controls.Add(this.txtSingerName);
            this.Controls.Add(this.btnSingerPhoto);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddSinger);
            this.Controls.Add(this.lblSingerMs);
            this.Controls.Add(this.lblSingerType);
            this.Controls.Add(this.lblSingerSex);
            this.Controls.Add(this.lblSingerName);
            this.Name = "frmEditSinger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑歌手信息";
            this.Load += new System.EventHandler(this.frmEditSinger_Load);
            this.plSex.ResumeLayout(false);
            this.plSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSingerPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSingerName;
        private System.Windows.Forms.Label lblSingerSex;
        private System.Windows.Forms.Label lblSingerType;
        private System.Windows.Forms.Label lblSingerMs;
        private System.Windows.Forms.Button btnAddSinger;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSingerName;
        private System.Windows.Forms.Panel plSex;
        private System.Windows.Forms.RadioButton rdoZh;
        private System.Windows.Forms.RadioButton rdoNv;
        private System.Windows.Forms.RadioButton rdoNan;
        private System.Windows.Forms.ComboBox cboSingerType;
        private System.Windows.Forms.TextBox txtSingerMs;
        private System.Windows.Forms.Button btnSingerPhoto;
        private System.Windows.Forms.PictureBox pboxSingerPhoto;
    }
}