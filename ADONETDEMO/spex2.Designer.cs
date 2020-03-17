namespace ADONETDEMO
{
    partial class spex2
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
            this.txtdeptno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtename = new System.Windows.Forms.TextBox();
            this.txtempno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtdob = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdeptno
            // 
            this.txtdeptno.Location = new System.Drawing.Point(419, 271);
            this.txtdeptno.Name = "txtdeptno";
            this.txtdeptno.Size = new System.Drawing.Size(100, 20);
            this.txtdeptno.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Dept no";
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(296, 329);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(205, 23);
            this.btninsert.TabIndex = 30;
            this.btninsert.Text = "Update With SP";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtename
            // 
            this.txtename.Location = new System.Drawing.Point(419, 147);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(100, 20);
            this.txtename.TabIndex = 29;
            // 
            // txtempno
            // 
            this.txtempno.Location = new System.Drawing.Point(419, 98);
            this.txtempno.Name = "txtempno";
            this.txtempno.Size = new System.Drawing.Size(100, 20);
            this.txtempno.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Empno";
            // 
            // dtdob
            // 
            this.dtdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdob.Location = new System.Drawing.Point(418, 215);
            this.dtdob.Name = "dtdob";
            this.dtdob.Size = new System.Drawing.Size(100, 20);
            this.dtdob.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Date Of Birth";
            // 
            // spex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtdob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdeptno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtename);
            this.Controls.Add(this.txtempno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "spex2";
            this.Text = "spex2";
            this.Load += new System.EventHandler(this.spex2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdeptno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.TextBox txtempno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtdob;
        private System.Windows.Forms.Label label4;
    }
}