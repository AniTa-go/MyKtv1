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
    public partial class FrmOrderedSongList : Form
    {

        //判断父窗体的变量
        public int view;
        
        
        public FrmOrderedSongList()
        {
            InitializeComponent();
        }



        private void FrmOrderedSongList_Load(object sender, EventArgs e)
        {
            AddSong();
        }

        //获取已点的歌曲
        public void AddSong()
        {
            PlayList playlist = new PlayList();
            int index = 0;
            this.lvsong.Items.Clear();
            for (index = 0; index < playlist.SongList.Length; index++)
            {
                if (playlist.SongList[index] != null)
                {
                    ListViewItem item = new ListViewItem(playlist.SongList[index].SongName);
                    item.Tag = index;
                    if (playlist.SongList[index].PlayState.ToString().Equals(SongPlayState.unplayed.ToString()))
                    {
                         item.SubItems.Add("未播");
                    }
                    else if (playlist.SongList[index].PlayState.ToString().Equals(SongPlayState.played.ToString()))
                    {
                        item.SubItems.Add("正在播放");
                        
                    }
                    else if (playlist.SongList[index].PlayState.ToString().Equals(SongPlayState.again.ToString()))
                    {
                        item.SubItems.Add("重播");                        
                    }
                    this.lvsong.Items.Add(item);
                }
            }
        }


        private void pBoxD2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你呼叫了麦KTV服务,服务员正在前往此包间");
        }

        private void pBoxD6_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void pBoxD1_Click(object sender, EventArgs e)
        {
            if(view == 1){
                this.Owner.Show();
            }else if(view == 2){
                this.Owner.Owner.Show();
            }else if(view == 3){
                this.Owner.Owner.Owner.Show();
            }
            this.Close();
        }

        private void pBoxD5_Click(object sender, EventArgs e)
        {
            if (view == 1)
            {
                ((FrmMain)this.Owner).NestSonger();
            }
            else if (view == 2)
            {
                ((FrmMain)this.Owner.Owner).NestSonger();
            }
            else if (view == 3)
            {
                ((FrmMain)this.Owner.Owner.Owner).NestSonger();
            }
            AddSong();
        }

        private void pBoxD4_Click(object sender, EventArgs e)
        {
            if (view == 1)
            {
                ((FrmMain)this.Owner).RaginSong();
            }
            else if (view == 2)
            {
                ((FrmMain)this.Owner.Owner).RaginSong();
            }
            else if (view == 3)
            {
                ((FrmMain)this.Owner.Owner.Owner).RaginSong();
            }
            AddSong();
        }

        private void pBoxD3_Click(object sender, EventArgs e)
        {

        }


        private void listView1_Click(object sender, EventArgs e)
        {
            PlayList playlist = new PlayList();
            playlist.DeleteSong(Convert.ToInt32(this.lvsong.SelectedItems[0].Tag));
            
                if (view == 1)
                {
                    ((FrmMain)this.Owner).DeleteSong();
                }
                else if (view == 2)
                {
                    ((FrmMain)this.Owner.Owner).DeleteSong();
                }
                else if (view == 3)
                {
                    ((FrmMain)this.Owner.Owner.Owner).DeleteSong();
                }
                AddSong();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
