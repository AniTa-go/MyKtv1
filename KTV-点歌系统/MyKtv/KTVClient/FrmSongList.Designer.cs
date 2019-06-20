namespace KTVClient
{
    partial class FrmSongList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSong = new System.Windows.Forms.DataGridView();
            this.singer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxD6)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSong
            // 
            this.dgvSong.AllowUserToResizeColumns = false;
            this.dgvSong.AllowUserToResizeRows = false;
            this.dgvSong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSong.BackgroundColor = System.Drawing.Color.White;
            this.dgvSong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.singer_name,
            this.song_name});
            this.dgvSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSong.GridColor = System.Drawing.SystemColors.Info;
            this.dgvSong.Location = new System.Drawing.Point(0, 31);
            this.dgvSong.MultiSelect = false;
            this.dgvSong.Name = "dgvSong";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSong.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSong.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("方正兰亭超细黑简体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSong.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSong.RowTemplate.Height = 23;
            this.dgvSong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSong.Size = new System.Drawing.Size(717, 245);
            this.dgvSong.TabIndex = 0;
            this.dgvSong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSong_CellContentClick);
            this.dgvSong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSong_CellContentClick_1);
            // 
            // singer_name
            // 
            this.singer_name.DataPropertyName = "singer_name";
            this.singer_name.HeaderText = "歌手名称";
            this.singer_name.Name = "singer_name";
            this.singer_name.ReadOnly = true;
            // 
            // song_name
            // 
            this.song_name.DataPropertyName = "song_name";
            this.song_name.HeaderText = "歌曲名字";
            this.song_name.Name = "song_name";
            this.song_name.ReadOnly = true;
            // 
            // pBoxD1
            // 
            this.pBoxD1.BackColor = System.Drawing.Color.Transparent;
            this.pBoxD1.Image = global::KTVClient.Properties.Resources.主页面;
            this.pBoxD1.Location = new System.Drawing.Point(157, 309);
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
            this.pBoxD2.Location = new System.Drawing.Point(237, 309);
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
            this.pBoxD3.Location = new System.Drawing.Point(317, 309);
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
            this.pBoxD4.Location = new System.Drawing.Point(397, 309);
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
            this.pBoxD5.Location = new System.Drawing.Point(477, 309);
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
            this.pBoxD6.Location = new System.Drawing.Point(557, 309);
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
            this.lblD1.Location = new System.Drawing.Point(155, 362);
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
            this.lblD2.Location = new System.Drawing.Point(246, 362);
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
            this.lblD3.Location = new System.Drawing.Point(322, 362);
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
            this.lblD4.Location = new System.Drawing.Point(403, 362);
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
            this.lblD5.Location = new System.Drawing.Point(476, 362);
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
            this.lblD6.Location = new System.Drawing.Point(562, 362);
            this.lblD6.Name = "lblD6";
            this.lblD6.Size = new System.Drawing.Size(37, 19);
            this.lblD6.TabIndex = 2;
            this.lblD6.Text = "返回";
            // 
            // FrmSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KTVClient.Properties.Resources.背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 397);
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
            this.Controls.Add(this.dgvSong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSongList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSongList";
            this.Load += new System.EventHandler(this.FrmSongList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).EndInit();
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

        private System.Windows.Forms.DataGridView dgvSong;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_name;
    }
}