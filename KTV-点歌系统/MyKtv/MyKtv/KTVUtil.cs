using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyKtv
{
    class KTVUtil
    {
        DBHelper dbhelper = new DBHelper();

        private static string singerPhotoPath;
        public string SingerPhotoPath
        {
            get { 
                if(Singer() != null) {
                return Singer();
                }
                else
                {
                    return null;
                }
            }
           
        }
        private static string songPath;

        public string SongPath
        {
            get
            {
                if (Song() != null)
                {
                    return Song();
                }
                else
                {
                    return null;
                }
            }
            
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
