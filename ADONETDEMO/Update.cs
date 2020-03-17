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
    public partial class Update : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=ADODB;Data Source=DESKTOP-0RKU0Q0");

        }



        private void btnextract_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from emp where empno=@eno", con);
                cmd.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));

                SqlDataReader r = cmd.ExecuteReader();
                r.Read();
                txtename.Text = r[1].ToString();
                txtgender.Text = r[2].ToString();
                dtdob.Text = r[3].ToString();
                txtdeptno.Text = r[4].ToString();

            }
            catch (InvalidOperationException M)
            {
                MessageBox.Show("No employee exists with this number");
                txtename.Text = "";
                txtdeptno.Text = "";
                txtgender.Text = "";
                dtdob.Text = "";
            }
            catch(FormatException M)
            {
                MessageBox.Show("enter only number in empno");
            }
            finally
            {
            }
            con.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update emp set ename=@en ,deptno=@dn where empno=@e ", con);
                cmd.Parameters.AddWithValue("@en", txtename.Text);
                cmd.Parameters.AddWithValue("@dn", int.Parse(txtdeptno.Text));
                cmd.Parameters.AddWithValue("@e", int.Parse(txtempno.Text));

                int r = cmd.ExecuteNonQuery();
                if (r != 0)
                    MessageBox.Show(r + " updated");
                else
                    MessageBox.Show("no employee exists");
            }
            catch(SqlException M)
            {
                MessageBox.Show("Size is large ");
            }
            catch(FormatException M)
            {
                MessageBox.Show("please enter in correct format");
            }
           

            finally
            {
                con.Close();
            }



        }

        private void btndel_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from emp where empno=@e ", con);
            cmd.Parameters.AddWithValue("@e", int.Parse(txtempno.Text));

            int r = cmd.ExecuteNonQuery();
            MessageBox.Show(r+ "rows deleted");
            con.Close();
        }
    }

}
   
