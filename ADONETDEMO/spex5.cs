﻿using System;
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
    public partial class spex5 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public spex5()
        {
            InitializeComponent();
        }

        private void spex5_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-0RKU0Q0");

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_cursorex1", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));

            DataSet ds = new DataSet();
            adp.Fill(ds,"E");
            dgvdata.DataSource = ds.Tables["E"];


        }
    }
}
