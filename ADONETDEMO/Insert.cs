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
    public partial class Insert : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public Insert()
        {
            InitializeComponent();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            //step 1
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ADODB;Data Source=DESKTOP-0RKU0Q0");
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgender_TextChanged(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                //step 2
                con.Open();

                //step 3
                cmd = new SqlCommand("insert into emp values(@eno,@en,@g,@d,@dn)", con);
                cmd.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
                cmd.Parameters.AddWithValue("@en", txtename.Text);
                cmd.Parameters.AddWithValue("@g", txtgender.Text);
                cmd.Parameters.AddWithValue("@d", DateTime.Parse(dtdob.Text));
                cmd.Parameters.AddWithValue("@dn", int.Parse(txtdeptno.Text));

                //step 4
                int r = cmd.ExecuteNonQuery();
                MessageBox.Show(r + " row inserted");
            }
            catch (SqlException E)
            {
                if (E.Message.Contains("PK_empno"))
                    MessageBox.Show("empno cannot be duplicated");
                if(E.Message.Contains("CK_dob"))
                    MessageBox.Show("age must be minimum 21");
                if(E.Message.Contains("CK_gender"))
                    MessageBox.Show("gender must be selected from list");
                
                MessageBox.Show(E.Message);
            }
            finally
            {
                //step 5
                con.Close();
            }


        }
    }
}
