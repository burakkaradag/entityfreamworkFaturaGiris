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
    public partial class frmyenifat : Form
    {
        public frmyenifat()
        {
            InitializeComponent();
        }

        RepMusteri repmus = new RepMusteri();
        RepFaturaMaster repfm = new RepFaturaMaster();
        
        private void frmyenifat_Load(object sender, EventArgs e)
        {
            repmus.combodoldur(cmbboxmusteri);
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            FaturaMaster fm = new FaturaMaster();
            fm.MusteriId =(int) cmbboxmusteri.SelectedValue;
            fm.Tarih = datefattarih.Value;
            repfm.ekle(fm);
            repfm.kaydet();
            MessageBox.Show("fatura kayıt edildi.");
            new frmdetay(fm.FaturaNo).Show();

        }
    }
}
