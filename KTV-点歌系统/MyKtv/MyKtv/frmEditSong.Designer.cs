namespace MyKtv
{
    partial class frmEditSong
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
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblSongNames = new System.Windows.Forms.Label();
            this.lblSongType = new System.Windows.Forms.Label();
            this.lblSongSinger = new System.Windows.Forms.Label();
            this.lblSonglj = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.txtSongNames = new System.Windows.Forms.TextBox();
            this.cboSongType = new System.Windows.Forms.ComboBox();
            this.txtSongSinger = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSongLj = new System.Windows.Forms.TextBox();
            this.btnSongLj = new System.Windows.Forms.Button();
            this.btnSongAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Location = new System.Drawing.Point(47, 38);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(53, 12);
            this.lblSongName.TabIndex = 0;
            this.lblSongName.Text = "歌曲名称";
            // 
            // lblSongNames
            // 
            this.lblSongNames.AutoSize = true;
            this.lblSongNames.Location = new System.Drawing.Point(47, 85);
            this.lblSongNames.Name = "lblSongNames";
            this.lblSongNames.Size = new System.Drawing.Size(53, 12);
            this.lblSongNames.TabIndex = 0;
            this.lblSongNames.Text = "拼音缩写";
            // 
            // lblSongType
            // 
            this.lblSongType.AutoSize = true;
            this.lblSongType.Location = new System.Drawing.Point(47, 132);
            this.lblSongType.Name = "lblSongType";
            this.lblSongType.Size = new System.Drawing.Size(53, 12);
            this.lblSongType.TabIndex = 0;
            this.lblSongType.Text = "歌曲类型";
            // 
            // lblSongSinger
            // 
            this.lblSongSinger.AutoSize = true;
            this.lblSongSinger.Location = new System.Drawing.Point(71, 179);
            this.lblSongSinger.Name = "lblSongSinger";
            this.lblSongSinger.Size = new System.Drawing.Size(29, 12);
            this.lblSongSinger.TabIndex = 0;
            this.lblSongSinger.Text = "歌手";
            // 
            // lblSonglj
            // 
            this.lblSonglj.AutoSize = true;
            this.lblSonglj.Location = new System.Drawing.Point(35, 226);
            this.lblSonglj.Name = "lblSonglj";
            this.lblSonglj.Size = new System.Drawing.Size(65, 12);
            this.lblSonglj.TabIndex = 0;
            this.lblSonglj.Text = "歌曲文件名";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(106, 35);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(269, 21);
            this.txtSongName.TabIndex = 1;
            // 
            // txtSongNames
            // 
            this.txtSongNames.Location = new System.Drawing.Point(106, 82);
            this.txtSongNames.Name = "txtSongNames";
            this.txtSongNames.Size = new System.Drawing.Size(269, 21);
            this.txtSongNames.TabIndex = 1;
            // 
            // cboSongType
            // 
            this.cboSongType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSongType.FormattingEnabled = true;
            this.cboSongType.Location = new System.Drawing.Point(106, 129);
            this.cboSongType.Name = "cboSongType";
            this.cboSongType.Size = new System.Drawing.Size(269, 20);
            this.cboSongType.TabIndex = 2;
            // 
            // txtSongSinger
            // 
            this.txtSongSinger.Location = new System.Drawing.Point(106, 176);
            this.txtSongSinger.Name = "txtSongSinger";
            this.txtSongSinger.ReadOnly = true;
            this.txtSongSinger.Size = new System.Drawing.Size(174, 21);
            this.txtSongSinger.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(300, 174);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSongLj
            // 
            this.txtSongLj.Location = new System.Drawing.Point(49, 256);
            this.txtSongLj.Name = "txtSongLj";
            this.txtSongLj.Size = new System.Drawing.Size(231, 21);
            this.txtSongLj.TabIndex = 1;
            // 
            // btnSongLj
            // 
            this.btnSongLj.Location = new System.Drawing.Point(300, 254);
            this.btnSongLj.Name = "btnSongLj";
            this.btnSongLj.Size = new System.Drawing.Size(75, 23);
            this.btnSongLj.TabIndex = 4;
            this.btnSongLj.Text = "浏览";
            this.btnSongLj.UseVisualStyleBackColor = true;
            this.btnSongLj.Click += new System.EventHandler(this.btnSongLj_Click);
            // 
            // btnSongAdd
            // 
            this.btnSongAdd.Location = new System.Drawing.Point(205, 298);
            this.btnSongAdd.Name = "btnSongAdd";
            this.btnSongAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSongAdd.TabIndex = 5;
            this.btnSongAdd.Text = "保存";
            this.btnSongAdd.UseVisualStyleBackColor = true;
            this.btnSongAdd.Click += new System.EventHandler(this.btnSongAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(300, 298);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmEditSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 344);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSongAdd);
            this.Controls.Add(this.btnSongLj);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSongSinger);
            this.Controls.Add(this.cboSongType);
            this.Controls.Add(this.txtSongLj);
            this.Controls.Add(this.txtSongNames);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.lblSonglj);
            this.Controls.Add(this.lblSongSinger);
            this.Controls.Add(this.lblSongType);
            this.Controls.Add(this.lblSongNames);
            this.Controls.Add(this.lblSongName);
            this.Name = "frmEditSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑歌曲信息";
            this.Load += new System.EventHandler(this.frmEditSong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblSongNames;
        private System.Windows.Forms.Label lblSongType;
        private System.Windows.Forms.Label lblSongSinger;
        private System.Windows.Forms.Label lblSonglj;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.TextBox txtSongNames;
        private System.Windows.Forms.ComboBox cboSongType;
        public System.Windows.Forms.TextBox txtSongSinger;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSongLj;
        private System.Windows.Forms.Button btnSongLj;
        private System.Windows.Forms.Button btnSongAdd;
        private System.Windows.Forms.Button btnClose;
    }
}