using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentM
{
    /// <summary>
    /// 1.连接数据库
    /// 2.更改信息
    /// </summary>
    class conn
    {

       //此方法用于连接数据库  成功返回true 失败返回false
        public static bool Conndb()
        {
            bool b = false;
            string sql = "";
            String connsql = "Data Source=198.168.1.198;Initial CataLog = StudentM;User ID=StudentM;Pwd=123654";
            SqlConnection conn;
            conn = new SqlConnection(connsql);
            try
            {
                conn.Open();
                b = true;
                conn.Close();

            }
            catch
            {
                b = false;


            }

            return b;
        }

    }
}
