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
    public partial class Form1 : Skin_Mac
    {
        public Form1()
        {
            InitializeComponent();
            listView1.Size = new Size(this.Size.Width - 5, listView1.Size.Height);//调整listview宽度
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
