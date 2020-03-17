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
    public partial class ConnectionlessEx1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;

        public ConnectionlessEx1()
        {
            InitializeComponent();
        }

        private void ConnectionlessEx1_Load(object sender, EventArgs e)
        {
            con=new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-0RKU0Q0");
            adp = new SqlDataAdapter("Select * from deptdata", con);
           
            DataSet ds = new DataSet();
            adp.Fill(ds, "dno");
            cbdeptno.DataSource = ds.Tables["dno"];
            
            cbdeptno.ValueMember = "deptno";
            cbdeptno.DisplayMember = "dname";

        }

        private void btnextract_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("Select * from empdata where deptno=@d", con);
            adp.SelectCommand.Parameters.AddWithValue("@d", cbdeptno.SelectedValue);
            DataSet ds = new DataSet();
            adp.Fill(ds, "emp");
            dgvdata.DataSource = ds.Tables["emp"];

        }

        
    }
}
