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
        Thread th = null;
        public Form_Ctr()
        {
            InitializeComponent();
        }

        private void Form_Ctr_Load(object sender, EventArgs e)
        {          
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

        private void skinButton1_Click(object sender, EventArgs e)//用线程开始点名
        {
            th = new Thread(new ThreadStart(ThreadMethod));//线程入口
            th.Start();
            skinButton2.Enabled = true;
        }

        private void skinButton2_Click(object sender, EventArgs e)//暂停点名
        {
            if (skinButton2.Text == "暂停")
            {
                th.Suspend();
                skinButton2.Text = "继续";
                skinButton3.Enabled = false;
            }
            else {
                th.Resume();
                skinButton2.Text = "暂停";
            }                      
        }
        private void skinButton3_Click(object sender, EventArgs e)
        {
            th.Abort();
            skinButton2.Enabled = false;
        }
        public void ThreadMethod()//调用方法并把“姓名”传过去，进行语音点名
        {
            DataSet ds = Search.Sway();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)//遍历每个姓名
            {
                string s = listView1.Items[i].SubItems[2].Text;
                Voice.said(s);
                Thread.Sleep(2000);
            }
            //MessageBox.Show("线程执行完毕");
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            String s = null;
            Random rd = new Random();//随机类 
            s = listView1.Items.Count.ToString();
            for (int i = 0; i <= 50; i++)
            {
                int r = rd.Next(s.Length);
                //label1.Text = s[r];
                Thread.Sleep(30);
            }
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                s = listView1.Items[i].SubItems[2].Text;
            }
            Voice.said(s);
        }
    }
}
