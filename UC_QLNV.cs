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
    public partial class UC_QLNV : UserControl
    {
        public UC_QLNV()
        {
            InitializeComponent();
        }

        private void UC_QLNV_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToLongDateString();
            lbTime.Text = DateTime.Now.ToShortTimeString();
            LoadDgv();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FAddNV f = new();
            f.ShowDialog();
            LoadDgv();
        }
        private void LoadDgv()
        {
            this.dgvNV.Rows.Clear();
            using (DataDBContext context = new())
            {
                List<staff> temp = context.staffs.ToList();
                foreach (staff item in temp)
                {
                    dgvNV.Rows.Insert(0, new object[] { item.staffId, item.staffName, item.birthDate, item.gender, item.address, item.salary, item.email, item.phoneNumber, item.position });
                }
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvNV.Columns[9].Index)
                {
                    FEditNV f = new();
                    f.getId(dgvNV.Rows[e.RowIndex].Cells[0].Value.ToString());
                    f.ShowDialog();
                    LoadDgv();
                }
                if (e.ColumnIndex == dgvNV.Columns[10].Index)
                {
                    using (DataDBContext context = new())
                    {
                        var staff = context.staffs.FirstOrDefault(p => p.staffId == int.Parse(dgvNV.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        if (staff != null)
                        {
                            DialogResult temp = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xoá", MessageBoxButtons.YesNo);
                            if (temp == DialogResult.Yes)
                            {
                                context.staffs.Remove(staff);
                                context.SaveChanges();
                                MessageBox.Show("Đã xoá thành công!");
                                LoadDgv();
                            }
                        }
                    }
                }
            }
        }
        private void txtSearch_ContentChanged(object sender, EventArgs e)
        {
            this.dgvNV.Rows.Clear();
            if (txtSearch.Content == "")
            {
                LoadDgv();
            }
            else
            {
                using (DataDBContext context = new())
                {
                    List<staff> temp = context.staffs.Where(p => p.staffName.Contains(txtSearch.Content)).ToList();
                    foreach (staff item in temp)
                    {
                        dgvNV.Rows.Insert(0, new object[] { item.staffId, item.staffName, item.birthDate, item.gender, item.address, item.salary, item.email, item.phoneNumber, item.position });
                    }
                }
            }
        }
    }
}
