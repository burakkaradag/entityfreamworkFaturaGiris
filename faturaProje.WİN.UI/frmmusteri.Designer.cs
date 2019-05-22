namespace faturaProje.WİN.UI
{
    partial class frmmusteri
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
            this.txtboxad = new System.Windows.Forms.TextBox();
            this.txtboxadres = new System.Windows.Forms.TextBox();
            this.txtboxvergid = new System.Windows.Forms.TextBox();
            this.cmbboxilce = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbboxil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxad
            // 
            this.txtboxad.Location = new System.Drawing.Point(74, 31);
            this.txtboxad.Name = "txtboxad";
            this.txtboxad.Size = new System.Drawing.Size(100, 20);
            this.txtboxad.TabIndex = 0;
            // 
            // txtboxadres
            // 
            this.txtboxadres.Location = new System.Drawing.Point(180, 31);
            this.txtboxadres.Name = "txtboxadres";
            this.txtboxadres.Size = new System.Drawing.Size(100, 20);
            this.txtboxadres.TabIndex = 1;
            // 
            // txtboxvergid
            // 
            this.txtboxvergid.Location = new System.Drawing.Point(286, 31);
            this.txtboxvergid.Name = "txtboxvergid";
            this.txtboxvergid.Size = new System.Drawing.Size(100, 20);
            this.txtboxvergid.TabIndex = 2;
            // 
            // cmbboxilce
            // 
            this.cmbboxilce.FormattingEnabled = true;
            this.cmbboxilce.Location = new System.Drawing.Point(520, 30);
            this.cmbboxilce.Name = "cmbboxilce";
            this.cmbboxilce.Size = new System.Drawing.Size(121, 21);
            this.cmbboxilce.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "musteri ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "vergi dairesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ilçe";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(96, 84);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 9;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "il";
            // 
            // cmbboxil
            // 
            this.cmbboxil.FormattingEnabled = true;
            this.cmbboxil.Location = new System.Drawing.Point(392, 31);
            this.cmbboxil.Name = "cmbboxil";
            this.cmbboxil.Size = new System.Drawing.Size(121, 21);
            this.cmbboxil.TabIndex = 10;
            // 
            // frmmusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbboxil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbboxilce);
            this.Controls.Add(this.txtboxvergid);
            this.Controls.Add(this.txtboxadres);
            this.Controls.Add(this.txtboxad);
            this.Name = "frmmusteri";
            this.Text = "frmmusteri";
            this.Load += new System.EventHandler(this.frmmusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxad;
        private System.Windows.Forms.TextBox txtboxadres;
        private System.Windows.Forms.TextBox txtboxvergid;
        private System.Windows.Forms.ComboBox cmbboxilce;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbboxil;
    }
}