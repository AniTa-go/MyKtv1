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
    public partial class frmSingerList : Form
    {
        //创建临时空间
        DataSet ds;
        SqlDataAdapter adapter;
        //实例化DBhelper
        DBHelper dbhelper = new DBHelper();

        //创建存储的变量
        public string singerId;
        public string singerName;
        public string singerType;
        public string singerSex;

        //修改时传值
        public string singId;
        public string singUrl;
        public string singtypevalue;

        public frmSingerList()
        {
            InitializeComponent();
        }

        private void frmSingerList_Load(object sender, EventArgs e)
        {
            this.dgvInfo.AutoGenerateColumns = false;
            AddSingerType();
            SearchSinger();
        }

        //查询全部歌手
        public void SearchSinger()
        {
            StringBuilder SB = new StringBuilder();
            SB.AppendLine("select *");
            SB.AppendLine("from singer_info as i inner join singer_type as t on i.singertype_id = t.singertype_id");
            // SB.AppendFormat("  where singer_name  like '%{0}%' AND i.singertype_id = '{1}'", this.txtSingerName.Text.Trim(), this.cboSingerType.SelectedValue.ToString());
            try
            {
                ds = new DataSet();
                adapter = new SqlDataAdapter(SB.ToString(), dbhelper.Conn);
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

        //通过条件查询全部歌手
        public void SearchSingerByType()
        {
            try
            {
                DataView dv = new DataView(ds.Tables["caa"]);
                string str = string.Format("singer_name  like '%{0}%' AND singertype_id = '{1}'",this.txtSingerName.Text.Trim(), this.cboSingerType.SelectedValue.ToString());

                if(this.cboSingerType.SelectedValue.Equals(-1)){
                    str = string.Format("singer_name  like '%{0}%'",this.txtSingerName.Text.Trim());
                }

                dv.RowFilter = str;
                this.dgvInfo.DataSource = dv;
            }
            catch (Exception)
            {
                MessageBox.Show("查询异常");
            }
        }

        //下拉方法
        public void AddSingerType()
        {
            try
            {
                string sql = "select * from singer_type";
                ds = new DataSet();
                adapter = new SqlDataAdapter(sql, dbhelper.Conn);
                //填充数据集
                adapter.Fill(ds, "singer_type");

                DataRow dr = ds.Tables["singer_type"].NewRow();
                dr[0] = -1;
                dr[1] = "全部歌手";
                ds.Tables["singer_type"].Rows.InsertAt(dr,0);

                this.cboSingerType.DataSource = ds.Tables["singer_type"];
                this.cboSingerType.ValueMember = "singertype_id";
                this.cboSingerType.DisplayMember = "singertype_name";
            }
            catch (Exception)
            {
                MessageBox.Show("窗体加载异常");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchSingerByType();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认要删除名为" + this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString() + "的歌手吗?","删除提示!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dgvInfo.SelectedRows.Count >0){
                if (result == DialogResult.Yes)
                {
                    AddblByKj();
                    SingerDelete();
                }
            }
            else
            {
                MessageBox.Show("请选择一名歌手在进行操作");
            }
        }

        //删除歌手信息
        public void SingerDelete()
        {
              int id = SearchSingerID();
              if(id == -1){
                  return;
              }
            try
            {
                string str = string.Format("delete from song_info where singer_id = '{0}';delete from singer_info where singer_id = '{0}'", id);
                SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
                dbhelper.OpenConn();
                int i = comm.ExecuteNonQuery();
                if(i>0){
                    MessageBox.Show("删除成功!");
                    SearchSinger();
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

        //查询歌手Id
        public int SearchSingerID()
        {
            
            string str = string.Format(@"SELECT singer_id 
                                        FROM singer_info AS S
                                        INNER JOIN singer_type AS T ON T.singertype_id = S.singertype_id
                                        WHERE S.singer_name = '{0}' AND T.singertype_name = '{1}' AND S.singer_sex = '{2}'",singerName,singerType,singerSex);
            try
            {
                SqlCommand comm = new SqlCommand(str,dbhelper.Conn);
                dbhelper.OpenConn();
                return (int)comm.ExecuteScalar();
            }
            catch (Exception)
            {
                MessageBox.Show("请重新选择一名歌手");
                return -1;
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }

        //将控件内容进行传值
        public void AddblByKj()
        {           
            singerName = this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString();
            singerType = this.dgvInfo.SelectedRows[0].Cells[1].Value.ToString();
            singerSex = this.dgvInfo.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnqd_Click(object sender, EventArgs e)
        {
            //this.Owner = new frmEditSong();
            if (SearchSingerIdByAll() == -1)
            {
                MessageBox.Show("歌手信息异常!");
                return;
            }
            ((frmEditSong)this.Owner).singerId = SearchSingerIdByAll();
            ((frmEditSong)this.Owner).SingerName = this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString();
            this.Close();
        }

        private void dgvInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //查询歌手Id
        public int SearchSingerIdByAll()
        {
            string str = string.Format(@"select singer_id
                                        from singer_info as s
                                        inner join singer_type as t on t.singertype_id = s.singertype_id
                                        where s.singer_name = '{0}' and t.singertype_name = '{1}' and s.singer_sex = '{2}'", this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[1].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[2].Value.ToString());

            try
            {
                SqlCommand comm = new SqlCommand(str,dbhelper.Conn);
                dbhelper.OpenConn();
                return (int)comm.ExecuteScalar();
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                dbhelper.CloseConn();
            }


        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            frmEditSinger frmeditsinger = new frmEditSinger();
            frmeditsinger.iR = false;
            if (SearchIdOrUrl() == false)
            {
                return;
            }
            frmeditsinger.singerName = this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString();
            frmeditsinger.singerSex = this.dgvInfo.SelectedRows[0].Cells[2].Value.ToString();
            frmeditsinger.singerTypeDisplay = this.dgvInfo.SelectedRows[0].Cells[1].Value.ToString();
            frmeditsinger.singerInfo = this.dgvInfo.SelectedRows[0].Cells[3].Value.ToString();
            frmeditsinger.singerLj = singUrl;
            frmeditsinger.singerLjsx = singUrl;
            frmeditsinger.singerPhotoUrl = singUrl;
            frmeditsinger.singerId = singId;
            frmeditsinger.singerType = singtypevalue;
            frmeditsinger.ShowDialog();
            SearchSinger();
        }

        //查询歌手ID与照片路径
        public bool SearchIdOrUrl()
        {
            try
            {
                string str = string.Format(@"select s.singer_id
                                            from singer_info as s
                                            inner join singer_type as t on t.singertype_id = s.singertype_id
                                            where s.singer_name = '{0}' and t.singertype_name = '{1}' and s.singer_sex = '{2}'", this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[1].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[2].Value.ToString());
                string strs = string.Format(@"select s.singer_photo_url
                                            from singer_info as s
                                            inner join singer_type as t on t.singertype_id = s.singertype_id
                                            where s.singer_name = '{0}' and t.singertype_name = '{1}' and s.singer_sex = '{2}'", this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[1].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[2].Value.ToString());
                string strss = string.Format(@"select s.singertype_id
                                            from singer_info as s
                                            inner join singer_type as t on t.singertype_id = s.singertype_id
                                            where s.singer_name = '{0}' and t.singertype_name = '{1}' and s.singer_sex = '{2}'", this.dgvInfo.SelectedRows[0].Cells[0].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[1].Value.ToString(), this.dgvInfo.SelectedRows[0].Cells[2].Value.ToString());
                SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
                dbhelper.OpenConn();
                singId = Convert.ToString(comm.ExecuteScalar());
                comm.CommandText = strs;
                singUrl = Convert.ToString(comm.ExecuteScalar());
                comm.CommandText = strss;
                singtypevalue = Convert.ToString(comm.ExecuteScalar());
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("出现异常!");
                return false;
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }
    }
}
