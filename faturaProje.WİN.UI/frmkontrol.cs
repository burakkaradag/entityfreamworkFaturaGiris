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
    public partial class frmkontrol : Form
    {
        public frmkontrol()
        {
            InitializeComponent();
        }

        RepFaturaMaster repfm = new RepFaturaMaster();
        FaturaMaster fm = new FaturaMaster();
        int fatno;
        private void btnkontrol_Click(object sender, EventArgs e)
        {
            fatno = Convert.ToInt32(txtfatno.Text);
            //bool ok = repfm.faturakontrol(Convert.ToInt32( txtfatno.Text));
            //if (ok==true)
            //{
            //    MessageBox.Show("fatura var");
            //    new frmdetay(fatno).Show();
            //}
            //else
            //{
            //    MessageBox.Show("fatura yok");
            //}

            if (repfm.bul(fatno)==null)
            {
                MessageBox.Show("fatura yok");
                
            }
            else
            {
                MessageBox.Show("fatura var");
                new frmdetay(fatno).Show();
            }
        }

        private void frmkontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
