using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONETDEMO
{
    public partial class Form3 : Form
    {
        public Form3(string pid,string pd,string price)
        {
            InitializeComponent();
            txt_pid.Text = pid;
            txt_pd.Text = pd;
            txt_pp.Text = price;

            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }
    }
}
