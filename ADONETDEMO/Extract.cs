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
    public partial class Extract : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public Extract()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Extract_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-0RKU0Q0");
            
        }

        private void btn_getdata_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd = new SqlCommand("select * from empdata where deptno=@d", con);
            cmd.Parameters.AddWithValue("@d", int.Parse(txtdeptno.Text));
            SqlDataReader r=cmd.ExecuteReader();
            DataSet ds = new DataSet();        //empty database
            ds.Tables.Add("deptdata");         //created table which is empty
            ds.Tables["deptdata"].Load(r);     //table is loaded with r (r has data)
            dgvdata.DataSource = ds.Tables["deptdata"];
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from vw1", con);
            //cmd.Parameters.AddWithValue("@d", int.Parse(txtdeptno.Text));
            SqlDataReader r = cmd.ExecuteReader();
            DataSet ds = new DataSet();        //empty database
            ds.Tables.Add("deptdata");         //created table which is empty
            ds.Tables["deptdata"].Load(r);     //table is loaded with r (r has data)
            dgvdata.DataSource = ds.Tables["deptdata"];
            con.Close();
        }
    }
}
