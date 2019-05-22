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
    public partial class frmurun : Form
    {
        public frmurun()
        {
            InitializeComponent();
        }
        RepUrun repur = new RepUrun();
        RepBirim repbir = new RepBirim();
        RepKategori repkat = new RepKategori();
        int securunid;
        Urun securun;
        private void frmurun_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repur.Doldur();
            repbir.combodoldur(cmbboxbirim);
            repkat.combodoldur(cmbboxkategori);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            securunid = (int)dataGridView1.CurrentRow.Cells[0].Value;
            securun = repur.bul(securunid);
            txtboxurunad.Text = securun.UrunAd;
            txtboxbirimfiyat.Text = securun.BirimFiyat.ToString();
            txtboxKdv.Text = securun.KDV.ToString();
            cmbboxbirim.SelectedValue = securun.BirimId;
            cmbboxkategori.SelectedValue = securun.KategoriId;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunAd = txtboxurunad.Text;
            u.BirimFiyat =Convert.ToDecimal( txtboxbirimfiyat.Text);
            u.KDV = Convert.ToDecimal(txtboxKdv.Text);
            u.KategoriId =(int) cmbboxkategori.SelectedValue;
            u.BirimId = (int)cmbboxbirim.SelectedValue;
            repur.ekle(u);
            repur.kaydet();
            frmurun_Load(null, null);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            repur.sil(securun);
            repur.kaydet();
            frmurun_Load(null, null);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            securun.UrunAd = txtboxurunad.Text;
            securun.BirimFiyat =Convert.ToDecimal( txtboxbirimfiyat.Text);
            securun.KDV = Convert.ToDecimal(txtboxKdv.Text);
            securun.KategoriId =(int) cmbboxkategori.SelectedValue;
            securun.BirimId = (int)cmbboxbirim.SelectedValue;
            repur.guncelle(securun);
            repur.kaydet();
            frmurun_Load(null, null);
        }
    }
}
