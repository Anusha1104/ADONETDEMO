namespace ADONETDEMO
{
    partial class Insert
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
            this.txtempno = new System.Windows.Forms.TextBox();
            this.txtename = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.dtdob = new System.Windows.Forms.DateTimePicker();
            this.txtgender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdeptno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Of Birth";
            // 
            // txtempno
            // 
            this.txtempno.Location = new System.Drawing.Point(278, 56);
            this.txtempno.Name = "txtempno";
            this.txtempno.Size = new System.Drawing.Size(100, 20);
            this.txtempno.TabIndex = 4;
            // 
            // txtename
            // 
            this.txtename.Location = new System.Drawing.Point(278, 105);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(100, 20);
            this.txtename.TabIndex = 5;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(217, 271);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 8;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // dtdob
            // 
            this.dtdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdob.Location = new System.Drawing.Point(278, 200);
            this.dtdob.Name = "dtdob";
            this.dtdob.Size = new System.Drawing.Size(100, 20);
            this.dtdob.TabIndex = 9;
            // 
            // txtgender
            // 
            this.txtgender.FormattingEnabled = true;
            this.txtgender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.txtgender.Location = new System.Drawing.Point(278, 156);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(100, 21);
            this.txtgender.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dept no";
            // 
            // txtdeptno
            // 
            this.txtdeptno.Location = new System.Drawing.Point(278, 229);
            this.txtdeptno.Name = "txtdeptno";
            this.txtdeptno.Size = new System.Drawing.Size(100, 20);
            this.txtdeptno.TabIndex = 12;
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdeptno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.dtdob);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtename);
            this.Controls.Add(this.txtempno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Insert";
            this.Text = "Insert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtempno;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.DateTimePicker dtdob;
        private System.Windows.Forms.ComboBox txtgender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdeptno;
    }
}