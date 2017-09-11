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
        /// <summary>
        /// 查询学生基本信息方法(全部学生)
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// 查询学生信息（一个学生）
        /// </summary>
        /// <param name="id"></param>
        public static DataSet Sinform(int id)
        {
            SqlCommand Com;
            SqlDataAdapter sda;
            DataSet ds = new DataSet();
            if (conn.connsta == false)
            {
                MessageBox.Show("数据库连接异常");
            }
            else
            {
                sql = "select * from basic where id='"+id+"'";
                Com = new SqlCommand(sql, conn.con);//为执行sql做准备
                sda = new SqlDataAdapter();//Adapter适配器
                sda.SelectCommand = Com;
                sda.Fill(ds);               
            }
            return ds;
        }

        /// <summary>
        /// 查询迟到旷课的次数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataSet Later(int id)
        {
            SqlCommand Com;
            SqlDataAdapter sda;
            DataSet ds = new DataSet();
            if (conn.connsta == false)
            {
                MessageBox.Show("数据库连接异常");
            }
            else
            {
                sql = "select * from basic where id='" + id + "'";
                Com = new SqlCommand(sql, conn.con);//为执行sql做准备
                sda = new SqlDataAdapter();//Adapter适配器
                sda.SelectCommand = Com;
                sda.Fill(ds);
            }
            return ds;
        }

        /// <summary>
        /// 迟到旷课明细（次数，时间）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataSet Detail(int id)
        {
            SqlCommand Com;
            SqlDataAdapter sda;
            DataSet ds = new DataSet();
            if (conn.connsta == false)
            {
                MessageBox.Show("数据库连接异常");
            }
            else
            {
                sql = "select * from basic where id='" + id + "'";
                Com = new SqlCommand(sql, conn.con);//为执行sql做准备
                sda = new SqlDataAdapter();//Adapter适配器
                sda.SelectCommand = Com;
                sda.Fill(ds);
            }
            return ds;
        }
    }
}
