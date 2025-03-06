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
    public partial class FEditHH : Form
    {
        public FEditHH()
        {
            InitializeComponent();
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
                    dtNgayNhap.Value = DateTime.Parse(item.entryDate.ToString());
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
            using (DataDBContext context = new())
            {
                var goods = context.goodss.FirstOrDefault(p => p.goodsId == int.Parse(txtMaHang.Text));
                if (goods != null)
                {
                    goods.goodsName = txtTenHang.Text;
                    goods.entryDate = DateOnly.Parse(dtNgayNhap.Text);
                    goods.price = double.Parse(txtGiaTien.Text);
                    goods.quantity = NmrSoLuong.Value;
                    goods.unit = txtDonViTinh.Text;
                    goods.suppiler = txtNhaCC.Text;
                    goods.type = cbLoaiHang.Text;
                    context.SaveChanges();
                    MessageBox.Show("Sửa thành công!");
                }
            }
        }
    }
}
