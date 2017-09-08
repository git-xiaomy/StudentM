using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentM
{
    //动画类
    class Dr
    {
        //控件，方式（放大为0，缩小为1），放大或缩小像素
        public static void butt(PictureBox o,int f,int i) {
            int w = o.Size.Width;
            int h = o.Size.Height;
            if (f == 0) {
                o.Size = new Size(w + i, h + i);
                //保持焦点不变
                Point pot = new Point(o.Location.X, o.Location.Y);
                o.Location = new Point(pot.X - (i / 2), pot.Y - (i / 2));
            }
            if (f == 1) {
                o.Size = new Size(w - i, h - i);
                //保持焦点不变
                Point pot = new Point(o.Location.X, o.Location.Y);
                o.Location = new Point(pot.X + (i / 2), pot.Y + (i / 2));
            }
        }
    }
}
