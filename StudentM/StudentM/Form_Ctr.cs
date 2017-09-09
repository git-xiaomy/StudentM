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
using System.Threading;

namespace StudentM
{
    public partial class Form_Ctr : Skin_Mac
    {
        Thread t;
        public Form_Ctr()
        {
            InitializeComponent();
        }

        private void Form_Ctr_Load(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(ThreadMethod));
            //t.Start();
            //if(conn.connsta==false)
            //{
            //    MessageBox.Show("数据库连接异常");
            //}
            DataSet ds =Search.Sway();
            listView1.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (ds.Tables[0].Rows[i][0].ToString());//ID
                lvi.SubItems.Add(ds.Tables[0].Rows[i][1].ToString());//姓名
                lvi.SubItems.Add(ds.Tables[0].Rows[i][2].ToString());//班级
                lvi.SubItems.Add(ds.Tables[0].Rows[i][3].ToString());//学分
                this.listView1.Items.Add(lvi);
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)//开始点名，调用方法并把“姓名”传过去
        {
            //Thread t = new Thread(ThreadMethod);
            //t.Start();
            ThreadMethod();         
        }

        private void skinButton2_Click(object sender, EventArgs e)//暂停点名
        {
            //Thread t = new Thread(new ThreadStart(ThreadMethod));

            //t.Suspend();
        }
        public void ThreadMethod()
        {
            DataSet ds = Search.Sway();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)//遍历每个姓名
            {
                string s = listView1.Items[i].SubItems[2].Text;
                Voice.said(s);
            } 
        }
    }
}
