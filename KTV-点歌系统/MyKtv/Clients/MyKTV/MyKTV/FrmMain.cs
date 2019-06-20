using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKTV
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmOrderBySinger gxd = new FrmOrderBySinger();
            this.Hide();
            gxd.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOrderBySongName na = new FrmOrderBySongName();
            this.Hide();
            na.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmOrderByWordCount co = new FrmOrderByWordCount();
            this.Hide();
            co.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmOrderBySongType ty = new FrmOrderBySongType();
            this.Hide();
            ty.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {


        }
    }
}
