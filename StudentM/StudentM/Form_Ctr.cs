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

namespace StudentM
{
    public partial class Form_Ctr : Form
    {
        String Sql;
        SqlConnection conn;
        public Form_Ctr()
        {
            InitializeComponent();
        }

        private void Form_Ctr_Load(object sender, EventArgs e)
        {
            Sql = "select * from Class_three";
            SqlCommand Scd = new SqlCommand(Sql,conn);
            SqlDataAdapter sda = new SqlDataAdapter();//Adapter适配器
            sda.SelectCommand = Scd;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            listView1.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count;i++ )
            {

            }
        }
    }
}
