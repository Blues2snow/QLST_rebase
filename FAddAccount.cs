using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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
            AddAccount(txtTaiKhoan.Text, txtMatKhau.Text, txtMatKhau2.Text, cbMaNV.Text);
        }
        public void AddAccount(string txtTaiKhoan,string txtMatKhau,string txtMatKhau2,string cbMaNV)
        {
            if (txtTaiKhoan != "")
            {
                if (txtMatKhau.Length is >= 8 and <= 16)
                {
                    if (txtMatKhau == txtMatKhau2)
                    {
                        using (DataDBContext context = new())
                        {
                            var temp = new account
                            {
                                _account = txtTaiKhoan,
                                _password = txtMatKhau,
                                staffId = int.Parse(cbMaNV)
                            };
                            context.accounts.Add(temp);
                            context.SaveChanges();
                            MessageBox.Show("Thêm thành công!");
                        }
                    }
                    else
                        MessageBox.Show("Mật khẩu nhập lại không khớp \n Vui lòng nhập lại mật khẩu!");
                }
                else
                    MessageBox.Show("Mật khẩu phải từ 8 đến 16 kí tự \n Vui lòng nhập lại mật khẩu!");
            }
            else
                MessageBox.Show("Tài khoản không được để trống!");
        }
    }
}
