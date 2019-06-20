using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTVClient
{

        //歌曲播放状态 未播/播放/重播/
         enum SongPlayState
        {
            unplayed,played,again,cut
        }

    class Song
    {
        //歌曲名称
        private string songName;
        //歌曲存放路径
        private string songURL;
        //歌曲播放状态
        private SongPlayState playState = SongPlayState.unplayed;

        //歌曲名称属性
        public string SongName
        {
            set
            {
                songName = value;
            }
            get
            {
                return songName;
            }
        }
        //歌曲存放路径属性
        public string SongURL
        {
            set{
                songURL = new KTVUtil().SongPath + "\\" + value;
            }
            get
            {
                return songURL; 
            }
        }
        //歌曲播放状态属性
        public SongPlayState PlayState
        {
            set
            {
                playState = value;
            }
            get
            {
                return playState;
            }
        }
    }
}
