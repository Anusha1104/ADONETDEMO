namespace ADONETDEMO
{
    partial class triggerEx
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
            this.txtempno = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtempno
            // 
            this.txtempno.Location = new System.Drawing.Point(300, 69);
            this.txtempno.Name = "txtempno";
            this.txtempno.Size = new System.Drawing.Size(100, 20);
            this.txtempno.TabIndex = 0;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(551, 65);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 1;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // triggerEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.txtempno);
            this.Name = "triggerEx";
            this.Text = "triggerEx";
            this.Load += new System.EventHandler(this.triggerEx_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtempno;
        private System.Windows.Forms.Button btn_del;
    }
}