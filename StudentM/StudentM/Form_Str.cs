using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace StudentM
{
    public partial class Form_Str : Skin_Mac
    {
       

        public Form_Str(String id,String name)
        {
            InitializeComponent();
           
        }

        private void Form_Str_Load(String id, String name)
        {
            conn.Conndb();
            if(conn.connsta==true)
            {
            label2.Text = name;//大标题学生姓名
            label5.Text = "";//迟到总次数
            listView1.

            }
            else
            {
                MessageBox.Show("数据库连接异常");
            }

        }
        
     
    }
}
