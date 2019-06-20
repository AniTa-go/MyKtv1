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
    public partial class FrmOrderBySongName : Form
    {
        //实例化各个类
        DBHelper dbhelper = new DBHelper();
        KTVUtil ktvutil = new KTVUtil();
        //创建临时空间
        DataSet ds;
        SqlDataAdapter adapter;
        //查询歌曲id和url
        public string song_url;
        public string song_id;
        public FrmOrderBySongName()
        {
            InitializeComponent();
        }

        private void FrmOrderBySongType_Load(object sender, EventArgs e)
        {
            this.txtSongName.Height = 50;
            this.dgvSong.AutoGenerateColumns = false;
           
        }

        //查询歌曲
        public void AddSongByK()
        {
            string str = string.Format("select s.song_name,i.singer_name from song_info as s inner join singer_info as i on i.singer_id = s.singer_id  where song_name like '%{0}%' OR song_ab like '%{0}%'", this.txtSongName.Text.Trim().ToString());
            try
            {
                ds = new DataSet();
                adapter = new SqlDataAdapter(str, dbhelper.Conn);
                if(ds.Tables["Song"] != null){
                    ds.Tables["Song"].Clear();
                }
                adapter.Fill(ds, "Song");
                this.dgvSong.DataSource = ds.Tables["Song"];
            }
            catch (Exception)
            {

            }
        }

        private void pBoxSearch_Click(object sender, EventArgs e)
        {
            AddSongByK();
        }

        private void pBoxD6_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void pBoxD1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void dgvSong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
                dbhelper.OpenConn();
                song_url = Convert.ToString(comm.ExecuteScalar());
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
            string str = string.Format("update song_info set song_play_count = song_play_count+1 where song_id = '{0}'", song_id);
            try
            {
                SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
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

        private void dgvSong_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    ((FrmMain)this.Owner).PlayMP3();
                }
            }
        }

        private void pBoxD3_Click(object sender, EventArgs e)
        {
            FrmOrderedSongList frmorderedsonglist = new FrmOrderedSongList();
            frmorderedsonglist.Owner = this;
            frmorderedsonglist.view = 2;
            frmorderedsonglist.Show();
            this.Hide();
        }

        private void pBoxD4_Click(object sender, EventArgs e)
        {
            ((FrmMain)this.Owner).RaginSong();
        }

        private void pBoxD5_Click(object sender, EventArgs e)
        {
            ((FrmMain)this.Owner).NestSonger();
        }

        private void pBoxD2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你呼叫了麦KTV服务,服务员正在前往此包间");
        }
    }
}
