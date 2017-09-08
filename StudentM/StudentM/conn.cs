using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentM
{
    class conn
    {
       
        public void Conndb()
        {
            string sql = "";
            String connsql = "Data Source=198.168.1.198;Initial CataLog = StudentM;User ID=StudentM;Pwd=123654";
            SqlConnection conn;
            //conn = new SqlConnection(connsql);
            //try
            //{
            //    conn.Open();
            //    MessageBox.Show("连接数据库成功");
            //    conn.Close();
                
            //}
            //catch {
            //    MessageBox.Show("数据库连接失败");
                
            
            //}


        }
    }
}
