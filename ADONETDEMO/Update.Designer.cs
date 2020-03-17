namespace ADONETDEMO
{
    partial class Update
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
            this.txtgender = new System.Windows.Forms.ComboBox();
            this.dtdob = new System.Windows.Forms.DateTimePicker();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtename = new System.Windows.Forms.TextBox();
            this.txtempno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnextract = new System.Windows.Forms.Button();
            this.deptno = new System.Windows.Forms.Label();
            this.txtdeptno = new System.Windows.Forms.TextBox();
            this.btndel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtgender
            // 
            this.txtgender.Enabled = false;
            this.txtgender.FormattingEnabled = true;
            this.txtgender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.txtgender.Location = new System.Drawing.Point(419, 206);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(100, 21);
            this.txtgender.TabIndex = 19;
            // 
            // dtdob
            // 
            this.dtdob.Enabled = false;
            this.dtdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdob.Location = new System.Drawing.Point(419, 250);
            this.dtdob.Name = "dtdob";
            this.dtdob.Size = new System.Drawing.Size(100, 20);
            this.dtdob.TabIndex = 18;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(333, 337);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtename
            // 
            this.txtename.Location = new System.Drawing.Point(419, 155);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(100, 20);
            this.txtename.TabIndex = 16;
            // 
            // txtempno
            // 
            this.txtempno.Location = new System.Drawing.Point(419, 106);
            this.txtempno.Name = "txtempno";
            this.txtempno.Size = new System.Drawing.Size(100, 20);
            this.txtempno.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Empno";
            // 
            // btnextract
            // 
            this.btnextract.Location = new System.Drawing.Point(456, 337);
            this.btnextract.Name = "btnextract";
            this.btnextract.Size = new System.Drawing.Size(75, 23);
            this.btnextract.TabIndex = 20;
            this.btnextract.Text = "Extract";
            this.btnextract.UseVisualStyleBackColor = true;
            this.btnextract.Click += new System.EventHandler(this.btnextract_Click);
            // 
            // deptno
            // 
            this.deptno.AutoSize = true;
            this.deptno.Location = new System.Drawing.Point(286, 289);
            this.deptno.Name = "deptno";
            this.deptno.Size = new System.Drawing.Size(42, 13);
            this.deptno.TabIndex = 21;
            this.deptno.Text = "Deptno";
            // 
            // txtdeptno
            // 
            this.txtdeptno.Location = new System.Drawing.Point(419, 289);
            this.txtdeptno.Name = "txtdeptno";
            this.txtdeptno.Size = new System.Drawing.Size(100, 20);
            this.txtdeptno.TabIndex = 22;
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(195, 337);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 23;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.txtdeptno);
            this.Controls.Add(this.deptno);
            this.Controls.Add(this.btnextract);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.dtdob);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtename);
            this.Controls.Add(this.txtempno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "Update";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtgender;
        private System.Windows.Forms.DateTimePicker dtdob;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.TextBox txtempno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnextract;
        private System.Windows.Forms.Label deptno;
        private System.Windows.Forms.TextBox txtdeptno;
        private System.Windows.Forms.Button btndel;
    }
}