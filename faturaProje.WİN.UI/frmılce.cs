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
    public partial class frmılce : Form
    {
        public frmılce()
        {
            InitializeComponent();
        }

        RepIlce repılc = new RepIlce();
        RepIl repı = new RepIl();
        int secilceid;
        Ilce secilce;
        private void frmılce_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repılc.Doldur();
            repı.combodoldur(cmbboxıl);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilceid = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secilce = repılc.bul(secilceid);
            txtboxılcead.Text = secilce.IlceAd;
            cmbboxıl.SelectedValue = secilce.IlId;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Ilce i = new Ilce();
            i.IlceAd = txtboxılcead.Text;
            i.IlId =(int) cmbboxıl.SelectedValue;
            repılc.ekle(i);
            repılc.kaydet();
            frmılce_Load(null, null);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            secilce.IlceAd = txtboxılcead.Text;
            secilce.IlId =Convert.ToInt32( cmbboxıl.SelectedValue);
            repılc.guncelle(secilce);
            repılc.kaydet();
            frmılce_Load(null, null);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            repılc.sil(secilce);
            repılc.kaydet();
            frmılce_Load(null, null);
        }
    }
}
