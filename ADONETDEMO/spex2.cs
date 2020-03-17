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
    public partial class spex2 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public spex2()
        {
            InitializeComponent();
        }

        private void spex2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=ADODB;Data Source=DESKTOP-0RKU0Q0");

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_Updateemp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@ename", txtename.Text);
           
            adp.SelectCommand.Parameters.AddWithValue("@dob", dtdob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@deptno", txtdeptno.Text);

            SqlParameter p = new SqlParameter("@result", SqlDbType.NVarChar, 100);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(p.Value.ToString());
            Console.Read();
        }
    }
}
