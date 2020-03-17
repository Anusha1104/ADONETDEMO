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
    public partial class triggerEx : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public triggerEx()
        {
            InitializeComponent();
        }

        private void triggerEx_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-0RKU0Q0");
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_delete", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@empno", int.Parse(txtempno.Text));

            SqlParameter p = new SqlParameter("@status", SqlDbType.NVarChar, 200);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);

            ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(p.Value.ToString());
        }
    }
}
