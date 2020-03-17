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
    public partial class Inlinefunction : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Inlinefunction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // adp = new SqlDataAdapter("Select * from dbo.fn_first(@dno)", con);
            // adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));

            //adp = new SqlDataAdapter("sp_Gross", con);
            //adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            //adp = new SqlDataAdapter("sp_Gross1", con);
            //adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            //adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));

            // adp = new SqlDataAdapter("Select empno,ename,dbo.fn_grossSal(empno) gross from emploc", con);

            adp = new SqlDataAdapter("sp_service", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            ds = new DataSet();
            adp.Fill(ds, "E");
            dataGridView1.DataSource = ds.Tables["E"];
        }

        private void Inlinefunction_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-0RKU0Q0");
        }
    }
}
