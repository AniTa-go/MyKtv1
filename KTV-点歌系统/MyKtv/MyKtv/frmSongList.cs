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

namespace MyKtv
{
    public partial class frmSongList : Form
    {
        //创建临时空间
        DataSet ds;
        SqlDataAdapter adapter;
        //实例化DBhelper
        DBHelper dbhelper = new DBHelper();

        public string songName;
        public string songType;
        public string songCount;

        //进行传值的变量
        public string sNamePY;
        public string sType;
        public string sId;
        public string sLj;
        public string ssName;
        public string sIds;
        
        public frmSongList()
        {
            InitializeComponent();
        }


        //歌曲加载事件
        private void frmSongList_Load(object sender, EventArgs e)
        {
            this.dgvInfo.AutoGenerateColumns = false;
            AddSongType();
            SearchSong();
        }



        //歌曲类型事件
        private void cboSongType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //歌曲类型方法
        public void AddSongType()
        {
            try
            {
                string sql = "select * from song_type";
                ds = new DataSet();
                adapter = new SqlDataAdapter(sql, dbhelper.Conn);
                //填充数据集
                adapter.Fill(ds, "song_type");

                DataRow dr = ds.Tables["song_type"].NewRow();
                dr[0] = -1;
                dr[1] = "全部歌曲";
                ds.Tables["song_type"].Rows.InsertAt(dr, 0);

                this.cboSongType.DataSource = ds.Tables["song_type"];
                this.cboSongType.ValueMember = "songtype_id";
                this.cboSongType.DisplayMember = "songtype_name";
            }
            catch (Exception)
            {
                MessageBox.Show("窗体加载异常");
            }
        }



        //歌曲查询方法
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchSongByType();
        }

        //查询全部歌曲
        public void SearchSong()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select i.song_name,t.songtype_name,i.song_play_count,i.song_ab");
            sb.AppendLine("from song_info as i inner join  song_type as t on i.songtype_id = t.songtype_id");
            //sb.AppendFormat("where i.song_name like '%{0}%' AND i.songtype_id= '{1}'", this.txtSongName.Text.Trim(), this.cboSongType.SelectedValue.ToString());

            try
            {
                ds = new DataSet();
                adapter = new SqlDataAdapter(sb.ToString(), dbhelper.Conn);
                if (ds.Tables["caa"] != null)
                {
                    ds.Tables["caa"].Clear();
                }
                adapter.Fill(ds, "caa");
                dgvInfo.DataSource = ds.Tables["caa"];
            }
            catch (Exception)
            {
                MessageBox.Show("查询异常!");
            }
        }

        //通过条件查询全部歌曲
        public void SearchSongByType()
        {
            try
            {
                DataView dv = new DataView(ds.Tables["caa"]);
                string str = string.Format("(song_name like '%{0}%' or song_ab like '%{0}%') AND songtype_name = '{1}'", this.txtSongName.Text.Trim().ToString(), this.cboSongType.Text.ToString());

                if (this.cboSongType.SelectedValue.Equals(-1))
                {
                    str = string.Format("song_name like '%{0}%' or song_ab like '%{0}%' ", this.txtSongName.Text.Trim().ToString());
                }

                dv.RowFilter = str;
                this.dgvInfo.DataSource = dv;
            }
            catch (Exception)
            {
                MessageBox.Show("查询异常");
            }
        }

        private void txtSongName_TextChanged(object sender, EventArgs e)
        {

        }

        //给变量传值
        //将控件内容进行传值
        public void AddblByKj()
        {
            songName = this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString();
            songType = this.dgvInfo.SelectedRows[0].Cells[1].Value.ToString();
            songCount = this.dgvInfo.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认要删除名为" + this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString() + "的歌曲吗?", "删除提示!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dgvInfo.SelectedRows.Count > 0)
            {
                if (result == DialogResult.Yes)
                {
                    AddblByKj();
                    SongDelete();
                }
            }
            else
            {
                MessageBox.Show("请选择一名歌曲在进行操作");
            }
        }

        //查询歌曲Id
        public int SearchSongID()
        {
            string str = string.Format(@"select song_id
                                        from song_info AS S 
                                        inner join song_type AS T ON S.songtype_id = T.songtype_id
                                        WHERE S.song_name = '{0}' AND T.songtype_name = '{1}' AND S.song_play_count = '{2}'",songName,songType,songCount);
            try
            {
                SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
                dbhelper.OpenConn();
                return (int)comm.ExecuteScalar();
            }
            catch (Exception)
            {
                MessageBox.Show("请重新选择一名歌曲");
                return -1;
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }

        //删除歌曲
        public void SongDelete()
        {
            int id = SearchSongID();
            if (id == -1)
            {
                return;
            }
            try
            {
                string str = string.Format("delete from song_info where song_id = '{0}'", id);
                SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
                dbhelper.OpenConn();
                int i = comm.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("删除成功!");
                    SearchSong();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("删除发生异常!");
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            frmEditSong frmeditsong = new frmEditSong();
            if (BlCheckByKj() == false)
            {
                return;
            }
            frmeditsong.iR = false;
            frmeditsong.songName = this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString();
            frmeditsong.songLj = sLj;
            frmeditsong.songNamePY = sNamePY;
            frmeditsong.songWord = this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString().Length.ToString();
            frmeditsong.songType = sType;
            frmeditsong.SingerName = ssName;
            frmeditsong.songId = sIds;
            frmeditsong.mp3Lj = sLj;
            frmeditsong.songLJxs = sLj;
            frmeditsong.singerId = Convert.ToInt32(sId);
            frmeditsong.ShowDialog();
            SearchSong();
        }
        
        //查询歌曲的当前信息
        public bool BlCheckByKj()
        {
            try
            {
                string stra = string.Format(@"select s.song_ab
                                           from song_info as s
                                           inner join song_type as t on t.songtype_id = s.songtype_id
                                           where s.song_name = '{0}' and t.songtype_name = '{1}' and s.song_play_count = '{2}'", this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[1].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[2].Value.ToString());
                string strb = string.Format(@"select s.songtype_id
                                           from song_info as s
                                           inner join song_type as t on t.songtype_id = s.songtype_id
                                           where s.song_name = '{0}' and t.songtype_name = '{1}' and s.song_play_count = '{2}'", this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[1].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[2].Value.ToString());
                string strc = string.Format(@"select s.song_url
                                           from song_info as s
                                           inner join song_type as t on t.songtype_id = s.songtype_id
                                           where s.song_name = '{0}' and t.songtype_name = '{1}' and s.song_play_count = '{2}'", this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[1].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[2].Value.ToString());
                string strd = string.Format(@"select s.singer_id
                                           from song_info as s
                                           inner join song_type as t on t.songtype_id = s.songtype_id
                                           where s.song_name = '{0}' and t.songtype_name = '{1}' and s.song_play_count = '{2}'", this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[1].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[2].Value.ToString());
                string stre = string.Format(@"select l.singer_name
                                           from song_info as s
                                           inner join song_type as t on t.songtype_id = s.songtype_id
                                           inner join singer_info as l on l.singer_id = s.singer_id
                                           where s.song_name = '{0}' and t.songtype_name = '{1}' and s.song_play_count = '{2}'", this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[1].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[2].Value.ToString());
                string strf = string.Format(@"select s.song_id
                                           from song_info as s
                                           inner join song_type as t on t.songtype_id = s.songtype_id
                                           where s.song_name = '{0}' and t.songtype_name = '{1}' and s.song_play_count = '{2}'", this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[1].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[2].Value.ToString());
                dbhelper.OpenConn();
                SqlCommand com = new SqlCommand(stra,dbhelper.Conn);
                sNamePY = Convert.ToString(com.ExecuteScalar());
                com.CommandText = strb;
                sType = Convert.ToString(com.ExecuteScalar());
                com.CommandText = strc;
                sLj = Convert.ToString(com.ExecuteScalar());
                com.CommandText = strd;
                sId = Convert.ToString(com.ExecuteScalar());
                com.CommandText = stre;
                ssName = Convert.ToString(com.ExecuteScalar());
                com.CommandText = strf;
                sIds = Convert.ToString(com.ExecuteScalar());
               
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show("修改窗体加载异常!");
                return false;
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }
    }
}
