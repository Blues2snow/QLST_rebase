using Microsoft.IdentityModel.Tokens;
using QLST_rebase.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLST_rebase
{
    public partial class FEditNV : Form
    {
        bool[] tempvalid = new bool[6];
        public FEditNV()
        {
            InitializeComponent();
            Array.ConvertAll(tempvalid, e => true);
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
            btnConfirm.Focus();
            bool valid = true;
            foreach (bool temp in tempvalid)
                if (!temp)
                {
                    valid = false;
                    break;
                }
            if (!valid) MessageBox.Show("Vui lòng kiểm tra lại thông tin"); else
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

        private void txtTenNV_Leave(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z\s]+$";
            string tb = txtTenNV.Text;
            string temp = "";
            if (!Regex.IsMatch(tb, pattern)) temp = "Vui lòng nhập đúng định dạng";
            if (tb.Length < 2 || tb.Length > 30) temp = "Tên nhân viên từ 2-30 ký tự";
            if (tb.IsNullOrEmpty()) temp = "Tên nhân viên không được để trống";
            if (temp != "")
            {
                tempvalid[0] = false;
                tennvwarn.Text = temp;
                txtTenNV.StateActive.Border.Color1 = Color.OrangeRed;
            }
        }

        private void txtTenNV_Enter(object sender, EventArgs e)
        {
            tempvalid[0] = true;
            tennvwarn.Text = "";
            txtTenNV.StateActive.Border.Color1 = Color.Black;
        }

        private void dtNgaySinh_Leave(object sender, EventArgs e)
        {
            if (dtNgaySinh.Value > DateTime.Today || DateTime.Today.Year - dtNgaySinh.Value.Year < 16)
            {
                tempvalid[1] = false;
                dtwarn.Text = "Vui lòng nhập đúng ngày";
            }
        }

        private void dtNgaySinh_Enter(object sender, EventArgs e)
        {
            tempvalid[1] = true;
            dtwarn.Text = "";
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9\s.,]*$";
            string tb = txtDiaChi.Text;
            string temp = "";
            if (!Regex.IsMatch(tb, pattern)) temp = "Vui lòng nhập đúng định dạng";
            if (tb.IsNullOrEmpty()) temp = "Địa chỉ không được để trống";
            if (temp != "")
            {
                tempvalid[2] = false;
                diachiwarn.Text = temp;
                txtDiaChi.StateActive.Border.Color1 = Color.OrangeRed;
            }
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            tempvalid[2] = true;
            diachiwarn.Text = "";
            txtDiaChi.StateActive.Border.Color1 = Color.Black;
        }

        private void txtLuong_Leave(object sender, EventArgs e)
        {
            string tb = txtLuong.Text;
            string temp = "";
            try
            {
                if (double.Parse(tb) < 1000 || double.Parse(tb) > 100000000)
                    temp = "Lương từ 1.000 đến 100.000.000";
            }
            catch (Exception)
            {
                temp = "Vui lòng nhập đúng định dạng";
            }
            if (tb.IsNullOrEmpty()) temp = "Lương không được để trống";
            if (temp != "")
            {
                tempvalid[3] = false;
                luongwarn.Text = temp;
                txtLuong.StateActive.Border.Color1 = Color.OrangeRed;
            }
        }

        private void txtLuong_Enter(object sender, EventArgs e)
        {
            tempvalid[3] = true;
            luongwarn.Text = "";
            txtLuong.StateActive.Border.Color1 = Color.Black;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            EmailAddressAttribute email = new();
            string tb = txtEmail.Text;
            string temp = "";
            if (!email.IsValid(tb)) temp = "Vui lòng nhập đúng định dạng";
            if (tb.IsNullOrEmpty()) temp = "Email không được để trống";
            if (temp != "")
            {
                tempvalid[4] = false;
                emailwarn.Text = temp;
                txtEmail.StateActive.Border.Color1 = Color.OrangeRed;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            tempvalid[4] = true;
            emailwarn.Text = "";
            txtEmail.StateActive.Border.Color1 = Color.Black;
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            string tb = txtSDT.Text;
            string temp = "";
            if (tb.IsNullOrEmpty()) temp = "Email không được để trống";
            if (!tb.All(char.IsDigit) || !tb.StartsWith("0") || tb.Length != 10) temp = "Vui lòng nhập đúng định dạng";
            if (temp != "")
            {
                tempvalid[5] = false;
                sdtwarn.Text = temp;
                txtSDT.StateActive.Border.Color1 = Color.OrangeRed;
            }
        }

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            tempvalid[5] = true;
            sdtwarn.Text = "";
            txtSDT.StateActive.Border.Color1 = Color.Black;
        }
    }
}
