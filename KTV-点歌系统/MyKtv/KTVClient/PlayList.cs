using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTVClient
{
    class PlayList
    {
        


        FrmOrderedSongList frmorderedsonglist = new FrmOrderedSongList();
        //定义点单列表
        private static Song[] songList = new Song[100];

        public Song[] SongList
        {
            get { return PlayList.songList; }
        }
        
        private static int songIndex;

        //当前播放的歌曲名称
        public string PlayingSongName()
        {
            for (songIndex = 0; songIndex < songList.Length; songIndex++)
            {
                if (songList[songIndex] != null)
                {
                    return songList[songIndex].SongName.ToString();
                }
            }
            return string.Empty;

        }

        //获取当前播放的歌曲
        public string GetPlayingSong()
        {
            if(songList[0] != null){
                return songList[0].SongURL.ToString();
            }
            else
            {
                return null;
            }
        }

        //获取下一首要播放的歌曲名称
        public string NextSongName()
        {
            for (songIndex = 0; songIndex < songList.Length-1; songIndex++)
            {
                if (songList[songIndex+1] != null)
                {
                    return songList[songIndex+1].SongName.ToString();
                }
            }
            return string.Empty;
        }

        //点播一首歌曲
        public void AddSong(Song song)
        {
            for (songIndex = 0; songIndex < songList.Length;songIndex++ )
            {
                if (songList[songIndex] == null)
                {
                    songList[songIndex] = new Song();
                    songList[songIndex] = song;
                    break;
                }
            }

        }

        //切歌
        public void CutSong(int index)
        {
             int i;  // 循环变量，代表切歌的位置
             if (index == -1)
             {
                 i = songIndex;                
             }
             else
             { 
                 i = index; // 从切歌的位置开始，将歌曲逐个向前移一个位置
             }
        }

        //重放当前播放的歌曲
        public void PlayAgain()
        {
            if (SongList[songIndex] != null)
                {
                    SongList[songIndex].PlayState = SongPlayState.again;
                }
        }

        //删除选中歌曲
        public void DeleteSong(int index)
        {
            for (int i = index; i < SongList.Length - 1; i++)
            {
                    if (SongList[i] != null)
                    {
                        SongList[i] = SongList[i + 1];
                        if (i == SongList.Length)
                        {
                            SongList[SongList.Length] = null;
                        }
                    }              
            }
        }

    }
}
