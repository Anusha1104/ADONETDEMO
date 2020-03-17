namespace ADONETDEMO
{
    partial class spex3
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_deptno = new System.Windows.Forms.ComboBox();
            this.dt_hire = new System.Windows.Forms.DateTimePicker();
            this.txt_ename = new System.Windows.Forms.TextBox();
            this.txt_job = new System.Windows.Forms.TextBox();
            this.txt_mgr = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_commission = new System.Windows.Forms.TextBox();
            this.txt_empno = new System.Windows.Forms.TextBox();
            this.txt_inc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(363, 411);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 33;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Empno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Deptno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Commission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hiredate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "MGR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Job";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Employee name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_deptno
            // 
            this.cb_deptno.Enabled = false;
            this.cb_deptno.FormattingEnabled = true;
            this.cb_deptno.Location = new System.Drawing.Point(499, 307);
            this.cb_deptno.Name = "cb_deptno";
            this.cb_deptno.Size = new System.Drawing.Size(100, 21);
            this.cb_deptno.TabIndex = 24;
            // 
            // dt_hire
            // 
            this.dt_hire.Enabled = false;
            this.dt_hire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_hire.Location = new System.Drawing.Point(499, 170);
            this.dt_hire.Name = "dt_hire";
            this.dt_hire.Size = new System.Drawing.Size(100, 20);
            this.dt_hire.TabIndex = 23;
            // 
            // txt_ename
            // 
            this.txt_ename.Enabled = false;
            this.txt_ename.Location = new System.Drawing.Point(499, 52);
            this.txt_ename.Name = "txt_ename";
            this.txt_ename.Size = new System.Drawing.Size(100, 20);
            this.txt_ename.TabIndex = 22;
            // 
            // txt_job
            // 
            this.txt_job.Location = new System.Drawing.Point(499, 90);
            this.txt_job.Name = "txt_job";
            this.txt_job.Size = new System.Drawing.Size(100, 20);
            this.txt_job.TabIndex = 21;
            // 
            // txt_mgr
            // 
            this.txt_mgr.Enabled = false;
            this.txt_mgr.Location = new System.Drawing.Point(499, 128);
            this.txt_mgr.Name = "txt_mgr";
            this.txt_mgr.Size = new System.Drawing.Size(100, 20);
            this.txt_mgr.TabIndex = 20;
            // 
            // txt_salary
            // 
            this.txt_salary.Enabled = false;
            this.txt_salary.Location = new System.Drawing.Point(499, 211);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(100, 20);
            this.txt_salary.TabIndex = 19;
            // 
            // txt_commission
            // 
            this.txt_commission.Enabled = false;
            this.txt_commission.Location = new System.Drawing.Point(499, 256);
            this.txt_commission.Name = "txt_commission";
            this.txt_commission.Size = new System.Drawing.Size(100, 20);
            this.txt_commission.TabIndex = 18;
            // 
            // txt_empno
            // 
            this.txt_empno.Location = new System.Drawing.Point(499, 17);
            this.txt_empno.Name = "txt_empno";
            this.txt_empno.Size = new System.Drawing.Size(100, 20);
            this.txt_empno.TabIndex = 17;
            this.txt_empno.Leave += new System.EventHandler(this.txt_empno_Leave);
            // 
            // txt_inc
            // 
            this.txt_inc.AutoSize = true;
            this.txt_inc.Location = new System.Drawing.Point(207, 363);
            this.txt_inc.Name = "txt_inc";
            this.txt_inc.Size = new System.Drawing.Size(54, 13);
            this.txt_inc.TabIndex = 34;
            this.txt_inc.Text = "Increment";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(499, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 35;
            // 
            // spex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_inc);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_deptno);
            this.Controls.Add(this.dt_hire);
            this.Controls.Add(this.txt_ename);
            this.Controls.Add(this.txt_job);
            this.Controls.Add(this.txt_mgr);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_commission);
            this.Controls.Add(this.txt_empno);
            this.Name = "spex3";
            this.Text = "spex3";
            this.Load += new System.EventHandler(this.spex3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_deptno;
        private System.Windows.Forms.DateTimePicker dt_hire;
        private System.Windows.Forms.TextBox txt_ename;
        private System.Windows.Forms.TextBox txt_job;
        private System.Windows.Forms.TextBox txt_mgr;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_commission;
        private System.Windows.Forms.TextBox txt_empno;
        private System.Windows.Forms.Label txt_inc;
        private System.Windows.Forms.TextBox textBox1;
    }
}