using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static faturaProje.BL.Repository;
using static faturaProje.ENT.Entities;

namespace faturaProje.WİN.UI
{
    public partial class frmbirim : Form
    {
        public frmbirim()
        {
            InitializeComponent();
        }
        RepBirim repbir = new RepBirim();
        int secbirimid;
        Birim secbirim;
        private void frmbirim_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repbir.Doldur();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secbirimid = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secbirim = repbir.bul(secbirimid);
            txtboxbirim.Text = secbirim.BirimAd;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Birim bi = new Birim();
            bi.BirimAd = txtboxbirim.Text;
            repbir.ekle(bi);
            repbir.kaydet();
            frmbirim_Load(null, null);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            repbir.sil(secbirim);
            repbir.kaydet();
            frmbirim_Load(null, null);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            secbirim.BirimAd = txtboxbirim.Text;
            repbir.guncelle(secbirim);
            repbir.kaydet();
            frmbirim_Load(null, null);
        }
    }
}
