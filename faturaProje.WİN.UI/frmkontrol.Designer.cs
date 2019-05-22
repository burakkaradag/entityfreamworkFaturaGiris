namespace faturaProje.WİN.UI
{
    partial class frmkontrol
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
            this.txtfatno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfatno
            // 
            this.txtfatno.Location = new System.Drawing.Point(126, 41);
            this.txtfatno.Name = "txtfatno";
            this.txtfatno.Size = new System.Drawing.Size(100, 20);
            this.txtfatno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "fatura no";
            // 
            // btnkontrol
            // 
            this.btnkontrol.Location = new System.Drawing.Point(126, 84);
            this.btnkontrol.Name = "btnkontrol";
            this.btnkontrol.Size = new System.Drawing.Size(75, 23);
            this.btnkontrol.TabIndex = 2;
            this.btnkontrol.Text = "kontrol";
            this.btnkontrol.UseVisualStyleBackColor = true;
            this.btnkontrol.Click += new System.EventHandler(this.btnkontrol_Click);
            // 
            // frmkontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnkontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfatno);
            this.Name = "frmkontrol";
            this.Text = "frmkontrol";
            this.Load += new System.EventHandler(this.frmkontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfatno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkontrol;
    }
}