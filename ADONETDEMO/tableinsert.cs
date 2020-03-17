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
    public partial class tableinsert : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;

        public tableinsert()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select count(*) from orderdetails", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            txtorderid.Text = (int.Parse(ds.Tables[0].Rows[0][0].ToString())+1).ToString();

            adp = new SqlDataAdapter("select salesmanid,salesmanname from salesmandetails",con);
            adp.Fill(ds,"s");
            cbbsalesid.DataSource = ds.Tables["s"];
            cbbsalesid.DisplayMember = "salesmanname";
            cbbsalesid.ValueMember = "salesmanid";

            adp = new SqlDataAdapter("select customerid,customername from customerdetails", con);
            adp.Fill(ds, "cust");
            cbbcustid.DataSource = ds.Tables["cust"];
            cbbcustid.DisplayMember = "customername";
            cbbcustid.ValueMember = "customerid";

            panel1.Visible = true;

        }

        private void tableinsert_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-0RKU0Q0");

            panel1.Visible = false;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_orderproducts", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@oid", txtorderid.Text);
            adp.SelectCommand.Parameters.AddWithValue("@orderdesc", txtorderdesc.Text);
            adp.SelectCommand.Parameters.AddWithValue("@orderdate", DateTime.Parse(dtorderdate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@discount", int.Parse(txtdiscount.Text));
            adp.SelectCommand.Parameters.AddWithValue("@custid", cbbcustid.SelectedValue);
            adp.SelectCommand.Parameters.AddWithValue("@salesid", cbbsalesid.SelectedValue);

            DataTable mytable = new DataTable();
            mytable.Columns.Add("orderid", typeof(string));
            mytable.Columns.Add("productid", typeof(string));
            mytable.Columns.Add("qty", typeof(Int32));

            MessageBox.Show(dgvdata.Rows.Count.ToString());
            for(int i=0;i<dgvdata.Rows.Count-1;i++)
            {
                mytable.Rows.Add(txtorderid.Text, dgvdata.Rows[i].Cells[0].Value.ToString(), dgvdata.Rows[i].Cells[2].Value.ToString());

            }

            SqlParameter p = new SqlParameter("@ord_pro",mytable);
            p.SqlDbType = SqlDbType.Structured;
            adp.SelectCommand.Parameters.Add(p);

            DataSet ds = new DataSet();
            adp.Fill(ds);

            MessageBox.Show("Order placed");
            panel1.Visible = false;
        }

        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.CurrentCell.ColumnIndex.Equals(0))
            {
                adp = new SqlDataAdapter("select productid from productdetails", con);
                DataSet ds = new DataSet();
                adp.Fill(ds, "PID");
                foreach(DataGridViewRow row in dgvdata.Rows)
                {
                    (row.Cells[0] as DataGridViewComboBoxCell).DataSource = ds.Tables["PID"];
                    (row.Cells[0] as DataGridViewComboBoxCell).DisplayMember = "Productid";
                }
            }
               
        }

        private void dgvdata_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvdata.CurrentRow.Cells[2].Value != null)
            {
                int q = int.Parse(dgvdata.CurrentRow.Cells[2].Value.ToString());
                int p = int.Parse(dgvdata.CurrentRow.Cells[3].Value.ToString());
                dgvdata.CurrentRow.Cells[4].Value = q * p;
            }
        }

        private void dgvdata_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvdata.CurrentRow.Cells[0].Value != null)
            {
                if (!dgvdata.CurrentCell.ColumnIndex.Equals(0))
                {
                    adp = new SqlDataAdapter("select * from productdetails where productid=@p", con);
                    adp.SelectCommand.Parameters.AddWithValue("@p", dgvdata.CurrentRow.Cells[0].Value);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "P");
                    dgvdata.CurrentRow.Cells[1].Value = ds.Tables["p"].Rows[0][1];
                    dgvdata.CurrentRow.Cells[3].Value = ds.Tables["p"].Rows[0][2];
                }
            }
        }

        private void dgvdata_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //int q = int.Parse(dgvdata.CurrentRow.Cells[2].Value.ToString());
            //int p= int.Parse(dgvdata.CurrentRow.Cells[].Value.ToString());
            //dgvdata.CurrentRow.Cells[4].Value = q * p;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
