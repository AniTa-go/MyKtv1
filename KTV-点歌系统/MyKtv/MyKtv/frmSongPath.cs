using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace MyKtv
{
    public partial class frmSongPath : Form
    {
        KTVUtil ut = new KTVUtil();
        DBHelper dbhelper = new DBHelper();
        public frmSongPath()
        {
            InitializeComponent();
        }

        private void frmSongPath_Load(object sender, EventArgs e)
        {
            this.txtLja.Text = ut.SongPath;
        }

        private void btnLj_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            //open.Title = "选择一个文件夹";
            //open.Multiselect = false;
            //open.Filter = "文件夹(*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.txtLjb.Text = open.SelectedPath;
            }
        }

        //改变路径
        public void SingerPhoto()
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(this.txtLja.Text.ToString());
                FileInfo[] files = directoryInfo.GetFiles();

                foreach (FileInfo file in files) // Directory.GetFiles(srcFolder)
                {
                    File.Copy(this.txtLja.Text.ToString() + @"\" + file.Name, this.txtLjb.Text.ToString() + @"\" + file.Name, true);
                }
                try
                {
                    string str = string.Format("update resource_path set resource_path = '{0}' where resource_type ='歌曲途径'", this.txtLjb.Text.ToString());
                    SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
                    dbhelper.OpenConn();
                    int i = comm.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("新的歌曲路径已经设置");
                        this.txtLja.Text = ut.SongPath;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("改变歌手图片路径发生异常");
                }
                finally
                {
                    dbhelper.CloseConn();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("改变歌手图片路径发生异常");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtLjb.Text.Trim().Equals(string.Empty) || this.txtLjb.Text.Trim().ToString().Equals(this.txtLja.Text.Trim().ToString()))
            {
                MessageBox.Show("请选择一个新路径");
                return;
            }
            SingerPhoto();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
