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
    public partial class FEditNV : Form
    {
        public FEditNV()
        {
            InitializeComponent();
        }
        public void getId(string a)
        {
            txtMaNV.Text = a;
        }
        private void FEditNV_Load(object sender, EventArgs e)
        {
            using (DataDBContext context = new())
            {
                var item = context.staffs.FirstOrDefault(p => p.staffId == int.Parse(txtMaNV.Text));
                if (item != null)
                {
                    txtTenNV.Text = item.staffName.ToString();
                    dtNgaySinh.Value = DateTime.Parse(item.birthDate.ToString());
                    cbGioiTinh.SelectedItem = item.gender.ToString();
                    txtDiaChi.Text = item.address.ToString();
                    txtLuong.Text = item.salary.ToString();
                    txtEmail.Text = item.email.ToString();
                    txtSDT.Text = item.phoneNumber.ToString();
                    cbChucVu.SelectedItem = item.position.ToString();
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataDBContext context = new())
                {
                    var item = context.staffs.FirstOrDefault(p => p.staffId == int.Parse(txtMaNV.Text));
                    if (item != null)
                    {
                        item.staffName = txtTenNV.Text;
                        item.birthDate = DateOnly.Parse(dtNgaySinh.Text);
                        item.gender = cbGioiTinh.Text;
                        item.address = txtDiaChi.Text;
                        item.salary = double.Parse(txtLuong.Text);
                        item.email = txtEmail.Text;
                        item.phoneNumber = txtSDT.Text;
                        item.position = cbChucVu.Text;
                        context.SaveChanges();
                        MessageBox.Show("Sửa thành công!");
                    }
                }
            } catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
        }
    }
}
