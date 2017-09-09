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
    public partial class R_questions : Skin_Mac
    {
        String[] s = null;
        Random rd = new Random();//随机类
        public R_questions(String[] s)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.s = s;
            Thread t = new Thread(rq);
            t.Start();
        }

        private void R_questions_Load(object sender, EventArgs e)
        {
            
        }

        public void rq() {
            for (int i = 0; i <= 50; i++)
            {
                int r = rd.Next(s.Length);
                label1.Text = s[r];
                Thread.Sleep(30);
            }
            label2.Text = "幸运王子已诞生！";

        }
    }
}
