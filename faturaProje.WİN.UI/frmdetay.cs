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
    public partial class frmdetay : Form
    {
        private int fatno;


        public frmdetay()
        {
            InitializeComponent();
        }
        public frmdetay(int fatno)
        {
            InitializeComponent();
            this.fatno = fatno;
        }
        RepMusteri repmus = new RepMusteri();
        RepFaturaMaster repfm = new RepFaturaMaster();
        RepFaturaDetay repfd = new RepFaturaDetay();
        RepUrun repurn = new RepUrun();

        FaturaDetay secfd;
        FaturaMaster secfm;
        private void frmdetay_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void doldur()
        {
            //  gelenfm = repfm.bul(fatno);
            repmus.combodoldur(cmbboxmusteri);
            cmbboxmusteri.SelectedValue = repfm.bul(fatno).MusteriId;
            txtboxfatno.Text = fatno.ToString();
            datefattarih.Value = repfm.bul(fatno).Tarih;
            dataGridView1.DataSource = repfd.doldur(fatno);
            repurn.combodoldur(cmbboxurun11);
            txtboxsatır.Text = repfd.doldur(fatno).Count.ToString();
            txtboxtoplam.Text = repfd.doldur(fatno).Sum(x => x.Toplam).ToString();
            repfm.toplamal(Convert.ToDecimal(txtboxtoplam.Text), fatno);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int faturaıd = (int)dataGridView1.CurrentRow.Cells[0].Value;
            int urunıd = (int)dataGridView1.CurrentRow.Cells[1].Value;
            secfd = repfd.bul(faturaıd, urunıd);
            cmbboxurun11.SelectedValue = secfd.UrunId;
            txtboxadet.Text = secfd.Adet.ToString();


        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FaturaDetay fd = new FaturaDetay();
            fd.FaturaNo = fatno;
            fd.UrunId = (int)cmbboxurun11.SelectedValue;
            fd.Adet = Convert.ToDecimal(txtboxadet.Text);
            fd.Toplam = Convert.ToDecimal(txtboxadet.Text) * repurn.bul((int)cmbboxurun11.SelectedValue).BirimFiyat;
            repfd.ekle(fd);
            repfd.kaydet();
            doldur();

        }



        private void btnmstrguncelle_Click(object sender, EventArgs e)
        {
            secfm = repfm.bul(fatno);
            secfm.MusteriId = Convert.ToInt32(cmbboxmusteri.SelectedValue);
            secfm.Tarih = datefattarih.Value;
            repfm.guncelle(secfm);
            repfm.kaydet();
            doldur();
        }

        private void btnmstersil_Click(object sender, EventArgs e)
        {
            try
            {
                secfm = repfm.bul(fatno);
                repfm.sil(secfm);
                repfm.kaydet();
                MessageBox.Show("fatura silindi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnsil_Click_1(object sender, EventArgs e)
        {
            repfd.sil(secfd);
            repfd.kaydet();
            doldur();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            secfd.Adet = Convert.ToDecimal(txtboxadet.Text);
            repfd.guncelle(secfd);
            repfd.kaydet();
            doldur();
        }
    }
}
