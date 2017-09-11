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
using System.IO;

namespace StudentM
{
    public partial class Form1 : Skin_Mac
    {
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            listView1.Size = new Size(this.Size.Width - 20, listView1.Size.Height);//调整listview宽度
            //开始动画效果
            skinRollingBar1.StartRolling();
            //初始化
            Voice.init();//初始化语音类
            Voice.said("Hello,EverBody");
            Thread init = new Thread(initdb);
            init.Start();
        }

        /// <summary>
        /// 1.获取数据库连接状态
        /// 2.获取学生数据
        /// 3.添加listview
        /// </summary>
        public void initdb() {
            Thread.Sleep(500);
            Boolean b = conn.Conndb();
            if (b)
            {
                label5.Text = "数据库连接成功，信息获取中...";
                //获取数据库学生信息
                DataSet ds = Search.Sway();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    this.listView1.BeginUpdate();//数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度 
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = ds.Tables[0].Rows[i][0].ToString();//ID
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][1].ToString());//学号
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][2].ToString());//姓名
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][3].ToString());//班级
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][5].ToString()==""?"暂无": ds.Tables[0].Rows[i][5].ToString());//电话
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][6].ToString() == "" ? "暂无" : ds.Tables[0].Rows[i][6].ToString());//QQ
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][7].ToString() == "" ? "暂无" : ds.Tables[0].Rows[i][7].ToString());//邮箱
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][4].ToString());//剩余学分
                    listView1.Items.Add(lvi);
                    this.listView1.EndUpdate(); //结束数据处理，UI界面一次性绘制。 
                }
                Thread.Sleep(500);
                label5.Text = "信息获取完毕";
                Thread.Sleep(500);
                skinRollingBar1.StopRolling();
                skinRollingBar1.Enabled = false;
                skinRollingBar1.Visible = false;
                label5.Enabled = false;
                label5.Visible = false;
            }
            else {
                label5.Text = "数据库连接失败";
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_Ctr yybb = new Form_Ctr();
            yybb.Show();
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
            int _Width = listView1.Width-20;
            foreach (ColumnHeader ch in listView1.Columns)
            {
                ch.Width = _Width / _Count;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //调整listview宽度
            listView1.Size = new Size(this.Size.Width - 20, listView1.Size.Height);
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

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            String id = listView1.SelectedItems[0].SubItems[0].Text;
            String name = listView1.SelectedItems[0].SubItems[2].Text;
            Form_Str str = new Form_Str(id, name);
            str.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (label5.Visible != false)
            {
                return;
            }

            String[] s = new string[listView1.Items.Count];
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                s[i] = listView1.Items[i].SubItems[2].Text;
            }
            R_questions r = new R_questions(s);
            r.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //bool b= conn.Add("16516","安豪然", "开发三班", "100", "暂无", "暂无", "暂无");
            //MessageBox.Show(b.ToString());
            //Read("C:\\Users\\Administrator\\Desktop\\name.txt");
        }

        public void Read(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] s = line.Split('/');
                conn.Add(s[2],s[0],s[1],"100","暂无","暂无","暂无");
            }
        }
    }
}
