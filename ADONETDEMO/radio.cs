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
    public partial class radio : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public radio()
        {
            InitializeComponent();
        }

        private void radio_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-0RKU0Q0");
            adp = new SqlDataAdapter("select * from productdetails", con);
            ds = new DataSet();
            adp.Fill(ds, "P");
            dgvdata.DataSource = ds.Tables["P"];




        }

        private void button1_Click(object sender, EventArgs e)
        {


            for(int i=0;i<dgvdata.Rows.Count-1;i++)
            {
               
                string a = dgvdata.Rows[i].Cells[0].Value.ToString();
                
                if (a=="True")
                {
                    string pid=dgvdata.Rows[i].Cells[1].Value.ToString();
                    string pd= dgvdata.Rows[i].Cells[2].Value.ToString();
                    string price=dgvdata.Rows[i].Cells[3].Value.ToString();
                    Form3 f = new Form3(pid,pd,price);
                    f.Show();
                }

            }


        }

       
       

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;

            for (int i = 0; i < dgvdata.Rows.Count; i++)
            {
                dgvdata.Rows[i].Cells[0].Value = false;
            }

            //clean al rows
            //foreach (DataGridViewRow row in dgvdata.Rows)
            //{
            //    row.Cells["Select"].Value = false;
            //}

            //check select row
            dgvdata.CurrentRow.Cells[0].Value = true;
        }
    }
}
