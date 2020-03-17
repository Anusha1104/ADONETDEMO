namespace ADONETDEMO
{
    partial class CommandBuilderEx2
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
            this.txt_empno = new System.Windows.Forms.TextBox();
            this.txt_commission = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_mgr = new System.Windows.Forms.TextBox();
            this.txt_job = new System.Windows.Forms.TextBox();
            this.txt_ename = new System.Windows.Forms.TextBox();
            this.dt_hire = new System.Windows.Forms.DateTimePicker();
            this.cb_deptno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_empno
            // 
            this.txt_empno.Location = new System.Drawing.Point(473, 21);
            this.txt_empno.Name = "txt_empno";
            this.txt_empno.Size = new System.Drawing.Size(100, 20);
            this.txt_empno.TabIndex = 0;
            // 
            // txt_commission
            // 
            this.txt_commission.Location = new System.Drawing.Point(473, 304);
            this.txt_commission.Name = "txt_commission";
            this.txt_commission.Size = new System.Drawing.Size(100, 20);
            this.txt_commission.TabIndex = 1;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(473, 260);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(100, 20);
            this.txt_salary.TabIndex = 2;
            // 
            // txt_mgr
            // 
            this.txt_mgr.Location = new System.Drawing.Point(473, 189);
            this.txt_mgr.Name = "txt_mgr";
            this.txt_mgr.Size = new System.Drawing.Size(100, 20);
            this.txt_mgr.TabIndex = 3;
            this.txt_mgr.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_job
            // 
            this.txt_job.Location = new System.Drawing.Point(473, 125);
            this.txt_job.Name = "txt_job";
            this.txt_job.Size = new System.Drawing.Size(100, 20);
            this.txt_job.TabIndex = 4;
            // 
            // txt_ename
            // 
            this.txt_ename.Location = new System.Drawing.Point(473, 76);
            this.txt_ename.Name = "txt_ename";
            this.txt_ename.Size = new System.Drawing.Size(100, 20);
            this.txt_ename.TabIndex = 5;
            // 
            // dt_hire
            // 
            this.dt_hire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_hire.Location = new System.Drawing.Point(473, 222);
            this.dt_hire.Name = "dt_hire";
            this.dt_hire.Size = new System.Drawing.Size(100, 20);
            this.dt_hire.TabIndex = 6;
            // 
            // cb_deptno
            // 
            this.cb_deptno.FormattingEnabled = true;
            this.cb_deptno.Location = new System.Drawing.Point(473, 362);
            this.cb_deptno.Name = "cb_deptno";
            this.cb_deptno.Size = new System.Drawing.Size(100, 21);
            this.cb_deptno.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Job";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "MGR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hiredate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Salary";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Commission";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Deptno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Empno";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(337, 415);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 16;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // CommandBuilderEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
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
            this.Name = "CommandBuilderEx2";
            this.Text = "CommandBuilderEx2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CommandBuilderEx2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_empno;
        private System.Windows.Forms.TextBox txt_commission;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_mgr;
        private System.Windows.Forms.TextBox txt_job;
        private System.Windows.Forms.TextBox txt_ename;
        private System.Windows.Forms.DateTimePicker dt_hire;
        private System.Windows.Forms.ComboBox cb_deptno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn;
    }
}