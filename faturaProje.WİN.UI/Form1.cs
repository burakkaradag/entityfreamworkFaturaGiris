using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faturaProje.WİN.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkategori frm = new frmkategori();
            frm.Show();
        }

        private void ilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmil frm = new frmil();
            frm.Show();
        }

        private void ilçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmılce frm = new frmılce();
            frm.Show();
        }

        private void birimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbirim frm = new frmbirim();
            frm.Show();
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmurun frm = new frmurun();
            frm.Show();
        }

        private void mevcutFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkontrol frm = new frmkontrol();
            frm.Show();
        }

        private void yeniFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmyenifat frm = new frmyenifat();
            frm.Show();
            
        }

        private void müsteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmusteri frm = new frmmusteri();
            frm.Show();
        }
    }
}
