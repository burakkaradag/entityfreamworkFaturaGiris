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
    public partial class frmil : Form
    {
        public frmil()
        {
            InitializeComponent();
        }
        RepIl rep = new RepIl();
        int secilid;
        Il secil;
        private void frmil_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rep.Doldur();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Il i = new Il();
            i.IlAd = txtboxıl.Text;
            rep.ekle(i);
            rep.kaydet();
            frmil_Load(null, null);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            rep.sil(secil);
            rep.kaydet();
            frmil_Load(null, null);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            secil.IlAd = txtboxıl.Text;
            rep.guncelle(secil);
            rep.kaydet();
            frmil_Load(null, null);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilid = (int)dataGridView1.CurrentRow.Cells[0].Value;
            secil = rep.bul(secilid);
            txtboxıl.Text = secil.IlAd;
        }
    }
}
