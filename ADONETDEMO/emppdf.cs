using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ADONETDEMO
{
    public partial class emppdf : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        int index;
        public emppdf()
        {
            InitializeComponent();
        }

        DataTable MakeDataTable()
        {
            DataTable emp = new DataTable();
            emp.Columns.Add("Empno");
            emp.Columns.Add("Ename");
            emp.Columns.Add("Job");
            emp.Columns.Add("MGR");
            emp.Columns.Add("HireDate");
            emp.Columns.Add("Salary");
            emp.Columns.Add("Commission");
            emp.Columns.Add("Deptno");
            

            for(int i=0;i<dgvdata.Rows.Count;i++)
            {
                if (dgvdata.Rows[i].Cells[0].Value != null)
                {
                   // MessageBox.Show((dgvdata.Rows[i].Cells[0] as DataGridViewCheckBoxCell).Value.ToString());

                    bool a = (bool)(dgvdata.Rows[i].Cells[0] as DataGridViewCheckBoxCell).Value;
                    //MessageBox.Show(a);
                    if (a == true)
                    {
                        emp.Rows.Add(dgvdata.Rows[i].Cells[1].Value.ToString(),
                                     dgvdata.Rows[i].Cells[2].Value.ToString(),
                                     dgvdata.Rows[i].Cells[3].Value.ToString(),
                                     dgvdata.Rows[i].Cells[4].Value.ToString(),
                                     dgvdata.Rows[i].Cells[5].Value.ToString(),
                                     dgvdata.Rows[i].Cells[6].Value.ToString(),
                                     dgvdata.Rows[i].Cells[7].Value.ToString(),
                                     dgvdata.Rows[i].Cells[8].Value.ToString());

                    }
                }
            }
            return emp; 
            
        }

        void ExportDataToPdf(DataTable mytable,string path,string Header)
        {
            System.IO.FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            //doc.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            //BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
           // Font fnthead = new Font(bfntHead, 16, 1, Color.Red);
            //Paragraph prgHeading = new Paragraph();
            //prgHeading.Alignment = Element.ALIGN_CENTER;
            //prgHeading.Add(new Chunk(strHeader.Upp
            //doc.Add(prgHeading);

            //Paragraph prgAuthor = new Paragraph();

            PdfPTable table = new PdfPTable(mytable.Columns.Count);

            for(int i=0;i<mytable.Rows.Count;i++)
            {
                for(int j=0;j<mytable.Columns.Count;j++)
                {
                    table.AddCell(mytable.Rows[i][j].ToString());
                }
            }

            doc.Add(table);
            doc.Close();
            writer.Close();
            fs.Close();


        }
        private void emppdf_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=demo;Data Source=DESKTOP-0RKU0Q0");
            adp = new SqlDataAdapter("select * from empdata", con);
            ds = new DataSet();
            adp.Fill(ds, "P");
            dgvdata.DataSource = ds.Tables["P"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                DataTable mytable = MakeDataTable();
                ExportDataToPdf(mytable, @"D:\EMPPDF.pdf", "Friend List");
            //for (int i = 0; i < dgvdata.Rows.Count; i++)
            //{
            //    if (dgvdata.Rows[i].Cells[0].Value != null)
            //    {
            //        if ((bool)(dgvdata.Rows[i].Cells[0] as DataGridViewCheckBoxCell).Value == true)
            //        {
                        System.Diagnostics.Process.Start(@"D:\EMPPDF.pdf");
                        this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    //}
               // }
           // }
            // }
            //catch(Exception ee)
            //{
            //    MessageBox.Show(ee.Message, "Error");
            //}




        }
    }
}
