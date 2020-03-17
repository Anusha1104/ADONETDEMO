namespace ADONETDEMO
{
    partial class ConnectionlessEx1
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
            this.txtdeptno = new System.Windows.Forms.TextBox();
            this.btnextract = new System.Windows.Forms.Button();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.cbdeptno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter deptno";
            // 
            // txtdeptno
            // 
            this.txtdeptno.Location = new System.Drawing.Point(334, 105);
            this.txtdeptno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdeptno.Name = "txtdeptno";
            this.txtdeptno.Size = new System.Drawing.Size(132, 22);
            this.txtdeptno.TabIndex = 1;
            // 
            // btnextract
            // 
            this.btnextract.Location = new System.Drawing.Point(603, 105);
            this.btnextract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnextract.Name = "btnextract";
            this.btnextract.Size = new System.Drawing.Size(100, 28);
            this.btnextract.TabIndex = 2;
            this.btnextract.Text = "Extract";
            this.btnextract.UseVisualStyleBackColor = true;
            this.btnextract.Click += new System.EventHandler(this.btnextract_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(50, 207);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(922, 185);
            this.dgvdata.TabIndex = 3;
            // 
            // cbdeptno
            // 
            this.cbdeptno.FormattingEnabled = true;
            this.cbdeptno.Location = new System.Drawing.Point(334, 156);
            this.cbdeptno.Name = "cbdeptno";
            this.cbdeptno.Size = new System.Drawing.Size(121, 24);
            this.cbdeptno.TabIndex = 4;
           // this.cbdeptno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ConnectionlessEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbdeptno);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnextract);
            this.Controls.Add(this.txtdeptno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConnectionlessEx1";
            this.Text = "ConnectionlessEx1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConnectionlessEx1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdeptno;
        private System.Windows.Forms.Button btnextract;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.ComboBox cbdeptno;
    }
}