using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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
    public partial class FAddHH : Form
    {
        bool[] tempvalid = new bool[5];
        public FAddHH()
        {
            InitializeComponent();
            dtNgayNhap.Value = DateTime.Today;
            Array.Fill(tempvalid,true);
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
                        var goods = new goods
                        {
                            goodsName = txtTenHang.Text,
                            entryDate = DateOnly.Parse(dtNgayNhap.Value.ToShortDateString()),
                            price = Double.Parse(txtGiaTien.Text),
                            quantity = int.Parse(NmrSoLuong.Value.ToString()),
                            unit = txtDonViTinh.Text,
                            suppiler = txtNhaCC.Text,
                            type = cbLoaiHang.Text
                        };
                        context.goodss.Add(goods);
                        context.SaveChanges();
                        MessageBox.Show("Thêm thành công!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                }
        }

        private void FAddHH_Load(object sender, EventArgs e)
        {
            cbLoaiHang.SelectedItem = "Thực phẩm";
        }

        private void txtTenHang_Leave(object sender, EventArgs e)
        {
            var tb = txtTenHang.Text;
            string temp = "";
            if (tb.IsNullOrEmpty()) temp = "Tên hàng không được để trống";
            if (!tb.All(char.IsLetterOrDigit)) temp = "Vui lòng nhập đúng định dạng";
            if (temp != "")
            {
                tempvalid[0] = false;
                TenHangWarn.Text = temp;
                txtTenHang.StateActive.Border.Color1 = Color.OrangeRed;
            }
        }

        private void txtTenHang_Enter(object sender, EventArgs e)
        {
            tempvalid[0] = true;
            TenHangWarn.Text = "";
            txtTenHang.StateActive.Border.Color1 = Color.Black;
        }

        private void dtNgayNhap_Leave(object sender, EventArgs e)
        {
            if (dtNgayNhap.Value > DateTime.Today)
            {
                tempvalid[1] = false;
                dtwarn.Text = "Vui lòng nhập đúng ngày";
            }
        }

        private void dtNgayNhap_Enter(object sender, EventArgs e)
        {
            tempvalid[1] = true;
            dtwarn.Text = "";
        }

        private void txtGiaTien_Leave(object sender, EventArgs e)
        {
            var tb = txtGiaTien.Text;
            string temp = "";
            if (tb.IsNullOrEmpty()) temp = "Giá tiền không được để trống";
            if (!tb.All(char.IsDigit)) temp = "Vui lòng nhập đúng định dạng";
            if (!temp.IsNullOrEmpty())
            {
                tempvalid[2] = false;
                pricewarn.Text = temp;
                txtGiaTien.StateActive.Border.Color1 = Color.OrangeRed;
            }
        }

        private void txtGiaTien_Enter(object sender, EventArgs e)
        {
            tempvalid[2] = true;
            pricewarn.Text = "";
            txtGiaTien.StateActive.Border.Color1 = Color.Black;
        }

        private void txtNhaCC_Leave(object sender, EventArgs e)
        {
            string tb = txtNhaCC.Text;
            string temp = "";
            if (tb.IsNullOrEmpty()) temp = "Tên hàng không được để trống";
            if (!tb.All(char.IsLetterOrDigit)) temp = "Vui lòng nhập đúng định dạng";
            if (!temp.IsNullOrEmpty())
            {
                tempvalid[3] = false;
                nccwarn.Text = temp;
                txtNhaCC.StateActive.Border.Color1 = Color.OrangeRed;
            }
        }
        private void txtNhaCC_Enter(object sender, EventArgs e)
        {
            tempvalid[3] = true;
            nccwarn.Text = "";
            txtNhaCC.StateActive.Border.Color1 = Color.Black;
        }
        private void txtDonViTinh_Leave(object sender, EventArgs e)
        {
            string tb = txtDonViTinh.Text;
            string temp = "";
            if (tb.IsNullOrEmpty()) temp = "Tên hàng không được để trống";
            if (!tb.All(char.IsLetter)) temp = "Vui lòng nhập đúng định dạng";
            if (!temp.IsNullOrEmpty())
            {
                tempvalid[4] = false;
                dvtinhwarn.Text = temp;
                txtDonViTinh.StateActive.Border.Color1 = Color.OrangeRed;
            }
        }

        private void txtDonViTinh_Enter(object sender, EventArgs e)
        {
            tempvalid[4] = true;
            dvtinhwarn.Text = "";
            txtDonViTinh.StateActive.Border.Color1 = Color.Black;
        }
    }
}
