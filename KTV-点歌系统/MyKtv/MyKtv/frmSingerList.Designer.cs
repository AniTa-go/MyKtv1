namespace MyKtv
{
    partial class frmSingerList
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
            this.components = new System.ComponentModel.Container();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSingerName = new System.Windows.Forms.Label();
            this.txtSingerName = new System.Windows.Forms.TextBox();
            this.lblSingerType = new System.Windows.Forms.Label();
            this.cboSingerType = new System.Windows.Forms.ComboBox();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.singer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singertype_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singer_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singer_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnqd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.cmsRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(389, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSingerName
            // 
            this.lblSingerName.AutoSize = true;
            this.lblSingerName.Location = new System.Drawing.Point(29, 21);
            this.lblSingerName.Name = "lblSingerName";
            this.lblSingerName.Size = new System.Drawing.Size(53, 12);
            this.lblSingerName.TabIndex = 1;
            this.lblSingerName.Text = "歌手姓名";
            // 
            // txtSingerName
            // 
            this.txtSingerName.Location = new System.Drawing.Point(88, 18);
            this.txtSingerName.Name = "txtSingerName";
            this.txtSingerName.Size = new System.Drawing.Size(100, 21);
            this.txtSingerName.TabIndex = 2;
            // 
            // lblSingerType
            // 
            this.lblSingerType.AutoSize = true;
            this.lblSingerType.Location = new System.Drawing.Point(195, 21);
            this.lblSingerType.Name = "lblSingerType";
            this.lblSingerType.Size = new System.Drawing.Size(53, 12);
            this.lblSingerType.TabIndex = 3;
            this.lblSingerType.Text = "歌手类型";
            // 
            // cboSingerType
            // 
            this.cboSingerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSingerType.FormattingEnabled = true;
            this.cboSingerType.Location = new System.Drawing.Point(254, 18);
            this.cboSingerType.Name = "cboSingerType";
            this.cboSingerType.Size = new System.Drawing.Size(121, 20);
            this.cboSingerType.TabIndex = 4;
            // 
            // dgvInfo
            // 
            this.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.singer_name,
            this.singertype_name,
            this.singer_sex,
            this.singer_info});
            this.dgvInfo.ContextMenuStrip = this.cmsRight;
            this.dgvInfo.Location = new System.Drawing.Point(13, 59);
            this.dgvInfo.MultiSelect = false;
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(451, 247);
            this.dgvInfo.TabIndex = 5;
            this.dgvInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellContentClick);
            // 
            // singer_name
            // 
            this.singer_name.DataPropertyName = "singer_name";
            this.singer_name.HeaderText = "歌手姓名";
            this.singer_name.Name = "singer_name";
            this.singer_name.ReadOnly = true;
            // 
            // singertype_name
            // 
            this.singertype_name.DataPropertyName = "singertype_name";
            this.singertype_name.HeaderText = "歌手类别";
            this.singertype_name.Name = "singertype_name";
            this.singertype_name.ReadOnly = true;
            // 
            // singer_sex
            // 
            this.singer_sex.DataPropertyName = "singer_sex";
            this.singer_sex.HeaderText = "歌手性别";
            this.singer_sex.Name = "singer_sex";
            this.singer_sex.ReadOnly = true;
            // 
            // singer_info
            // 
            this.singer_info.DataPropertyName = "singer_info";
            this.singer_info.HeaderText = "歌手描述";
            this.singer_info.Name = "singer_info";
            this.singer_info.ReadOnly = true;
            // 
            // cmsRight
            // 
            this.cmsRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.tsmiUpdate});
            this.cmsRight.Name = "cmsRight";
            this.cmsRight.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(100, 22);
            this.tsmiUpdate.Text = "修改";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // btnqd
            // 
            this.btnqd.Enabled = false;
            this.btnqd.Location = new System.Drawing.Point(389, 312);
            this.btnqd.Name = "btnqd";
            this.btnqd.Size = new System.Drawing.Size(75, 23);
            this.btnqd.TabIndex = 6;
            this.btnqd.Text = "确定";
            this.btnqd.UseVisualStyleBackColor = true;
            this.btnqd.Click += new System.EventHandler(this.btnqd_Click);
            // 
            // frmSingerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 341);
            this.Controls.Add(this.btnqd);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.cboSingerType);
            this.Controls.Add(this.lblSingerType);
            this.Controls.Add(this.txtSingerName);
            this.Controls.Add(this.lblSingerName);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmSingerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌手查询";
            this.Load += new System.EventHandler(this.frmSingerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.cmsRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSingerName;
        private System.Windows.Forms.TextBox txtSingerName;
        private System.Windows.Forms.Label lblSingerType;
        private System.Windows.Forms.ComboBox cboSingerType;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.ContextMenuStrip cmsRight;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn singertype_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_info;
        public System.Windows.Forms.Button btnqd;
    }
}