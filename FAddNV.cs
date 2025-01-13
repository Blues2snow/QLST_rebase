using Microsoft.Data.SqlClient;
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
    public partial class FAddNV : Form
    {
        public FAddNV()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataDBContext context = new())
                {
                    var staff = new staff
                    {
                        staffName = txtTenNV.Text,
                        birthDate = DateOnly.Parse(dtNgaySinh.Text),
                        gender = cbGioiTinh.Text,
                        address = txtDiaChi.Text,
                        salary = double.Parse(txtLuong.Text),
                        email = txtEmail.Text,
                        phoneNumber = txtSDT.Text,
                        position = cbChucVu.Text
                    };
                    context.staffs.Add(staff);
                    context.SaveChanges();
                    MessageBox.Show("Thêm thành công!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
        }

        private void FAddNV_Load(object sender, EventArgs e)
        {
            cbGioiTinh.SelectedItem = "Nam";
            cbChucVu.SelectedItem = "Quản lý";
        }
    }
}
