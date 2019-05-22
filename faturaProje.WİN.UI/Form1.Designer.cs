namespace faturaProje.WİN.UI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilçeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mevcutFaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniFaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müsteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlarToolStripMenuItem,
            this.faturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlarToolStripMenuItem
            // 
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilToolStripMenuItem,
            this.ilçeToolStripMenuItem,
            this.birimToolStripMenuItem,
            this.kategoriToolStripMenuItem,
            this.ürünToolStripMenuItem,
            this.müsteriToolStripMenuItem});
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            this.tanımlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.tanımlarToolStripMenuItem.Text = "tanımlar";
            // 
            // ilToolStripMenuItem
            // 
            this.ilToolStripMenuItem.Name = "ilToolStripMenuItem";
            this.ilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ilToolStripMenuItem.Text = "il";
            this.ilToolStripMenuItem.Click += new System.EventHandler(this.ilToolStripMenuItem_Click);
            // 
            // ilçeToolStripMenuItem
            // 
            this.ilçeToolStripMenuItem.Name = "ilçeToolStripMenuItem";
            this.ilçeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ilçeToolStripMenuItem.Text = "ilçe";
            this.ilçeToolStripMenuItem.Click += new System.EventHandler(this.ilçeToolStripMenuItem_Click);
            // 
            // birimToolStripMenuItem
            // 
            this.birimToolStripMenuItem.Name = "birimToolStripMenuItem";
            this.birimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.birimToolStripMenuItem.Text = "birim";
            this.birimToolStripMenuItem.Click += new System.EventHandler(this.birimToolStripMenuItem_Click);
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kategoriToolStripMenuItem.Text = "kategori";
            this.kategoriToolStripMenuItem.Click += new System.EventHandler(this.kategoriToolStripMenuItem_Click);
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünToolStripMenuItem.Text = "ürün";
            this.ürünToolStripMenuItem.Click += new System.EventHandler(this.ürünToolStripMenuItem_Click);
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mevcutFaturaToolStripMenuItem,
            this.yeniFaturaToolStripMenuItem});
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.faturaToolStripMenuItem.Text = "fatura";
            // 
            // mevcutFaturaToolStripMenuItem
            // 
            this.mevcutFaturaToolStripMenuItem.Name = "mevcutFaturaToolStripMenuItem";
            this.mevcutFaturaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.mevcutFaturaToolStripMenuItem.Text = "mevcut fatura";
            this.mevcutFaturaToolStripMenuItem.Click += new System.EventHandler(this.mevcutFaturaToolStripMenuItem_Click);
            // 
            // yeniFaturaToolStripMenuItem
            // 
            this.yeniFaturaToolStripMenuItem.Name = "yeniFaturaToolStripMenuItem";
            this.yeniFaturaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.yeniFaturaToolStripMenuItem.Text = "yeni fatura";
            this.yeniFaturaToolStripMenuItem.Click += new System.EventHandler(this.yeniFaturaToolStripMenuItem_Click);
            // 
            // müsteriToolStripMenuItem
            // 
            this.müsteriToolStripMenuItem.Name = "müsteriToolStripMenuItem";
            this.müsteriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müsteriToolStripMenuItem.Text = "müsteri";
            this.müsteriToolStripMenuItem.Click += new System.EventHandler(this.müsteriToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilçeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mevcutFaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniFaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müsteriToolStripMenuItem;
    }
}

