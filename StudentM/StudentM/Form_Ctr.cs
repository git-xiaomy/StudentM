﻿using System;
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
    public partial class Form_Ctr : Skin_Mac
    {        
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
    }
}
