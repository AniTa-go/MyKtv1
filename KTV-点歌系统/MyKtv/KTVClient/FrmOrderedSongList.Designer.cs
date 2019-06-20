namespace KTVClient
{
    partial class FrmOrderedSongList
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
            this.pBoxD1 = new System.Windows.Forms.PictureBox();
            this.pBoxD2 = new System.Windows.Forms.PictureBox();
            this.pBoxD3 = new System.Windows.Forms.PictureBox();
            this.pBoxD4 = new System.Windows.Forms.PictureBox();
            this.pBoxD5 = new System.Windows.Forms.PictureBox();
            this.pBoxD6 = new System.Windows.Forms.PictureBox();
            this.lblD1 = new System.Windows.Forms.Label();
            this.lblD2 = new System.Windows.Forms.Label();
            this.lblD3 = new System.Windows.Forms.Label();
            this.lblD4 = new System.Windows.Forms.Label();
            this.lblD5 = new System.Windows.Forms.Label();
            this.lblD6 = new System.Windows.Forms.Label();
            this.lvsong = new System.Windows.Forms.ListView();
            this.songname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songstate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD6)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxD1
            // 
            this.pBoxD1.BackColor = System.Drawing.Color.Transparent;
            this.pBoxD1.Image = global::KTVClient.Properties.Resources.主页面;
            this.pBoxD1.Location = new System.Drawing.Point(111, 302);
            this.pBoxD1.Name = "pBoxD1";
            this.pBoxD1.Size = new System.Drawing.Size(50, 50);
            this.pBoxD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxD1.TabIndex = 1;
            this.pBoxD1.TabStop = false;
            this.pBoxD1.Click += new System.EventHandler(this.pBoxD1_Click);
            // 
            // pBoxD2
            // 
            this.pBoxD2.BackColor = System.Drawing.Color.Transparent;
            this.pBoxD2.Image = global::KTVClient.Properties.Resources.服务;
            this.pBoxD2.Location = new System.Drawing.Point(201, 302);
            this.pBoxD2.Name = "pBoxD2";
            this.pBoxD2.Size = new System.Drawing.Size(50, 50);
            this.pBoxD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxD2.TabIndex = 1;
            this.pBoxD2.TabStop = false;
            this.pBoxD2.Click += new System.EventHandler(this.pBoxD2_Click);
            // 
            // pBoxD3
            // 
            this.pBoxD3.BackColor = System.Drawing.Color.Transparent;
            this.pBoxD3.Image = global::KTVClient.Properties.Resources.已点;
            this.pBoxD3.Location = new System.Drawing.Point(291, 302);
            this.pBoxD3.Name = "pBoxD3";
            this.pBoxD3.Size = new System.Drawing.Size(50, 50);
            this.pBoxD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxD3.TabIndex = 1;
            this.pBoxD3.TabStop = false;
            this.pBoxD3.Click += new System.EventHandler(this.pBoxD3_Click);
            // 
            // pBoxD4
            // 
            this.pBoxD4.BackColor = System.Drawing.Color.Transparent;
            this.pBoxD4.Image = global::KTVClient.Properties.Resources.重播;
            this.pBoxD4.Location = new System.Drawing.Point(381, 302);
            this.pBoxD4.Name = "pBoxD4";
            this.pBoxD4.Size = new System.Drawing.Size(50, 50);
            this.pBoxD4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxD4.TabIndex = 1;
            this.pBoxD4.TabStop = false;
            this.pBoxD4.Click += new System.EventHandler(this.pBoxD4_Click);
            // 
            // pBoxD5
            // 
            this.pBoxD5.BackColor = System.Drawing.Color.Transparent;
            this.pBoxD5.Image = global::KTVClient.Properties.Resources.下一首;
            this.pBoxD5.Location = new System.Drawing.Point(471, 302);
            this.pBoxD5.Name = "pBoxD5";
            this.pBoxD5.Size = new System.Drawing.Size(50, 50);
            this.pBoxD5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxD5.TabIndex = 1;
            this.pBoxD5.TabStop = false;
            this.pBoxD5.Click += new System.EventHandler(this.pBoxD5_Click);
            // 
            // pBoxD6
            // 
            this.pBoxD6.BackColor = System.Drawing.Color.Transparent;
            this.pBoxD6.Image = global::KTVClient.Properties.Resources.退出1;
            this.pBoxD6.Location = new System.Drawing.Point(561, 302);
            this.pBoxD6.Name = "pBoxD6";
            this.pBoxD6.Size = new System.Drawing.Size(50, 50);
            this.pBoxD6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxD6.TabIndex = 1;
            this.pBoxD6.TabStop = false;
            this.pBoxD6.Click += new System.EventHandler(this.pBoxD6_Click);
            // 
            // lblD1
            // 
            this.lblD1.AutoSize = true;
            this.lblD1.BackColor = System.Drawing.Color.Transparent;
            this.lblD1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblD1.ForeColor = System.Drawing.Color.Yellow;
            this.lblD1.Location = new System.Drawing.Point(109, 355);
            this.lblD1.Name = "lblD1";
            this.lblD1.Size = new System.Drawing.Size(51, 19);
            this.lblD1.TabIndex = 2;
            this.lblD1.Text = "主页面";
            // 
            // lblD2
            // 
            this.lblD2.AutoSize = true;
            this.lblD2.BackColor = System.Drawing.Color.Transparent;
            this.lblD2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblD2.ForeColor = System.Drawing.Color.Yellow;
            this.lblD2.Location = new System.Drawing.Point(209, 355);
            this.lblD2.Name = "lblD2";
            this.lblD2.Size = new System.Drawing.Size(37, 19);
            this.lblD2.TabIndex = 2;
            this.lblD2.Text = "服务";
            // 
            // lblD3
            // 
            this.lblD3.AutoSize = true;
            this.lblD3.BackColor = System.Drawing.Color.Transparent;
            this.lblD3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblD3.ForeColor = System.Drawing.Color.Yellow;
            this.lblD3.Location = new System.Drawing.Point(296, 355);
            this.lblD3.Name = "lblD3";
            this.lblD3.Size = new System.Drawing.Size(37, 19);
            this.lblD3.TabIndex = 2;
            this.lblD3.Text = "已点";
            // 
            // lblD4
            // 
            this.lblD4.AutoSize = true;
            this.lblD4.BackColor = System.Drawing.Color.Transparent;
            this.lblD4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblD4.ForeColor = System.Drawing.Color.Yellow;
            this.lblD4.Location = new System.Drawing.Point(387, 355);
            this.lblD4.Name = "lblD4";
            this.lblD4.Size = new System.Drawing.Size(37, 19);
            this.lblD4.TabIndex = 2;
            this.lblD4.Text = "重播";
            // 
            // lblD5
            // 
            this.lblD5.AutoSize = true;
            this.lblD5.BackColor = System.Drawing.Color.Transparent;
            this.lblD5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblD5.ForeColor = System.Drawing.Color.Yellow;
            this.lblD5.Location = new System.Drawing.Point(473, 355);
            this.lblD5.Name = "lblD5";
            this.lblD5.Size = new System.Drawing.Size(51, 19);
            this.lblD5.TabIndex = 2;
            this.lblD5.Text = "下一首";
            // 
            // lblD6
            // 
            this.lblD6.AutoSize = true;
            this.lblD6.BackColor = System.Drawing.Color.Transparent;
            this.lblD6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblD6.ForeColor = System.Drawing.Color.Yellow;
            this.lblD6.Location = new System.Drawing.Point(567, 355);
            this.lblD6.Name = "lblD6";
            this.lblD6.Size = new System.Drawing.Size(37, 19);
            this.lblD6.TabIndex = 2;
            this.lblD6.Text = "返回";
            // 
            // lvsong
            // 
            this.lvsong.BackgroundImageTiled = true;
            this.lvsong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvsong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.songname,
            this.songstate});
            this.lvsong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvsong.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvsong.FullRowSelect = true;
            this.lvsong.Location = new System.Drawing.Point(56, 37);
            this.lvsong.MultiSelect = false;
            this.lvsong.Name = "lvsong";
            this.lvsong.Size = new System.Drawing.Size(630, 248);
            this.lvsong.TabIndex = 4;
            this.lvsong.UseCompatibleStateImageBehavior = false;
            this.lvsong.View = System.Windows.Forms.View.Details;
            this.lvsong.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.lvsong.Click += new System.EventHandler(this.listView1_Click);
            // 
            // songname
            // 
            this.songname.Text = "歌曲名称";
            this.songname.Width = 315;
            // 
            // songstate
            // 
            this.songstate.Text = "歌曲状态";
            this.songstate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.songstate.Width = 315;
            // 
            // FrmOrderedSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KTVClient.Properties.Resources.背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 397);
            this.Controls.Add(this.lvsong);
            this.Controls.Add(this.lblD6);
            this.Controls.Add(this.lblD5);
            this.Controls.Add(this.lblD4);
            this.Controls.Add(this.lblD3);
            this.Controls.Add(this.lblD2);
            this.Controls.Add(this.lblD1);
            this.Controls.Add(this.pBoxD6);
            this.Controls.Add(this.pBoxD5);
            this.Controls.Add(this.pBoxD4);
            this.Controls.Add(this.pBoxD3);
            this.Controls.Add(this.pBoxD2);
            this.Controls.Add(this.pBoxD1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrderedSongList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrderedSongList";
            this.Load += new System.EventHandler(this.FrmOrderedSongList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxD1;
        private System.Windows.Forms.PictureBox pBoxD2;
        private System.Windows.Forms.PictureBox pBoxD3;
        private System.Windows.Forms.PictureBox pBoxD4;
        private System.Windows.Forms.PictureBox pBoxD5;
        private System.Windows.Forms.PictureBox pBoxD6;
        private System.Windows.Forms.Label lblD1;
        private System.Windows.Forms.Label lblD2;
        private System.Windows.Forms.Label lblD3;
        private System.Windows.Forms.Label lblD4;
        private System.Windows.Forms.Label lblD5;
        private System.Windows.Forms.Label lblD6;
        private System.Windows.Forms.ListView lvsong;
        private System.Windows.Forms.ColumnHeader songname;
        private System.Windows.Forms.ColumnHeader songstate;

    }
}