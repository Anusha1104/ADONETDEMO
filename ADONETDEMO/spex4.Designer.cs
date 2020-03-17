namespace ADONETDEMO
{
    partial class spex4
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
            this.txt_deptno = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdeptno
            // 
            this.txtdeptno.Location = new System.Drawing.Point(425, 68);
            this.txtdeptno.Name = "txtdeptno";
            this.txtdeptno.Size = new System.Drawing.Size(100, 20);
            this.txtdeptno.TabIndex = 0;
            // 
            // txt_deptno
            // 
            this.txt_deptno.AutoSize = true;
            this.txt_deptno.Location = new System.Drawing.Point(231, 74);
            this.txt_deptno.Name = "txt_deptno";
            this.txt_deptno.Size = new System.Drawing.Size(42, 13);
            this.txt_deptno.TabIndex = 1;
            this.txt_deptno.Text = "Deptno";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(320, 149);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // spex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_deptno);
            this.Controls.Add(this.txtdeptno);
            this.Name = "spex4";
            this.Text = "spex4";
            this.Load += new System.EventHandler(this.spex4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdeptno;
        private System.Windows.Forms.Label txt_deptno;
        private System.Windows.Forms.Button btn_update;
    }
}