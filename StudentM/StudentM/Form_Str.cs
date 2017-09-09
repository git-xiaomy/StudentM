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
    public partial class Form_Str : Skin_Mac
    {
        public Form_Str(string ID,string Name)
        {
            MessageBox.Show("ID为"+ID+"\n姓名为"+Name);
        }

        public Form_Str()
        {
            InitializeComponent();
           
        }
        
     
    }
}
