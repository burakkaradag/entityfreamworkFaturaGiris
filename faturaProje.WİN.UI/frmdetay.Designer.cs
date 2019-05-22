namespace faturaProje.WİN.UI
{
    partial class frmdetay
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
            this.txtboxfatno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbboxmusteri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datefattarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbboxurun11 = new System.Windows.Forms.ComboBox();
            this.txtboxadet = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxsatır = new System.Windows.Forms.TextBox();
            this.txtboxtoplam = new System.Windows.Forms.TextBox();
            this.btnmstrguncelle = new System.Windows.Forms.Button();
            this.btnmstersil = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxfatno
            // 
            this.txtboxfatno.Location = new System.Drawing.Point(40, 44);
            this.txtboxfatno.Name = "txtboxfatno";
            this.txtboxfatno.Size = new System.Drawing.Size(100, 20);
            this.txtboxfatno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "fatura no";
            // 
            // cmbboxmusteri
            // 
            this.cmbboxmusteri.FormattingEnabled = true;
            this.cmbboxmusteri.Location = new System.Drawing.Point(157, 43);
            this.cmbboxmusteri.Name = "cmbboxmusteri";
            this.cmbboxmusteri.Size = new System.Drawing.Size(121, 21);
            this.cmbboxmusteri.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "musteri";
            // 
            // datefattarih
            // 
            this.datefattarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefattarih.Location = new System.Drawing.Point(293, 41);
            this.datefattarih.Name = "datefattarih";
            this.datefattarih.Size = new System.Drawing.Size(107, 20);
            this.datefattarih.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "fatura tarihi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // cmbboxurun11
            // 
            this.cmbboxurun11.FormattingEnabled = true;
            this.cmbboxurun11.Location = new System.Drawing.Point(634, 134);
            this.cmbboxurun11.Name = "cmbboxurun11";
            this.cmbboxurun11.Size = new System.Drawing.Size(121, 21);
            this.cmbboxurun11.TabIndex = 7;
            // 
            // txtboxadet
            // 
            this.txtboxadet.Location = new System.Drawing.Point(655, 184);
            this.txtboxadet.Name = "txtboxadet";
            this.txtboxadet.Size = new System.Drawing.Size(100, 20);
            this.txtboxadet.TabIndex = 8;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(582, 243);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 9;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ürün";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "miktar";
            // 
            // txtboxsatır
            // 
            this.txtboxsatır.Location = new System.Drawing.Point(50, 300);
            this.txtboxsatır.Name = "txtboxsatır";
            this.txtboxsatır.Size = new System.Drawing.Size(100, 20);
            this.txtboxsatır.TabIndex = 14;
            // 
            // txtboxtoplam
            // 
            this.txtboxtoplam.Location = new System.Drawing.Point(354, 300);
            this.txtboxtoplam.Name = "txtboxtoplam";
            this.txtboxtoplam.Size = new System.Drawing.Size(100, 20);
            this.txtboxtoplam.TabIndex = 15;
            // 
            // btnmstrguncelle
            // 
            this.btnmstrguncelle.Location = new System.Drawing.Point(40, 85);
            this.btnmstrguncelle.Name = "btnmstrguncelle";
            this.btnmstrguncelle.Size = new System.Drawing.Size(137, 23);
            this.btnmstrguncelle.TabIndex = 16;
            this.btnmstrguncelle.Text = "master güncelle";
            this.btnmstrguncelle.UseVisualStyleBackColor = true;
            this.btnmstrguncelle.Click += new System.EventHandler(this.btnmstrguncelle_Click);
            // 
            // btnmstersil
            // 
            this.btnmstersil.Location = new System.Drawing.Point(203, 85);
            this.btnmstersil.Name = "btnmstersil";
            this.btnmstersil.Size = new System.Drawing.Size(116, 23);
            this.btnmstersil.TabIndex = 17;
            this.btnmstersil.Text = "master sil";
            this.btnmstersil.UseVisualStyleBackColor = true;
            this.btnmstersil.Click += new System.EventHandler(this.btnmstersil_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(680, 243);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 18;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click_1);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnguncelle.Location = new System.Drawing.Point(634, 284);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 19;
            this.btnguncelle.Text = "guncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // frmdetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnmstersil);
            this.Controls.Add(this.btnmstrguncelle);
            this.Controls.Add(this.txtboxtoplam);
            this.Controls.Add(this.txtboxsatır);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtboxadet);
            this.Controls.Add(this.cmbboxurun11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datefattarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbboxmusteri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxfatno);
            this.Name = "frmdetay";
            this.Text = "frmdetay";
            this.Load += new System.EventHandler(this.frmdetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxfatno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbboxmusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datefattarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbboxurun11;
        private System.Windows.Forms.TextBox txtboxadet;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxsatır;
        private System.Windows.Forms.TextBox txtboxtoplam;
        private System.Windows.Forms.Button btnmstrguncelle;
        private System.Windows.Forms.Button btnmstersil;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
    }
}