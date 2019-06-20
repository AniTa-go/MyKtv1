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
    public partial class FrmOrderBySinger : Form
    {

        //实例化各个类
        DBHelper dbhelper = new DBHelper();
        KTVUtil ktvutil = new KTVUtil();
        
        //定义查询条件
        //歌手性别
        public string singer_sex;
        //歌手类别
        public int singer_type_id;

        public FrmOrderBySinger()
        {
            InitializeComponent();
        }

        private void FrmOrderBySinger_Load(object sender, EventArgs e)
        {
            //封装一个图像对象，该对象即主窗体背景图片
            Bitmap bm = new Bitmap(this.BackgroundImage, this.Width, this.Height);
            //绘制矩形，定义你需要截取的图像起始位置和宽高
            Rectangle r = new Rectangle(this.lvSinger.Location.X, lvSinger.Location.Y, lvSinger.Width, lvSinger.Height);
            //按矩形尺寸和起始位置截取bm的一部分
            bm = bm.Clone(r, System.Drawing.Imaging.PixelFormat.Undefined);

            //把截取到的图片设置为lv背景，达到与主窗体背景完美契合的效果
            lvSinger.BackgroundImage = (Image)bm;

            this.plA.Visible = true;
            this.plB.Visible = false;
            this.plC.Visible = false;

            //默认的歌手性别以及类别
            singer_sex = string.Empty;
            singer_type_id = 0;
        }


        //歌手性别的情况
        private void pboxA1_Click(object sender, EventArgs e)
        {
            //隐藏窗体操作
            this.plA.Visible = false;
            this.plB.Visible = true;
            //点击后的条件改变操作
            singer_sex = "男";
        }

        private void pBoxA2_Click(object sender, EventArgs e)
        {
            
            this.plA.Visible = false;
            this.plB.Visible = true;
            //点击后的条件改变操作
            singer_sex = "组合";
        }

        private void pBoxA3_Click(object sender, EventArgs e)
        {
            this.plA.Visible = false;
            this.plB.Visible = true;
            //点击后的条件改变操作
            singer_sex = "女";
        }

        private void pBoxDF_Click(object sender, EventArgs e)
        {
            if (this.plC.Visible == true)
            {
                this.plB.Visible = true;
                this.plC.Visible = false;
                this.ilSinger.Images.Clear();
                this.lvSinger.Items.Clear();
            }
            else if(this.plB.Visible == true){
                this.plB.Visible = false;
                this.plA.Visible = true;
                this.ilSinger.Images.Clear();
                this.lvSinger.Items.Clear();
            }
            else if(this.plA.Visible == true){
                this.Owner.Show();
                this.Close();
            }
        }


        //歌手类别的情况
        private void pBoxB1_Click(object sender, EventArgs e)
        {
            this.plB.Visible = false;
            //点击后的条件改变
            singer_type_id = 1;
            AddSinger();
            this.plC.Visible = true;
        }

        private void pBoxB2_Click(object sender, EventArgs e)
        {
            this.plB.Visible = false;
            //点击后的条件改变
            singer_type_id = 2;
            AddSinger();
            this.plC.Visible = true;
        }

        private void pBoxB3_Click(object sender, EventArgs e)
        {
            this.plB.Visible = false;
            //点击后的条件改变
            singer_type_id = 3;
            AddSinger();
            this.plC.Visible = true;
        }

        private void pBoxB4_Click(object sender, EventArgs e)
        {
            this.plB.Visible = false;
            //点击后的条件改变
            singer_type_id = 5;
            AddSinger();
            this.plC.Visible = true;
        }

        private void pBoxB5_Click(object sender, EventArgs e)
        {
            this.plB.Visible = false;
            //点击后的条件改变
            singer_type_id = 4;
            AddSinger();
            this.plC.Visible = true;
        }


        //查询歌手
        public SqlDataReader SearchSinger()
        {
            //查询条件
            string str = string.Format("select * from singer_info where singertype_id = {0} AND singer_sex = '{1}'",singer_type_id,singer_sex);
            //查询
            try
            {
                SqlCommand comm = new SqlCommand(str,dbhelper.Conn);
                dbhelper.OpenConn();
                return comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                return null;
            }
        }
        //添加歌手
        public void AddSinger()
        {
            SqlDataReader reader = SearchSinger();
            int index = 0;
            try
            {
                this.ilSinger.Images.Clear();
                this.lvSinger.Items.Clear();
                //创建索引值
                if(reader.HasRows){
                while(reader.Read()){

                    string singerphoto =  ktvutil.SingerPhotoPath + "\\" + reader["singer_photo_url"].ToString();
                    ListViewItem lv = new ListViewItem(reader["singer_name"].ToString());
                    this.ilSinger.Images.Add(Image.FromFile(singerphoto));
                    lv.Tag = reader["singer_id"];
                    lv.ImageIndex = index;
                   
                    this.lvSinger.Items.Add(lv);
                    index++;
                    
                }
            }
            }
            catch (Exception)
            {
                MessageBox.Show("异常");
            }
            finally
            {
                reader.Close();
            }
        }

        private void pBoxDA_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void lvSinger_Click(object sender, EventArgs e)
        {
            if(this.lvSinger.SelectedItems.Count > 0){
                FrmSongList frmsonglist = new FrmSongList();
                frmsonglist.Owner = this;
                frmsonglist.view = 1;
                frmsonglist.views = 2;
                frmsonglist.sing_id = this.lvSinger.SelectedItems[0].Tag.ToString();
                frmsonglist.Show(this);
                this.Hide();
            }
        }

        private void lvSinger_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pBoxDC_Click(object sender, EventArgs e)
        {
            FrmOrderedSongList frmorderedsonglist = new FrmOrderedSongList();
            frmorderedsonglist.Owner = this;
            frmorderedsonglist.view = 2;
            frmorderedsonglist.Show();
            this.Hide();
        }

        private void pBoxDD_Click(object sender, EventArgs e)
        {
            ((FrmMain)this.Owner).RaginSong();
        }

        private void pBoxDE_Click(object sender, EventArgs e)
        {
            ((FrmMain)this.Owner).NestSonger();
        }

        private void pBoxDB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你呼叫了麦KTV服务,服务员正在前往此包间");
        }
    }
}
