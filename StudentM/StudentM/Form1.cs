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
    public partial class Form_Main : Skin_Mac
    {
        public Form_Main()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Dr.butt(pictureBox1);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            //控件，方式（放大为0，缩小为1），放大或缩小像素
            Dr.butt(pictureBox1, 0, 7);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //控件，方式（放大为0，缩小为1），放大或缩小像素
            Dr.butt(pictureBox1, 1, 7);
        }

    }
}
