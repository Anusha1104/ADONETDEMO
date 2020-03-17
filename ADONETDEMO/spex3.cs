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
    public partial class spex3 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public spex3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_empno_Leave(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_extract1", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno",int.Parse(txt_empno.Text));

            SqlParameter p = new SqlParameter("@Status", SqlDbType.NVarChar, 100);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);

            ds = new DataSet();
            adp.Fill(ds, "E");
            DataRow r = null;

            if (p.Value.ToString().Length == 0)
            {
                r = ds.Tables["E"].Rows[0];
                txt_ename.Text = r[1].ToString();
                txt_job.Text = r[2].ToString();
                txt_mgr.Text = r[3].ToString();
                dt_hire.Text = r[4].ToString();
                txt_salary.Text = r[5].ToString();
                txt_commission.Text = r[6].ToString();
                cb_deptno.Text = r[7].ToString();
            }
            else
                MessageBox.Show(p.Value.ToString());






            //if(ds.Tables["E"].Rows.Count!=0)
            //{
            //    r = ds.Tables["E"].Rows[0];
            //    txt_ename.Text = r[1].ToString();
            //    txt_job.Text = r[2].ToString();
            //    txt_mgr.Text = r[3].ToString();
            //    dt_hire.Text = r[4].ToString();
            //    txt_salary.Text = r[5].ToString();
            //    txt_commission.Text = r[6].ToString();
            //    cb_deptno.Text = r[7].ToString();
            //}
            //else
            //{
            //    MessageBox.Show("No Employee Exists");
            //}

        }

        private void spex3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-0RKU0Q0");

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_updatedata", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txt_empno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@newjob",txt_job.Text);
            adp.SelectCommand.Parameters.AddWithValue("@incper",int.Parse(txt_inc.Text));

            SqlParameter p = new SqlParameter("@status", SqlDbType.NVarChar, 100);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);

            ds = new DataSet();
            adp.Fill(ds);

            MessageBox.Show(p.Value.ToString());



        }
    }
}
