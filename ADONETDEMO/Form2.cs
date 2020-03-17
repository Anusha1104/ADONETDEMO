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
    public partial class Form2 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-0RKU0Q0");

        }

        private void txt_empno_Leave(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from empdata where empno=@e", con);
            adp.SelectCommand.Parameters.AddWithValue("@e", int.Parse(txt_empno.Text));
            ds = new DataSet();
            adp.Fill(ds, "E");
            DataRow r = ds.Tables["E"].Rows[0];
            txt_ename.Text = r[1].ToString();
            txt_job.Text = r[2].ToString();
            txt_mgr.Text = r[3].ToString();
            dt_hire.Text = r[4].ToString();
            txt_salary.Text = r[5].ToString();
            txt_commission.Text = r[6].ToString();
            cb_deptno.Text = r[7].ToString();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from empdata where empno=@e", con);
            adp.SelectCommand.Parameters.AddWithValue("@e", int.Parse(txt_empno.Text));
            ds = new DataSet();
            adp.Fill(ds, "E");
            DataRow r = ds.Tables["E"].Rows[0];
            r[2] = txt_job.Text;
            r[3] = txt_mgr.Text;
            r[5] = int.Parse(txt_salary.Text);
            if (txt_commission.Text.Length != 0)
                r[6] = int.Parse(txt_commission.Text);
            r[7] = int.Parse(cb_deptno.Text);
            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
            adp.InsertCommand = cmb.GetInsertCommand();
            adp.Update(ds, "E");
            MessageBox.Show("1 row updated");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from empdata where empno=@e", con);
            adp.SelectCommand.Parameters.AddWithValue("@e", int.Parse(txt_empno.Text));
            ds = new DataSet();
            adp.Fill(ds, "E");
            ds.Tables["E"].Rows[0].Delete();
            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
            adp.DeleteCommand = cmb.GetDeleteCommand();
            adp.Update(ds, "E");
            MessageBox.Show("1 row deleted");
        }
    }
}
