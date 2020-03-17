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

namespace ADONETDEMO
{
    public partial class CommandBuilderEx1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public CommandBuilderEx1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-0RKU0Q0");
            adp = new SqlDataAdapter("select * from empdata", con);
            DataSet ds = new DataSet();
            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
            SqlCommand cmd = cmb.GetDeleteCommand();
            MessageBox.Show(cmd.CommandText);
            //adp.Fill(ds, "emp");

        }
    }
}
