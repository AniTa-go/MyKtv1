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
    public partial class FrmOrderByWordCount : Form
    {
        public FrmOrderByWordCount()
        {
            InitializeComponent();
        }

        private void FrmOrderByWordCount_Load(object sender, EventArgs e)
        {

        }

        private void pBoxD6_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }

        private void pBoxD2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你呼叫了麦KTV服务,服务员正在前往此包间");
        }

        private void pBoxD1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void pBox1_Click(object sender, EventArgs e)
        {
            FrmSongList frmsonglist = new FrmSongList();
            frmsonglist.Owner = this;
            frmsonglist.view = 3;
            frmsonglist.views = 2;
            frmsonglist.song_word_count = 1;
            this.Visible = false;
            frmsonglist.Show(this);
        }

        private void pBox2_Click(object sender, EventArgs e)
        {
            FrmSongList frmsonglist = new FrmSongList();
            frmsonglist.Owner = this;
            frmsonglist.view = 3;
            frmsonglist.views = 2;
            frmsonglist.song_word_count = 2;
            this.Hide();
            frmsonglist.Show(this);
        }

        private void pBox3_Click(object sender, EventArgs e)
        {
            FrmSongList frmsonglist = new FrmSongList();
            frmsonglist.Owner = this;
            frmsonglist.view = 3;
            frmsonglist.views = 2;
            frmsonglist.song_word_count = 3;
            this.Hide();
            frmsonglist.Show(this);
        }

        private void pBox4_Click(object sender, EventArgs e)
        {
            FrmSongList frmsonglist = new FrmSongList();
            frmsonglist.Owner = this;
            frmsonglist.view = 3;
            frmsonglist.views = 2;
            frmsonglist.song_word_count = 4;
            this.Hide();
            frmsonglist.Show(this);
        }

        private void pBox6_Click(object sender, EventArgs e)
        {
            FrmSongList frmsonglist = new FrmSongList();
            frmsonglist.Owner = this;
            frmsonglist.view = 3;
            frmsonglist.views = 2;
            frmsonglist.song_word_count = 5;
            this.Hide();
            frmsonglist.Show(this);
        }

        private void pBox5_Click(object sender, EventArgs e)
        {
            FrmSongList frmsonglist = new FrmSongList();
            frmsonglist.Owner = this;
            frmsonglist.view = 3;
            frmsonglist.views = 2;
            frmsonglist.song_word_count = 6;
            this.Hide();
            frmsonglist.Show(this);
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


    }
}
