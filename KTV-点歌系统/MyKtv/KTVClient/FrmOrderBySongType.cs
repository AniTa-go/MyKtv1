using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTVClient
{
    public partial class FrmOrderBySongType : Form
    {
        public FrmOrderBySongType()
        {
            InitializeComponent();
        }



        private void pBoxD6_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void pBox1_Click(object sender, EventArgs e)
        {
            FrmSongList frmsonglist = new FrmSongList();
            frmsonglist.Owner = this;
            frmsonglist.song_type_id = 1;
            frmsonglist.view = 2;
            frmsonglist.views = 2;
            frmsonglist.Show(this);
            this.Hide();
        }

        private void pBox2_Click(object sender, EventArgs e)
        {
            FrmSongList frmsonglist = new FrmSongList();
            frmsonglist.Owner = this;
            frmsonglist.song_type_id = 2;
            frmsonglist.view = 2;
            frmsonglist.views = 2;
            frmsonglist.Show(this);
            this.Hide();
        }

        private void pBox4_Click(object sender, EventArgs e)
        {
            FrmSongList frmsonglist = new FrmSongList();
            frmsonglist.Owner = this;
            frmsonglist.song_type_id = 3;
            frmsonglist.view = 2;
            frmsonglist.views = 2;
            frmsonglist.Show(this);
            this.Hide();
        }

        private void pBox5_Click(object sender, EventArgs e)
        {
            FrmSongList frmsonglist = new FrmSongList();
            frmsonglist.Owner = this;
            frmsonglist.song_type_id = 6;
            frmsonglist.view = 2;
            frmsonglist.views = 2;
            frmsonglist.Show(this);
            this.Hide();
        }

        private void pBox6_Click(object sender, EventArgs e)
        {
            FrmSongList frmsonglist = new FrmSongList();
            frmsonglist.Owner = this;
            frmsonglist.song_type_id = 4;
            frmsonglist.views = 2;
            frmsonglist.view = 2;
            frmsonglist.Show(this);
            this.Hide();
        }

        private void pBox3_Click(object sender, EventArgs e)
        {
            FrmSongList frmsonglist = new FrmSongList();
            frmsonglist.Owner = this;
            frmsonglist.song_type_id = 5;
            frmsonglist.view = 2;
            frmsonglist.views = 2;
            frmsonglist.Show(this);
            this.Hide();
        }

        private void pBoxD1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
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
