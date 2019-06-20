using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MyKtv
{
    public partial class frmEditSong : Form
    {
        //创建临时空间
        DataSet ds;
        SqlDataAdapter adapter;
        //实例化DBhelper
        DBHelper dbhelper = new DBHelper();
        //实例化路径类
        KTVUtil ktvutil = new KTVUtil();

        //创建修改判断
        public bool iR = true;

        //定义存储信息的变量
        public string songName;
        public string songNamePY;
        public string songLj;
        public string songType;
        public string songWord;
        public string songCount;
        public string songId;

        //歌曲路径
        public string songLJxs;
        //文件复制的变量
        public string mp3Lj;
        public string mp3Name;

        //歌手名字
        private string singerName;

        //歌手Id
        public int singerId;

        public string SingerName
        {
            get { return singerName; }
            set { singerName = value; }
        }

        public frmEditSong()
        {
            InitializeComponent();
        }

        private void frmEditSong_Load(object sender, EventArgs e)
        {
            AddSingerType();
            this.cboSongType.SelectedIndex = -1;
            AddblByUpdate();
        }

        //给下拉框填值
        public void AddSingerType()
        {
            try
            {
                string sql = "select * from song_type";
                ds = new DataSet();
                adapter = new SqlDataAdapter(sql, dbhelper.Conn);
                //填充数据集
                adapter.Fill(ds, "song_type");
                this.cboSongType.DataSource = ds.Tables["song_type"];
                this.cboSongType.ValueMember = "songtype_id";
                this.cboSongType.DisplayMember = "songtype_name";
            }
            catch (Exception)
            {
                MessageBox.Show("窗体加载异常");
            }
        }

        private void btnSongLj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"E:\\KTV-点歌系统\\素材\\资源\\song";
            openFileDialog.Filter = "歌曲文件(*.*)|*.MP3;*.MP4;*.qlv";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mp3Name = openFileDialog.SafeFileName;
                mp3Lj = ktvutil.SongPath + @"\" + mp3Name;
                songLj = openFileDialog.FileName;
                songLJxs = openFileDialog.SafeFileName;
                this.txtSongLj.Text = songLJxs;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSingerList singlist = new frmSingerList();
            singlist.Owner = this;
            singlist.btnqd.Enabled = true;
            singlist.ShowDialog();
            this.txtSongSinger.Text = SingerName;
        }

        //非空验证
        public bool CheckInfo()
        {
            if (this.txtSongName.Text.Trim().Equals(string.Empty) || this.txtSongNames.Text.Trim().Equals(string.Empty) || this.txtSongSinger.Text.Trim().Equals(string.Empty) || this.txtSongLj.Text.Trim().Equals(string.Empty) || this.cboSongType.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("请填写完整的信歌曲息!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSongAdd_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                BlAddByKj();
                if(iR == true){
                   AddSong();
                }
                else
                {
                    UpdateSong();
                }
            }
        }

        //给各个变量赋值
        public void BlAddByKj()
        {
            songName = this.txtSongName.Text.Trim().ToString();
            songNamePY = this.txtSongNames.Text.Trim().ToString();
            songType = this.cboSongType.SelectedValue.ToString();
            //songLj = this.txtSongLj.Text.Trim().ToString();
            songWord = songName.Trim().Length.ToString();
        }

        //添加歌曲
        public void AddSong()
        {
            string str = string.Format("insert into song_info values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", songName, songNamePY, songWord, songType, singerId, songLJxs, songCount);
            try
            {
                SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
                dbhelper.OpenConn();
                if (Mp3Lj())
                {
                    int i = comm.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("添加成功");
                    }
                    else
                    {
                        MessageBox.Show("添加失败!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("添加异常!");
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }

        //路径的复制
        public bool Mp3Lj()
        {
            try
            {
                if(songLj.Equals(mp3Lj)){
                    return true;
                }
                File.Copy(songLj, mp3Lj, true);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("歌曲选择异常!");
                return false;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //修改传值判断
        public void AddblByUpdate()
        {
            if (iR == false)
            {
                this.txtSongName.Text = songName;
                this.txtSongNames.Text = songNamePY;
                this.txtSongLj.Text = songLj;
                this.txtSongSinger.Text = singerName;
                this.cboSongType.SelectedValue = songType;
            }
        }

        //修改歌曲信息
        public void UpdateSong()
        {
            string str = string.Format("update song_info set song_name = '{0}',song_ab = '{1}',song_word_count='{2}',songtype_id='{3}',singer_id='{4}',song_url='{5}' WHERE song_id = '{6}'", songName, songNamePY, songWord, songType, singerId, songLJxs, songId);
            try
            {
                SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
                dbhelper.OpenConn();
                if (Mp3Lj())
                {
                    int i = comm.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("修改成功");
                    }
                    else
                    {
                        MessageBox.Show("修改失败!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("修改异常!");
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }
    }
}
