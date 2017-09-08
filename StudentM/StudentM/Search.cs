using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace StudentM
{
    /// <summary>
    /// 用来查询数据
    /// </summary>
    class Search
    {
       static string sql = "";       
       public static DataSet Sway()//查询的方法，返回值DataSet
        {
            SqlCommand Com;
            SqlDataAdapter sda;
            DataSet ds = new DataSet();
            if (conn.connsta == false)
            {
                MessageBox.Show("数据库连接异常");
            }
            else {
                sql = "select * from basic";
                Com = new SqlCommand(sql, conn.con);//为执行sql做准备
                sda = new SqlDataAdapter();//Adapter适配器
                sda.SelectCommand = Com;
                sda.Fill(ds);
            }                
                return ds;
            
            
        }
    }
}
