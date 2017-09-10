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
        public static bool connsta = false;//数据库连接状态
        public static SqlConnection con;
       //此方法用于连接数据库  成功返回true 失败返回false
        public static bool Conndb()
        {
            bool b = false;
            String connsql = "Data Source=192.168.1.100;Initial CataLog = StudentM;User ID=StudentM;Pwd=123654;Connection Timeout=3";
            //String connsql = "Data Source=127.0.0.1;Initial CataLog = StudentM;User ID=StudentM;Pwd=123654;Connection Timeout=3";
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
        public static bool Changeti(int id,string QQ,string tel,string email,int sredits)
        {
            bool b = false;
                if(connsta ==true)
                {                                       //更改信息
                    string ChangetiSql = "update basic set QQ='" + QQ + ",del='" + tel + "',email='" + sredits + ",credits='"+sredits+"' where id='" + id + "'";
                    SqlCommand Changeti = new SqlCommand(ChangetiSql, con);//实例化数据库对象                           
                    try
                    {
                        con.Open();
                        Changeti.ExecuteNonQuery();  
                        b = true;//返回true 更改成功
                        con.Close();
                    }
                    catch
                    {
                        b = false;
                    }

                    return b; 
                }
                else
                {
                    MessageBox.Show("数据库连接异常");

                } return b = false;//b返回false 更改失败
                
        }
        /// <summary>
        /// 添加学生
        /// </summary>
        public static bool Add(string sid, string name,string sclass,string credits,string del,string QQ,string email)
        {
            bool b = false;
            if (connsta == true)
            {
                string AddSql = "insert into basic（Sid，name，class，credits,del,QQ,email） values('"+sid+"','"+name+"','"+sclass+"','"+credits+"','"+del+"','"+QQ+"','"+email+"')";//添加学生信息
                SqlCommand Add = new SqlCommand(AddSql,con);
                try
                {
                    con.Open();
                    Add.ExecuteNonQuery();      
                    b = true;
                    con.Close();
                }
                catch
                {
                 return b ;
                }
           }
            else
            {
                MessageBox.Show("数据库连接异常");

            } return b;//返回false 添加失败
            
        }
        //删除学生
        public static bool delect(int id)
        {               //接收 删除学生的id                                                                
            string DelectSql = "delect from basic where id='"+id+"'";
            SqlCommand delect = new SqlCommand(DelectSql,con);
            bool b = false;
            if(connsta==true)
            {
                con.Open();
                delect.ExecuteNonQuery(); 
                con.Close();
                b = true;
            }
            else
            {
                MessageBox.Show("数据库连接异常");
            }
            return b;
        }
        //学生签到
        public static void signi()
        {

        }
    }
}
