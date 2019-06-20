using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace KTVClient
{
    class KTVUtil
    {
        DBHelper dbhelper = new DBHelper();

        //获取歌手图片存放路径
        private static string singerPhotoPath;

        public string SingerPhotoPath
        {
            get { return Singer(); }
        }


        //获取歌曲存放路径
        private static string songPath;

        public string SongPath
        {
            get { return Song(); }
        }

        //查询歌手图片路径
        public string Singer()
        {
            string str = "select resource_path from resource_path where resource_type = '歌手图片'";
            try
            {
                SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
                dbhelper.OpenConn();
                return Convert.ToString(comm.ExecuteScalar());
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }

        //查询歌曲存放路径
        public string Song()
        {
            string str = "select resource_path from resource_path where resource_type = '歌曲途径'";
            try
            {
                SqlCommand comm = new SqlCommand(str, dbhelper.Conn);
                dbhelper.OpenConn();
                return Convert.ToString(comm.ExecuteScalar());
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                dbhelper.CloseConn();
            }
        }
    }
}
