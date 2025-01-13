using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLST_rebase
{
    public partial class FQuanLy : Form
    {
        public FQuanLy()
        {
            InitializeComponent();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            uC_qlnv1.BringToFront();
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            uC_qltk1.BringToFront();
        }

        private void btnQLHH_Click(object sender, EventArgs e)
        {
            uC_qlhh1.BringToFront();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignIn f = new();
            f.ShowDialog();
            Application.Exit();
        }

        private void cuiButtonGroup2_Click(object sender, EventArgs e)
        {
            uC_tk1.BringToFront();
        }
    }
}
