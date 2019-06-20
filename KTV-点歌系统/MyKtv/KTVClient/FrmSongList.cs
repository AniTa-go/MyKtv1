using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTVClient
{
    public partial class FrmSongList : Form
    {
        //实例化各个类
        DBHelper dbhelper = new DBHelper();
        KTVUtil ktvutil = new KTVUtil();
        //创建临时空间
        DataSet ds;
        SqlDataAdapter adapter;

        //通过各个窗体的查询条件
        public int view = -1;
        //通过歌手查找的条件
        public string sing_id;
        //通过歌曲类型查找的条件
        public int song_type_id;
        //通过字数查找的条件
        public int song_word_count;

        //查询到的歌曲ID以及路径
        public string song_url;
        public string song_id;

        //判断父窗体
        public int views;
        public FrmSongList()
        {
            InitializeComponent();
        }

        private void FrmSongList_Load(object sender, EventArgs e)
        {
            this.dgvSong.AutoGenerateColumns = false;
            AddSong();
        }

        //添加歌曲到列表
        public void AddSong()
        {
            try
            {
                //判断查询条件
                string str = string.Empty;
                if (view == 1)
                {
                    str = string.Format("select s.song_name,i.singer_name,s.song_play_count from song_info as s inner join singer_info as i on i.singer_id = s.singer_id where i.singer_id = '{0}'", sing_id);
                }
                else if (view == 2)
                {
                    str = string.Format("select s.song_name,i.singer_name,s.song_play_count from song_info as s inner join singer_info as i on i.singer_id = s.singer_id where s.songtype_id = '{0}'", song_type_id);
                }else if(view ==3 ){
                    str = string.Format("select s.song_name,i.singer_name,s.song_play_count from song_info as s inner join singer_info as i on i.singer_id = s.singer_id where s.song_word_count = {0}", song_word_count);
                    if(song_word_count > 5){
                        str = string.Format("select s.song_name,i.singer_name,s.song_play_count from song_info as s inner join singer_info as i on i.singer_id = s.singer_id where s.song_word_count > {0}", song_word_count);
                    }
                }else if(view == 4){
                    str = string.Format("select s.song_name,i.singer_name,s.song_play_count from song_info as s inner join singer_info as i on i.singer_id = s.singer_id where s.song_play_count > 0 order by song_play_count desc");
                }

                adapter = new SqlDataAdapter(str,dbhelper.Conn);
                ds = new DataSet();
                if(ds.Tables["Song"] != null){
                    ds.Tables["Song"].Clear();
                }
                adapter.Fill(ds,"Song");
                dgvSong.DataSource = ds.Tables["Song"];
            }
            catch (Exception)
            {

            }
        }

        private void pBoxD6_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }


        private void pBoxD1_Click(object sender, EventArgs e)
        {
            if(views == 1){
                this.Owner.Show();
            }else if(views == 2){

                this.Owner.Owner.Show();
            }
            this.Close();
        }


        private void dgvSong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvSong.SelectedRows[0].Cells[0].Value != null)
            {
                SelectSongURL();
                if (song_id != null)
                {
                    Song song = new Song();
                    song.SongURL = song_url;
                    song.SongName = dgvSong.SelectedRows[0].Cells[1].Value.ToString();
                    PlayList playlist = new PlayList();                
                    playlist.AddSong(song);
                    AddSongCount();
                    if(view == 4){
                        ((FrmMain)this.Owner).PlayMP3();
                    }
                    else
                    {
                        ((FrmMain)this.Owner.Owner).PlayMP3();
                    }

                }
            }
        }

        //点击控件查询歌曲存放路径
        public void SelectSongURL()
        {
            string str = string.Format(@"select s.song_url
                                        from song_info as s
                                        inner join singer_info as u on u.singer_id = s.singer_id
                                        where s.song_name = '{0}' AND u.singer_name = '{1}'", this.dgvSong.SelectedRows[0].Cells[1].Value.ToString(), this.dgvSong.SelectedRows[0].Cells[0].Value.ToString());
            string id = string.Format(@"select s.song_id
                                        from song_info as s
                                        inner join singer_info as u on u.singer_id = s.singer_id
                                        where s.song_name = '{0}' AND u.singer_name = '{1}'", this.dgvSong.SelectedRows[0].Cells[1].Value.ToString(), this.dgvSong.SelectedRows[0].Cells[0].Value.ToString()); 
            try
            {
                SqlCommand comm = new SqlCommand(str,dbhelper.Conn);
                dbhelper.OpenConn();
                song_url =  Convert.ToString(comm.ExecuteScalar());
                comm.CommandText = id;
                song_id = Convert.ToString(comm.ExecuteScalar());
            }
            catch (Exception)
            {
                MessageBox.Show("出现异常请联系管理员!");

            }
            finally
            {
                dbhelper.CloseConn();
            }
        }

        //给选中歌曲增加点播次数
        public void AddSongCount()
        {
            string str = string.Format("update song_info set song_play_count = song_play_count+1 where song_id = '{0}'",song_id);
            try
            {
                SqlCommand comm = new SqlCommand(str,dbhelper.Conn);
                dbhelper.OpenConn();
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }

        private void dgvSong_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pBoxD3_Click(object sender, EventArgs e)
        {
            FrmOrderedSongList frmorderedsonglist = new FrmOrderedSongList();
            frmorderedsonglist.Owner = this;
            if(views == 2){
                frmorderedsonglist.view = 3;
            }
            else if (views == 1)
            {
                frmorderedsonglist.view = 2;
            }
            frmorderedsonglist.Show();
            this.Hide();
        }

        private void pBoxD4_Click(object sender, EventArgs e)
        {
            if (views == 1)
            {
                ((FrmMain)this.Owner).RaginSong();
            }
            else if (views == 2)
            {
                ((FrmMain)this.Owner.Owner).RaginSong();
            }
        }

        private void pBoxD5_Click(object sender, EventArgs e)
        {
            if (views == 1)
            {
                ((FrmMain)this.Owner).NestSonger();
            }
            else if (views == 2)
            {
                ((FrmMain)this.Owner.Owner).NestSonger();
            }
        }

        private void pBoxD2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你呼叫了麦KTV服务,服务员正在前往此包间");
        }
    }
}
