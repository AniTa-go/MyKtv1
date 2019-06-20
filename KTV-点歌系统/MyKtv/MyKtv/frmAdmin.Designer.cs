namespace MyKtv
{
    partial class frmAdmin
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiUserGl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMiuscGuest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddMuisc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchMuisc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLjGuest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditSongPhoto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditSingerPhoto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserGl,
            this.tsmiMiuscGuest,
            this.tsmiLjGuest,
            this.tsmiHelp});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(473, 25);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiUserGl
            // 
            this.tsmiUserGl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddUser,
            this.tsmiSearchUser,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiUserGl.Name = "tsmiUserGl";
            this.tsmiUserGl.Size = new System.Drawing.Size(83, 21);
            this.tsmiUserGl.Text = "歌手管理(&S)";
            // 
            // tsmiAddUser
            // 
            this.tsmiAddUser.Name = "tsmiAddUser";
            this.tsmiAddUser.Size = new System.Drawing.Size(163, 22);
            this.tsmiAddUser.Text = "新增歌手(&N)";
            this.tsmiAddUser.Click += new System.EventHandler(this.tsmiAddUser_Click);
            // 
            // tsmiSearchUser
            // 
            this.tsmiSearchUser.Name = "tsmiSearchUser";
            this.tsmiSearchUser.Size = new System.Drawing.Size(163, 22);
            this.tsmiSearchUser.Text = "查询歌手信息(&S)";
            this.tsmiSearchUser.Click += new System.EventHandler(this.tsmiSearchUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(163, 22);
            this.tsmiExit.Text = "退出(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiMiuscGuest
            // 
            this.tsmiMiuscGuest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddMuisc,
            this.tsmiSearchMuisc});
            this.tsmiMiuscGuest.Name = "tsmiMiuscGuest";
            this.tsmiMiuscGuest.Size = new System.Drawing.Size(86, 21);
            this.tsmiMiuscGuest.Text = "歌曲管理(&O)";
            // 
            // tsmiAddMuisc
            // 
            this.tsmiAddMuisc.Name = "tsmiAddMuisc";
            this.tsmiAddMuisc.Size = new System.Drawing.Size(163, 22);
            this.tsmiAddMuisc.Text = "新增歌曲(&N)";
            this.tsmiAddMuisc.Click += new System.EventHandler(this.tsmiAddMuisc_Click);
            // 
            // tsmiSearchMuisc
            // 
            this.tsmiSearchMuisc.Name = "tsmiSearchMuisc";
            this.tsmiSearchMuisc.Size = new System.Drawing.Size(163, 22);
            this.tsmiSearchMuisc.Text = "查询歌曲信息(&S)";
            this.tsmiSearchMuisc.Click += new System.EventHandler(this.tsmiSearchMuisc_Click);
            // 
            // tsmiLjGuest
            // 
            this.tsmiLjGuest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditSongPhoto,
            this.tsmiEditSingerPhoto});
            this.tsmiLjGuest.Name = "tsmiLjGuest";
            this.tsmiLjGuest.Size = new System.Drawing.Size(108, 21);
            this.tsmiLjGuest.Text = "设置资源路径(&R)";
            // 
            // tsmiEditSongPhoto
            // 
            this.tsmiEditSongPhoto.Name = "tsmiEditSongPhoto";
            this.tsmiEditSongPhoto.Size = new System.Drawing.Size(187, 22);
            this.tsmiEditSongPhoto.Text = "设置歌手图片路径(&S)";
            this.tsmiEditSongPhoto.Click += new System.EventHandler(this.tsmiEditSongPhoto_Click);
            // 
            // tsmiEditSingerPhoto
            // 
            this.tsmiEditSingerPhoto.Name = "tsmiEditSingerPhoto";
            this.tsmiEditSingerPhoto.Size = new System.Drawing.Size(187, 22);
            this.tsmiEditSingerPhoto.Text = "设置歌曲路径(&O)";
            this.tsmiEditSingerPhoto.Click += new System.EventHandler(this.tsmiEditSingerPhoto_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmiHelp.Text = "帮助(&H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(140, 22);
            this.tsmiAbout.Text = "关于我们(&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 314);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTV后台管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserGl;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiMiuscGuest;
        private System.Windows.Forms.ToolStripMenuItem tsmiLjGuest;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddMuisc;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchMuisc;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditSongPhoto;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditSingerPhoto;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    }
}