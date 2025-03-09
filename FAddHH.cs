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
    public partial class FAddHH : Form
    {
        public FAddHH()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataDBContext context = new())
                {
                    var goods = new goods
                    {
                        goodsName = txtTenHang.Text,
                        entryDate = DateOnly.Parse(dtNgayNhap.Text),
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
    }
}
