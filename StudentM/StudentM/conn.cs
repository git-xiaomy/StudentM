﻿using System;
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
        public static bool connsta = false;//数据库连接状态
        public static SqlConnection con;
       //此方法用于连接数据库  成功返回true 失败返回false
        public static bool Conndb()
        {
            bool b = false;
            String connsql = "Data Source=198.168.1.198;Initial CataLog = StudentM;User ID=StudentM;Pwd=123654";
            con = new SqlConnection(connsql);
            try
            {
                con.Open();
                b = true;
                connsta = true;
                con.Close();
            }
            catch
            {
                b = false;
             }

            return b;
        }
        /// <summary>
        /// 更改信息
        /// </summary>
        /// <returns></returns>
        public static void Changeti()
        {
            
        }
        /// <summary>
        /// 添加信息
        /// </summary>
        public static void Add()
        {
            
        }
    }
}