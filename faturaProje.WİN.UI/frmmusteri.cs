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
    public partial class frmmusteri : Form
    {
        public frmmusteri()
        {
            InitializeComponent();
        }
        RepMusteri repmus = new RepMusteri();
        RepIlce repılc = new RepIlce();
        RepIl repı = new RepIl();
        int secmusıd;
        Musteri secmusteri;
        private void frmmusteri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repmus.doldur();
            repılc.combodoldur(cmbboxilce);
            repı.combodoldur(cmbboxil);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Musteri mu = new Musteri();
            mu.MusteriAd = txtboxad.Text;
            mu.Adres = txtboxadres.Text;
            mu.VergiDairesi = txtboxvergid.Text;
            mu.IlceId =(int) cmbboxilce.SelectedValue;
          //  mu.Ilce.IlId = (int)cmbboxil.SelectedValue;
            repmus.ekle(mu);
            repmus.kaydet();
            frmmusteri_Load(null, null);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secmusıd = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secmusteri = repmus.bul(secmusıd);
            txtboxad.Text = secmusteri.MusteriAd;
            txtboxadres.Text = secmusteri.Adres;
            txtboxvergid.Text = secmusteri.VergiDairesi;
            cmbboxil.SelectedValue = secmusteri.Ilce.IlId;
            cmbboxilce.SelectedValue = secmusteri.IlceId;


        }
    }
}
