using Microsoft.Data.SqlClient;
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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLST_rebase
{
    public partial class FAddNV : Form
    {
        bool[] tempvalid = new bool[6];
        public FAddNV()
        {
            InitializeComponent();
            dtNgaySinh.Value = DateTime.Today;
            Array.Fill(tempvalid, true);
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
            if (!valid) MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            else
                AddNV(txtTenNV.Text, dtNgaySinh.Text, cbGioiTinh.Text, txtDiaChi.Text, txtLuong.Text, txtEmail.Text, txtSDT.Text, cbChucVu.Text);
        }

        public void AddNV(string TenNV, string BirthDate, string gender, string addres, string salary, string email, string phonenumber, string position)
        {
            try //1
            {
                if (TenNV != "" && BirthDate != "" && gender != "" && addres != "" && salary != "" && position != "")
                {
                    if (phonenumber.Length == 10)
                    {
                        using (DataDBContext context = new())
                        {
                            var staff = new staff
                            {
                                staffName = TenNV,
                                birthDate = DateOnly.Parse(BirthDate),
                                gender = gender,
                                address = addres,
                                salary = double.Parse(salary),
                                email = email,
                                phoneNumber = phonenumber,
                                position = position 
                            };
                            context.staffs.Add(staff); 
                            context.SaveChanges();
                            MessageBox.Show("Thêm thành công!");   
                        }
                    }
                    else
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                }
                else
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
        }

        private void FAddNV_Load(object sender, EventArgs e)
        {
            cbGioiTinh.SelectedItem = "Nam";
            cbChucVu.SelectedItem = "Quản lý";
        }

        private void txtTenNV_Leave(object sender, EventArgs e)
        {
            string tb = txtTenNV.Text;
            string temp = "";
            if (tb.IsNullOrEmpty()) temp = "Tên hàng không được để trống";
            if (!tb.All(char.IsLetter)) temp = "Vui lòng nhập đúng định dạng";
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
            string tb = txtDiaChi.Text;
            string temp = "";
            if (tb.IsNullOrEmpty()) temp = "Địa chỉ không được để trống";
            if (!tb.All(char.IsLetterOrDigit)) temp = "Vui lòng nhập đúng định dạng";
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
            if (tb.IsNullOrEmpty()) temp = "Lương không được để trống";
            if (!tb.All(char.IsDigit)) temp = "Vui lòng nhập đúng định dạng";
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
            if (tb.IsNullOrEmpty()) temp = "Email không được để trống"; else
            if (!email.IsValid(tb)) temp = "Vui lòng nhập đúng định dạng";
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
            if (!tb.All(char.IsDigit) || !tb.StartsWith("0")) temp = "Vui lòng nhập đúng định dạng";
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
