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
using System.Threading;

namespace StudentM
{
    public partial class Form1 : Skin_Mac
    {
        public Form1()
        {
            InitializeComponent();
            listView1.Size = new Size(this.Size.Width - 5, listView1.Size.Height);//调整listview宽度
            initdb();
        }


        public void initdb() {
            skinRollingBar1.StartRolling();
            Boolean b = conn.Conndb();
            if (b)
            {
                /*skinRollingBar1.StopRolling();
                skinRollingBar1.Enabled = false;
                skinRollingBar1.Visible = false;
                label5.Enabled = false;
                label5.Visible = false;*/
                label5.Text = "数据库连接成功，信息获取中...";
                addlist();
            }
            else {
                label5.Text = "数据库连接失败";
            }
        }

        public void addlist() {
            DataSet ds = Search.Sway();//获取数据库学生信息
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = ds.Tables[0].Rows[i][0].ToString();//ID
                lvi.SubItems.Add(ds.Tables[0].Rows[i][1].ToString());//学号
                lvi.SubItems.Add(ds.Tables[0].Rows[i][2].ToString());//姓名
                lvi.SubItems.Add(ds.Tables[0].Rows[i][3].ToString());//班级
                lvi.SubItems.Add(ds.Tables[0].Rows[i][5].ToString());//电话
                lvi.SubItems.Add(ds.Tables[0].Rows[i][6].ToString());//QQ
                lvi.SubItems.Add(ds.Tables[0].Rows[i][7].ToString());//邮箱
                lvi.SubItems.Add(ds.Tables[0].Rows[i][4].ToString());//剩余学分
                listView1.Items.Add(lvi);
            }
            skinRollingBar1.StopRolling();
            skinRollingBar1.Enabled = false;
            skinRollingBar1.Visible = false;
            label5.Enabled = false;
            label5.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            //控件，方式（放大为0，缩小为1），放大或缩小像素
            this.Cursor = Cursors.Hand;
            Dr.butt(pictureBox1, 0, 7);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //控件，方式（放大为0，缩小为1），放大或缩小像素
            this.Cursor = Cursors.Default;
            Dr.butt(pictureBox1, 1, 7);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            //控件，方式（放大为0，缩小为1），放大或缩小像素
            this.Cursor = Cursors.Hand;
            Dr.butt(pictureBox2, 0, 7);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            //控件，方式（放大为0，缩小为1），放大或缩小像素
            this.Cursor = Cursors.Default;
            Dr.butt(pictureBox2, 1, 7);
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        //listview宽度铺满
        private void listView1_SizeChanged(object sender, EventArgs e)
        {
            int _Count = listView1.Columns.Count;
            int _Width = listView1.Width;
            foreach (ColumnHeader ch in listView1.Columns)
            {
                ch.Width = _Width / _Count;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //调整listview宽度
            listView1.Size = new Size(this.Size.Width - 5, listView1.Size.Height);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            //控件，方式（放大为0，缩小为1），放大或缩小像素
            this.Cursor = Cursors.Hand;
            Dr.butt(pictureBox3, 0, 7);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            //控件，方式（放大为0，缩小为1），放大或缩小像素
            this.Cursor = Cursors.Default;
            Dr.butt(pictureBox3, 1, 7);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            //控件，方式（放大为0，缩小为1），放大或缩小像素
            this.Cursor = Cursors.Hand;
            Dr.butt(pictureBox4, 0, 7);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            //控件，方式（放大为0，缩小为1），放大或缩小像素
            this.Cursor = Cursors.Default;
            Dr.butt(pictureBox4, 1, 7);
        }
    }
}
