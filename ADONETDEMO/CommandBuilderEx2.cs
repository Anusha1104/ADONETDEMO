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
    public partial class CommandBuilderEx2 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public CommandBuilderEx2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CommandBuilderEx2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-0RKU0Q0");
            adp = new SqlDataAdapter("select * from deptdata", con);
            ds = new DataSet();
            adp.Fill(ds, "d");
            cb_deptno.DataSource = ds.Tables["d"];
            cb_deptno.ValueMember = "deptno";
            cb_deptno.DisplayMember = "dname";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-0RKU0Q0");
                adp = new SqlDataAdapter("select * from empdata", con);
                ds = new DataSet();
                adp.Fill(ds, "E");
                DataRow dr = ds.Tables["E"].NewRow();
                dr[0] = int.Parse(txt_empno.Text);
                dr[1] = txt_ename.Text;
                dr[2] = txt_job.Text;
                dr[3] = int.Parse(txt_mgr.Text);
                dr[4] = DateTime.Parse(dt_hire.Text);
                dr[5] = int.Parse(txt_salary.Text);
                dr[6] = int.Parse(txt_commission.Text);
                dr[7] = cb_deptno.SelectedValue;
                ds.Tables["E"].Rows.Add(dr);
                SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
                adp.InsertCommand = cmb.GetInsertCommand();
                adp.Update(ds, "E");
                MessageBox.Show("1 row inserted");
                clear();
            }
            catch(SqlException E)
            {
                MessageBox.Show(E.Message);
            }
             void clear()
            {
                txt_empno.Text = "";
                txt_ename.Text = "";
                txt_job.Text = "";
                txt_mgr.Text = "";
                dt_hire.Text = "";
                txt_salary.Text = "";
                txt_commission.Text = "";
                cb_deptno.Text = "";
            }

        }
    }
}
