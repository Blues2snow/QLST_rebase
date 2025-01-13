using Microsoft.EntityFrameworkCore;
using QLST_rebase.DAO;
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
    public partial class FAddAccount : Form
    {
        public FAddAccount()
        {
            InitializeComponent();
        }

        private void FAddAccount_Load(object sender, EventArgs e)
        {
            using (DataDBContext context = new())
            {
                var staffId = context.staffs.Select(p => p.staffId);
                foreach (var temp in staffId)
                {
                    cbMaNV.Items.Add(temp);
                }
            }
            cbMaNV.SelectedIndex = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Length >= 8 && txtMatKhau.Text == txtMatKhau2.Text)
            {
                using (DataDBContext context = new())
                {
                    var temp = new account
                    {
                        _account = txtTaiKhoan.Text,
                        _password = txtMatKhau.Text,
                        staffId = int.Parse(cbMaNV.Text)
                    };
                    context.accounts.Add(temp);
                    context.SaveChanges();
                    MessageBox.Show("Thêm thành công!");
                }
            }
            else
                MessageBox.Show("Vui lòng nhập lại mật khẩu!");
        }
    }
}
