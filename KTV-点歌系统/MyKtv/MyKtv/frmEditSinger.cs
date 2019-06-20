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
    public partial class frmEditSinger : Form
    {
        //创建临时空间
        DataSet ds;
        SqlDataAdapter adapter;
        //实例化DBhelper
        DBHelper dbhelper = new DBHelper();
        KTVUtil ktvutil = new KTVUtil();

        //判断修改或增加的变量
        public bool iR = true;

        //创建存储信息的变量
        public string singerName;
        public string singerSex;
        public string singerType;
        public int singerTypeIndex;
        public string singerTypeDisplay;
        public string singerInfo;
        public string singerLj;
        public string singerLj2;
        public string singerId;

        //歌手图片name
        public string singerLjsx;

        //歌手图片name
        public string singerPhotoName;
        public string singerPhotoUrl;
        
        public frmEditSinger()
        {
            InitializeComponent();
        }

        private void btnSingerPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择歌手图片";
            dialog.Filter = "JPG图片(*.*)|*.JPG*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                singerLj = dialog.FileName;
                singerPhotoName = dialog.SafeFileName;
                singerPhotoUrl = ktvutil.SingerPhotoPath + @"\" + singerPhotoName;
                singerLjsx = dialog.SafeFileName;
                this.pboxSingerPhoto.ImageLocation = singerLj;
            }
        }

        private void frmEditSinger_Load(object sender, EventArgs e)
        {
            AddSingerType();
            this.cboSingerType.SelectedIndex = -1;
            this.pboxSingerPhoto.ImageLocation = ktvutil.SingerPhotoPath + "\\defalut.jpg";
            singerLjsx = "defalut.jpg";
            UpdateCheck();
        }

        //给下拉框填值
        public void AddSingerType()
        {
            try
            {
                string sql = "select * from singer_type";
                ds = new DataSet();
                adapter = new SqlDataAdapter(sql, dbhelper.Conn);
                //填充数据集
                adapter.Fill(ds, "singer_type");
                this.cboSingerType.DataSource = ds.Tables["singer_type"];
                this.cboSingerType.ValueMember = "singertype_id";
                this.cboSingerType.DisplayMember = "singertype_name";
            }
            catch (Exception)
            {
                MessageBox.Show("窗体加载异常");
            }
        }

        //给变量赋值
        public void AddBlByKj()
        {
            singerName = this.txtSingerName.Text.Trim().ToString();
            if(this.rdoNan.Checked){
                singerSex = "男";
            }else if(this.rdoNv.Checked){
                singerSex = "女";
            }else if(this.rdoZh.Checked){
                singerSex = "组合";
            }
            singerType = this.cboSingerType.SelectedValue.ToString();
            singerTypeIndex = this.cboSingerType.SelectedIndex;
            singerInfo = this.txtSingerMs.Text.Trim().ToString();
            singerLj = this.pboxSingerPhoto.ImageLocation.ToString();
        }

        private void btnAddSinger_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                AddBlByKj();
                if(iR == true){
                 AddSingerInfo();
                }else{
                    UpdateSingerInfo();
                }
            }
        }

        //添加歌手信息
        public void AddSingerInfo()
        {
            try
            {
                if (CopyFile() == false)
                {
                    return;
                }
                string str = string.Format("insert into singer_info values('{0}','{1}','{2}','{3}','{4}')", singerName, singerType, singerSex, singerLjsx, singerInfo);
                SqlCommand comm = new SqlCommand(str,dbhelper.Conn);
                dbhelper.OpenConn();
                int i = comm.ExecuteNonQuery();
                if(i>0){
                    MessageBox.Show("添加成功!");
                }
                else
                {
                    MessageBox.Show("添加失败!");
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

        private void pboxSingerPhoto_Click(object sender, EventArgs e)
        {
            
        }

        //非空验证
        public bool CheckInfo()
        {
            if(this.rdoNan.Checked){
                singerSex = "男";
            }else if(this.rdoNv.Checked){
                singerSex = "女";
            }else if(this.rdoZh.Checked){
                singerSex = "组合";
            }
            if(this.txtSingerName.Text.Trim().Equals(string.Empty) || singerSex.Equals(string.Empty) || this.cboSingerType.SelectedIndex.Equals(-1)){
                MessageBox.Show("请填写完整的信息!");
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public bool CopyFile()
        {
            
            try
            {
                if (singerLj.Equals(singerPhotoUrl) || singerLj.Equals(ktvutil.SingerPhotoPath + "\\defalut.jpg"))
                {
                    return true;
                }
                File.Copy(singerLj,singerPhotoUrl, true);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("歌手选择异常!");
                return false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //如果为修改要操作的方法
        public void UpdateCheck()
        {
            if(iR == false){
                this.txtSingerName.Text = singerName;
                this.txtSingerMs.Text = singerInfo;
                if(singerSex.Equals("男")){
                    this.rdoNan.Checked = true;
                }
                else if (singerSex.Equals("女"))
                {
                    this.rdoNv.Checked = true;;
                }else if(singerSex.Equals("组合")){
                    this.rdoZh.Checked = true;
                }
                this.pboxSingerPhoto.ImageLocation = ktvutil.SingerPhotoPath + @"\" + singerLjsx;
                this.cboSingerType.SelectedValue = singerType;
            }
        }

        //修改歌手信息
        public void UpdateSingerInfo()
        {
            try
            {
                CopyFile();
                string str = string.Format("update singer_info set singer_name = '{0}',singertype_id = '{1}',singer_sex = '{2}',singer_photo_url ='{3}',singer_info ='{4}' WHERE singer_id = '{5}'", singerName, singerType, singerSex, singerLjsx, singerInfo, singerId);
                SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
                dbhelper.OpenConn();
                int i = comm.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("修改成功!");
                }
                else
                {
                    MessageBox.Show("修改失败!");
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
