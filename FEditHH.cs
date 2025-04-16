using Microsoft.IdentityModel.Tokens;
using QLST_rebase.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QLST_rebase
{
    public partial class FEditHH : Form
    {
        bool[] tempvalid = new bool[5];
        public FEditHH()
        {
            InitializeComponent();
            Array.ConvertAll(tempvalid, e => true);
        }
        public void getId(string a)
        {
            txtMaHang.Text = a;
        }
        private void FEditHH_Load(object sender, EventArgs e)
        {
            using (DataDBContext context = new())
            {

                var item = context.goodss.FirstOrDefault(p => p.goodsId == int.Parse(txtMaHang.Text));
                if (item != null)
                {
                    txtTenHang.Text = item.goodsName.ToString();
                    dtNgayNhap.Value = DateTime.Today;
                    txtGiaTien.Text = item.price.ToString();
                    NmrSoLuong.Value = int.Parse(item.quantity.ToString());
                    txtDonViTinh.Text = item.unit.ToString();
                    txtNhaCC.Text = item.suppiler.ToString();
                    cbLoaiHang.SelectedItem = item.type.ToString();
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
            using (DataDBContext context = new())
            {
                var goods = context.goodss.FirstOrDefault(p => p.goodsId == int.Parse(txtMaHang.Text));
                if (!valid) MessageBox.Show("Vui lòng kiểm tra lại thông tin"); else
                if (goods != null)
                {
                    goods.goodsName = txtTenHang.Text;
                    goods.entryDate = DateOnly.Parse(dtNgayNhap.Value.ToShortDateString());
                    goods.price = double.Parse(txtGiaTien.Text);
                    goods.quantity = int.Parse(NmrSoLuong.Value.ToString());
                    goods.unit = txtDonViTinh.Text;
                    goods.suppiler = txtNhaCC.Text;
                    goods.type = cbLoaiHang.Text;
                    context.SaveChanges();
                    MessageBox.Show("Sửa thành công!");
                }
            }
        }

        private void txtTenHang_Leave(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9\s.,]+$";
            var tb = txtTenHang.Text;
            string temp = "";
            if (!Regex.IsMatch(tb, pattern)) temp = "Vui lòng nhập đúng định dạng";
            if (tb.IsNullOrEmpty()) temp = "Tên hàng không được để trống";
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
            if (!tb.All(char.IsDigit)) temp = "Vui lòng nhập đúng định dạng";
            if (tb.IsNullOrEmpty()) temp = "Giá tiền không được để trống";
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
            string pattern = @"^[a-zA-Z0-9\s.,]+$";
            string tb = txtNhaCC.Text;
            string temp = "";
            if (!Regex.IsMatch(tb, pattern)) temp = "Vui lòng nhập đúng định dạng";
            if (tb.IsNullOrEmpty()) temp = "Tên hàng không được để trống";
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
            string pattern = @"^[a-zA-Z0-9\s.,]+$";
            string tb = txtDonViTinh.Text;
            string temp = "";
            if (!Regex.IsMatch(tb, pattern)) temp = "Vui lòng nhập đúng định dạng";
            if (tb.IsNullOrEmpty()) temp = "Tên hàng không được để trống";
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
