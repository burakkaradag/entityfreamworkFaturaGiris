namespace faturaProje.WİN.UI
{
    partial class frmyenifat
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
            this.cmbboxmusteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datefattarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnolustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbboxmusteri
            // 
            this.cmbboxmusteri.FormattingEnabled = true;
            this.cmbboxmusteri.Location = new System.Drawing.Point(111, 47);
            this.cmbboxmusteri.Name = "cmbboxmusteri";
            this.cmbboxmusteri.Size = new System.Drawing.Size(121, 21);
            this.cmbboxmusteri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "müsteri";
            // 
            // datefattarih
            // 
            this.datefattarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefattarih.Location = new System.Drawing.Point(268, 44);
            this.datefattarih.Name = "datefattarih";
            this.datefattarih.Size = new System.Drawing.Size(92, 20);
            this.datefattarih.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "tarih";
            // 
            // btnolustur
            // 
            this.btnolustur.Location = new System.Drawing.Point(68, 115);
            this.btnolustur.Name = "btnolustur";
            this.btnolustur.Size = new System.Drawing.Size(75, 23);
            this.btnolustur.TabIndex = 4;
            this.btnolustur.Text = "olustur";
            this.btnolustur.UseVisualStyleBackColor = true;
            this.btnolustur.Click += new System.EventHandler(this.btnolustur_Click);
            // 
            // frmyenifat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnolustur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datefattarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbboxmusteri);
            this.Name = "frmyenifat";
            this.Text = "frmyenifat";
            this.Load += new System.EventHandler(this.frmyenifat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbboxmusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datefattarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnolustur;
    }
}