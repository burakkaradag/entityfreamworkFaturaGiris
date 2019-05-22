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
    public partial class frmkategori : Form
    {
        public frmkategori()
        {
            InitializeComponent();
        }
        RepKategori repkat = new RepKategori();
        int seckatıd;
        Kategori seckat;
        private void frmkategori_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repkat.Doldur();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            seckatıd = (int)dataGridView1.CurrentRow.Cells[0].Value;
            seckat = repkat.bul(seckatıd);
            txtboxkatad.Text = seckat.KategoriAd;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Kategori k = new Kategori();
            k.KategoriAd = txtboxkatad.Text;
            repkat.ekle(k);
            repkat.kaydet();
            frmkategori_Load(null, null);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            seckat.KategoriAd = txtboxkatad.Text;
            repkat.guncelle(seckat);
            repkat.kaydet();
            frmkategori_Load(null, null);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            repkat.sil(seckat);
            repkat.kaydet();
            frmkategori_Load(null, null);
        }
    }
}
