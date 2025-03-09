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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            try //1
            {
                using (DataDBContext context = new()) //2
                {
                    var staff = new staff //3
                    {
                        staffName = txtTenNV.Text,
                        birthDate = DateOnly.Parse(dtNgaySinh.Text), //4
                        gender = cbGioiTinh.Text,
                        address = txtDiaChi.Text,
                        salary = double.Parse(txtLuong.Text), //5
                        email = txtEmail.Text,
                        phoneNumber = txtSDT.Text,
                        position = cbChucVu.Text //6 (cac text)
                    };
                    context.staffs.Add(staff); //7
                    context.SaveChanges();//8
                    MessageBox.Show("Thêm thành công!");     //9  
                }
            }
            catch (Exception) //10
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin"); //11
            }
        }

        private void add_NV(string TenNV, string BirthDate, string gender, string addres, string salary, string email, string phonenumber, string position)
        {
            try //1
            {
                using (DataDBContext context = new()) //2
                {
                    var staff = new staff //3
                    {
                        staffName = TenNV,
                        birthDate = DateOnly.Parse(BirthDate), //4
                        gender = gender,
                        address = addres,
                        salary = double.Parse(salary), //5
                        email = email,
                        phoneNumber = phonenumber,
                        position = position //6 (cac text)
                    };
                    context.staffs.Add(staff); //7
                    context.SaveChanges();//8
                    MessageBox.Show("Thêm thành công!");     //9  
                }
            }
            catch (Exception) //10
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin"); //11
            }
        }

        private void FAddNV_Load(object sender, EventArgs e)
        {
            cbGioiTinh.SelectedItem = "Nam";
            cbChucVu.SelectedItem = "Quản lý";
        }
    }
}
