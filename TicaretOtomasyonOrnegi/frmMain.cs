using System;
using System.Windows.Forms;

namespace TicaretOtomasyonOrnegi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuProducts_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void mnuCategories_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }
    }
}
