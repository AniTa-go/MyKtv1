using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKtv
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiSearchUser_Click(object sender, EventArgs e)
        {
            frmSingerList frmsingerlist = new frmSingerList();
            frmsingerlist.MdiParent = this;
            frmsingerlist.Show();
        }


        private void tsmiSearchMuisc_Click(object sender, EventArgs e)
        {
            frmSongList frmsonglist = new frmSongList();
            frmsonglist.MdiParent = this;
            frmsonglist.Show();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmabout = new frmAbout();
            frmabout.TopMost = true;
            frmabout.ShowDialog();
        }

        private void tsmiAddUser_Click(object sender, EventArgs e)
        {
            frmEditSinger frmeditsinger = new frmEditSinger();
            frmeditsinger.MdiParent = this;
            frmeditsinger.Show();
        }

        private void tsmiAddMuisc_Click(object sender, EventArgs e)
        {
            frmEditSong frmeditsong = new frmEditSong();
            frmeditsong.MdiParent = this;
            frmeditsong.Show();
        }

        private void tsmiEditSongPhoto_Click(object sender, EventArgs e)
        {
            frmPhotoPath frmphotopath = new frmPhotoPath();
            frmphotopath.ShowDialog();
        }

        private void tsmiEditSingerPhoto_Click(object sender, EventArgs e)
        {
            frmSongPath frmsongpath = new frmSongPath();
            frmsongpath.ShowDialog();
        }

    }
}
