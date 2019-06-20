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

namespace KTVClient
{
    public partial class FrmMain : Form
    {
        PlayList playlist = new PlayList();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.lblSongAA.Text = playlist.PlayingSongName();
            this.lblSongBB.Text = playlist.NextSongName();
            this.axwPlay.uiMode = "none";
            this.axwPlay.enableContextMenu = false;
            this.axwPlay.settings.autoStart = true;
            this.lblyin.Text = this.axwPlay.settings.volume.ToString();
            CheckMute();
            Deletesong();
        }

        //更新点播次数
        public void Deletesong()
        {
            DBHelper dbhelper = new DBHelper();
            string str = string.Format("update song_info set song_play_count = 0");
            try
            {
                SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
                dbhelper.OpenConn();
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("页面加载出现异常");
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }

        private void pboxDE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pboxA_Click(object sender, EventArgs e)
        {
            FrmOrderBySinger frmorderbysinger = new FrmOrderBySinger();
            this.Hide();
            frmorderbysinger.Owner = this;
            frmorderbysinger.Show(this);
        }

        private void pboxD_Click(object sender, EventArgs e)
        {
            FrmOrderBySongName frmorderbysongtype = new FrmOrderBySongName();
            this.Hide();
            frmorderbysongtype.Owner = this;
            frmorderbysongtype.Show(this);
        }

        private void pboxE_Click(object sender, EventArgs e)
        {
            FrmOrderByWordCount frmorderbywordcount = new FrmOrderByWordCount();
            this.Visible = false;
            frmorderbywordcount.Owner = this;
            frmorderbywordcount.Show(this);
        }

        private void pboxC_Click(object sender, EventArgs e)
        {
            FrmOrderBySongType frmorderbysogtype = new FrmOrderBySongType();
            this.Hide();
            frmorderbysogtype.Owner = this;
            frmorderbysogtype.Show(this);
        }

        private void pboxB_Click(object sender, EventArgs e)
        {
            FrmSongList frmsonglist = new FrmSongList();
            frmsonglist.view = 4;
            frmsonglist.views = 1;
            this.Hide();
            frmsonglist.Owner = this;
            frmsonglist.Show(this);
        }

        private void pboxDB_Click(object sender, EventArgs e)
        {
            FrmOrderedSongList frmorderedsonglist = new FrmOrderedSongList();
            this.Hide();
            frmorderedsonglist.view = 1;
            frmorderedsonglist.Owner = this;
            frmorderedsonglist.Show(this);
        }


        //控制歌曲的播放
        public void PlayMP3()
        {           
            int i = 0;
            while(playlist.SongList[i] != null){
                this.axwPlay.settings.autoStart = true;
                if (this.axwPlay.URL == "")
                {
                    this.axwPlay.URL = playlist.SongList[i].SongURL;
                    playlist.SongList[i].PlayState = SongPlayState.played;
                    CheckSongType();
                    CheckKTV();
                }
                break;
            }
        }
        //删除歌
        public void DeleteSong()
        {
            for (int i = 0; i < playlist.SongList.Length-1;i++ )
            {
                if (playlist.SongList[i] != null)
                {
                    if(playlist.SongList[0].SongURL != this.axwPlay.URL){
                        this.axwPlay.URL = playlist.SongList[i].SongURL;
                        playlist.SongList[i].PlayState = SongPlayState.played;
                        CheckSongType();
                        CheckKTV();
                        break;
                    }
                }

                if(playlist.SongList[i] == null && playlist.SongList[i+1] == null){
                        this.axwPlay.URL = "";
                }
            }
            
        }
        //切歌
        public void NextSong()
        {
            int i = 0;
            int j = 0;

            for (i = 0,j=0; i < playlist.SongList.Length-1;i++ )
            {
                if (playlist.SongList[i] != null && playlist.SongList[i+1] != null)
                {
                    while (playlist.SongList[j] != null)
                    {
                        if (j == playlist.SongList.Length)
                        {
                            playlist.SongList[playlist.SongList.Length] = null;
                        }
                        playlist.SongList[j] = playlist.SongList[j + 1];
                        j++;
                    }

                    playlist.SongList[i].PlayState = SongPlayState.played;
                    this.axwPlay.URL = playlist.SongList[i].SongURL;
                    CheckSongType();
                    CheckKTV();
                    break;
                }
            }
        }

        

        private void pboxDD_Click(object sender, EventArgs e)
        {
            NestSonger();
        }

        //播放下一首
        public void NestSonger()
        {
            NextSong();
            this.lblSongAA.Text = playlist.PlayingSongName();
            this.lblSongBB.Text = playlist.NextSongName();
            this.Update();
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            this.lblSongAA.Text = playlist.PlayingSongName();
            this.lblSongBB.Text = playlist.NextSongName();
            CheckKTV();
        }

        private void axwPlay_Enter(object sender, EventArgs e)
        {

        }

        private void pboxDC_Click(object sender, EventArgs e)
        {
            RaginSong();
        }

        //重播方法
        public void RaginSong()
        {
            int i = 0;

            for (i = 0; i < playlist.SongList.Length; i++)
            {
                if (playlist.SongList[i] != null)
                {
                    playlist.SongList[i].PlayState = SongPlayState.again;
                    this.axwPlay.URL = playlist.SongList[i].SongURL;
                    CheckSongType();
                    CheckKTV();
                    break;
                }
            }
        }

        //歌曲播放完毕切歌方法
        public void SongEndNextSong()
        {
            if(this.axwPlay.URL != ""){
                if (this.axwPlay.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
                {
                    NestSonger();
                }
            }
        }


        private void axwPlay_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(this.axwPlay.URL != ""){
               SongEndNextSong();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.axwPlay.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                this.axwPlay.Ctlcontrols.play();
            }
            if (playlist.SongList[0] == null && playlist.SongList[1] == null)
            {
                this.axwPlay.URL = "";
            }
        }

        //判断歌曲格式
        public void CheckSongType()
        {
            string ss = this.axwPlay.URL.Substring(this.axwPlay.URL.IndexOf("."));
            if ((this.axwPlay.URL.Substring(this.axwPlay.URL.IndexOf(".")).ToUpper()).Equals(".MP3"))
            {
                this.pTop.Visible = true;
            }
            else
            {
                this.pTop.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.axwPlay.Ctlcontrols.pause();
            CheckKTV();
        }

        private void pBox7_Click(object sender, EventArgs e)
        {
            this.axwPlay.Ctlcontrols.play();
            CheckKTV();
        }

        //判断暂停播放空间
        public void CheckKTV()
        {
            if(this.axwPlay.playState == WMPLib.WMPPlayState.wmppsPaused){
                this.pBox7.Visible = true;
                this.pBox6.Visible = false;
            }
            else if (this.axwPlay.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                this.pBox7.Visible = false;
                this.pBox6.Visible = true;
            }
        }

        private void pBoxj_Click(object sender, EventArgs e)
        {
            this.axwPlay.settings.volume = this.axwPlay.settings.volume + 10;
            this.lblyin.Text = this.axwPlay.settings.volume.ToString();
        }

        private void pBoxi_Click(object sender, EventArgs e)
        {
            this.axwPlay.settings.volume = this.axwPlay.settings.volume - 10;
            this.lblyin.Text = this.axwPlay.settings.volume.ToString();
        }

        private void pBoxJy_Click(object sender, EventArgs e)
        {
            this.axwPlay.settings.mute = true;
            CheckMute();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.axwPlay.settings.mute = false;
            CheckMute();
        }

        public void CheckMute()
        {
            if(this.axwPlay.settings.mute == true){
                this.pBoxJy.Visible = false;
                this.pBoxkY.Visible = true;
            }else if(this.axwPlay.settings.mute == false){
                this.pBoxJy.Visible = true;
                this.pBoxkY.Visible = false;
            }
        }

        private void pboxDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你呼叫了麦KTV服务,服务员正在前往此包间");
        }

    }
}
