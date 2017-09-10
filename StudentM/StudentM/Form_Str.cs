using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CCWin;

namespace StudentM
{
    public partial class Form_Str : Skin_Mac
    {
       

        public Form_Str(String id,String name)
        {
            InitializeComponent();
            conn.Conndb();
            if (conn.connsta == true)
            {                                                                                                       
                label2.Text = name;//大标题学生姓名
                
                label5.Text = "";//迟到总次数
                label9.Text = "";//旷课总次数
                label8.Text = "";//剩余学分
                SqlDataAdapter sda = new SqlDataAdapter();//Adapter适配器
                sda.SelectCommand = con;
                DataSet ds = new DataSet();//创建一个数据缓存 用来接受数据库里的数据集合
                sda.Fill(ds);
                listView1.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count;i++ )//数据库里有多少行
                {
                    ListViewItem lvi = new ListViewItem();//新建一行，添加每列数据
                    lvi.Text=(ds.Tables[0].Rows[i][0].ToString());//                                          改为 获取类别（旷课或者迟到）
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][0].ToString());                                  // 获取时间
                    listView1.Items.Add(lvi);//添加以上数据到第一个列表（迟到旷课记录）
                    //下为添加第二列数据
                    lvi.Text = (ds.Tables[0].Rows[i][0].ToString());//                                          改为 获取学分
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][0].ToString());                                  // 获取时间
                    listView2.Items.Add(lvi);//添加以上数据到第二个列表（学分加减记录）
                }

            }
            else
            {
                MessageBox.Show("数据库连接异常");
            }
           
        }

        private void Form_Str_Load(object sender, EventArgs e)
        {
            
        }





        public SqlCommand con { get; set; }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==0&&listView2.SelectedItems.Count==0)
            {
                MessageBox.Show("请选择想要删除的项");
                return;
            }
            if (listView1.SelectedItems.Count != 0)
            {
                string ID = listView1.SelectedItems[0].SubItems[0].Text;//获取用户所选取的项
                
            } 
        }
    }
}
