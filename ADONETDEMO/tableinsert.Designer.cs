namespace ADONETDEMO
{
    partial class tableinsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.txtorderdesc = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.dtorderdate = new System.Windows.Forms.DateTimePicker();
            this.cbbcustid = new System.Windows.Forms.ComboBox();
            this.cbbsalesid = new System.Windows.Forms.ComboBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.productid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProductDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Desc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salesman Name";
            // 
            // txtorderid
            // 
            this.txtorderid.Enabled = false;
            this.txtorderid.Location = new System.Drawing.Point(157, 26);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(100, 20);
            this.txtorderid.TabIndex = 6;
            // 
            // txtorderdesc
            // 
            this.txtorderdesc.Location = new System.Drawing.Point(157, 62);
            this.txtorderdesc.Name = "txtorderdesc";
            this.txtorderdesc.Size = new System.Drawing.Size(100, 20);
            this.txtorderdesc.TabIndex = 7;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(596, 25);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(100, 20);
            this.txtdiscount.TabIndex = 8;
            // 
            // dtorderdate
            // 
            this.dtorderdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtorderdate.Location = new System.Drawing.Point(157, 96);
            this.dtorderdate.Name = "dtorderdate";
            this.dtorderdate.Size = new System.Drawing.Size(100, 20);
            this.dtorderdate.TabIndex = 9;
            // 
            // cbbcustid
            // 
            this.cbbcustid.FormattingEnabled = true;
            this.cbbcustid.Location = new System.Drawing.Point(587, 54);
            this.cbbcustid.Name = "cbbcustid";
            this.cbbcustid.Size = new System.Drawing.Size(121, 21);
            this.cbbcustid.TabIndex = 10;
            // 
            // cbbsalesid
            // 
            this.cbbsalesid.FormattingEnabled = true;
            this.cbbsalesid.Location = new System.Drawing.Point(587, 88);
            this.cbbsalesid.Name = "cbbsalesid";
            this.cbbsalesid.Size = new System.Drawing.Size(121, 21);
            this.cbbsalesid.TabIndex = 11;
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.ProductDesc,
            this.Quantity,
            this.UnitPrice,
            this.TotalCost});
            this.dgvdata.Location = new System.Drawing.Point(93, 207);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(543, 150);
            this.dgvdata.TabIndex = 13;
            this.dgvdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellClick);
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvdata.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellLeave);
            this.dgvdata.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_RowLeave);
            this.dgvdata.SelectionChanged += new System.EventHandler(this.dgvdata_SelectionChanged);
            // 
            // productid
            // 
            this.productid.HeaderText = "Product ID";
            this.productid.Name = "productid";
            this.productid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProductDesc
            // 
            this.ProductDesc.HeaderText = "Product Desc";
            this.ProductDesc.Name = "ProductDesc";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.Name = "TotalCost";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(320, 363);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.dgvdata);
            this.panel1.Controls.Add(this.cbbsalesid);
            this.panel1.Controls.Add(this.cbbcustid);
            this.panel1.Controls.Add(this.dtorderdate);
            this.panel1.Controls.Add(this.txtdiscount);
            this.panel1.Controls.Add(this.txtorderdesc);
            this.panel1.Controls.Add(this.txtorderid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(48, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 404);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableinsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "tableinsert";
            this.Text = "tableinsert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tableinsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.TextBox txtorderdesc;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.DateTimePicker dtorderdate;
        private System.Windows.Forms.ComboBox cbbcustid;
        private System.Windows.Forms.ComboBox cbbsalesid;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewComboBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
    }
}