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
    
    public partial class spex4 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public spex4()
        {
            InitializeComponent();
        }

        private void spex4_Load(object sender, EventArgs e)
        {
            
        con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-0RKU0Q0");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_cursorex",con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));

            SqlParameter p = new SqlParameter("@status", SqlDbType.NVarChar, 100);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);

            ds = new DataSet();
            adp.Fill(ds);

            MessageBox.Show(p.Value.ToString());

        }
    }
}
