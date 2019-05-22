namespace faturaProje.WİN.UI
{
    partial class frmurun
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtboxurunad = new System.Windows.Forms.TextBox();
            this.txtboxbirimfiyat = new System.Windows.Forms.TextBox();
            this.txtboxKdv = new System.Windows.Forms.TextBox();
            this.cmbboxbirim = new System.Windows.Forms.ComboBox();
            this.cmbboxkategori = new System.Windows.Forms.ComboBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // txtboxurunad
            // 
            this.txtboxurunad.Location = new System.Drawing.Point(83, 202);
            this.txtboxurunad.Name = "txtboxurunad";
            this.txtboxurunad.Size = new System.Drawing.Size(100, 20);
            this.txtboxurunad.TabIndex = 1;
            // 
            // txtboxbirimfiyat
            // 
            this.txtboxbirimfiyat.Location = new System.Drawing.Point(83, 228);
            this.txtboxbirimfiyat.Name = "txtboxbirimfiyat";
            this.txtboxbirimfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtboxbirimfiyat.TabIndex = 2;
            // 
            // txtboxKdv
            // 
            this.txtboxKdv.Location = new System.Drawing.Point(83, 254);
            this.txtboxKdv.Name = "txtboxKdv";
            this.txtboxKdv.Size = new System.Drawing.Size(100, 20);
            this.txtboxKdv.TabIndex = 3;
            // 
            // cmbboxbirim
            // 
            this.cmbboxbirim.FormattingEnabled = true;
            this.cmbboxbirim.Location = new System.Drawing.Point(334, 201);
            this.cmbboxbirim.Name = "cmbboxbirim";
            this.cmbboxbirim.Size = new System.Drawing.Size(121, 21);
            this.cmbboxbirim.TabIndex = 4;
            // 
            // cmbboxkategori
            // 
            this.cmbboxkategori.FormattingEnabled = true;
            this.cmbboxkategori.Location = new System.Drawing.Point(334, 228);
            this.cmbboxkategori.Name = "cmbboxkategori";
            this.cmbboxkategori.Size = new System.Drawing.Size(121, 21);
            this.cmbboxkategori.TabIndex = 5;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(500, 284);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 8;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(581, 284);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(75, 23);
            this.btngüncelle.TabIndex = 7;
            this.btngüncelle.Text = "güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(411, 284);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 6;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "urunad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "birim fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "kdv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "birim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "kategori";
            // 
            // frmurun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.cmbboxkategori);
            this.Controls.Add(this.cmbboxbirim);
            this.Controls.Add(this.txtboxKdv);
            this.Controls.Add(this.txtboxbirimfiyat);
            this.Controls.Add(this.txtboxurunad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmurun";
            this.Text = "frmurun";
            this.Load += new System.EventHandler(this.frmurun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtboxurunad;
        private System.Windows.Forms.TextBox txtboxbirimfiyat;
        private System.Windows.Forms.TextBox txtboxKdv;
        private System.Windows.Forms.ComboBox cmbboxbirim;
        private System.Windows.Forms.ComboBox cmbboxkategori;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}