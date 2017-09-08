using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StudentM
{
    /// <summary>
    /// 用来查询数据
    /// </summary>
    class Search
    {
       static string sql = "";

       static SqlConnection conn;
       public static DataSet Sway()//查询的方法，返回值DataSet
        {
            sql = "select * from basic";
            SqlCommand Com = new SqlCommand(sql, conn);//为执行sql做准备
            SqlDataAdapter sda = new SqlDataAdapter();//Adapter适配器
            sda.SelectCommand = Com;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
            
        }
    }
}
