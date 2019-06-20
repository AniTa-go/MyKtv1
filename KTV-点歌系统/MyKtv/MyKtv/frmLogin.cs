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

namespace MyKtv
{
    public partial class frmLogin : Form
    {
        //实例化DBhelper
        DBHelper dbhelper = new DBHelper();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        //判断用户输入信息是否为空
        public bool CheckInfo()
        {
            if(this.txtName.Text.Trim().Equals(string.Empty) || this.txtPwd.Text.Trim().Equals(string.Empty)){
                MessageBox.Show("请输入完整的用户名和密码!");
                return false;
            }
            else
            {
                return true;
            }
        }

        //判断数据库中账户密码
        public bool CheckUserPwd()
        {
            string str = string.Format("select count(*) from admin_info where admin_pwd = '{0}' AND admin_name = '{1}'",this.txtPwd.Text.Trim().ToString(),this.txtName.Text.Trim().ToString());
            try
            {
                SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
                dbhelper.OpenConn();
                int i = (int)comm.ExecuteScalar();
                if(i>0){
                    return true;
                }
                else
                {
                    MessageBox.Show("没有此用户");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("查询出现异常");
                return false;
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(CheckInfo()){
                if (CheckUserPwd())
                {
                    frmAdmin frmadmin = new frmAdmin();
                    frmadmin.Show();
                    this.Hide();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
