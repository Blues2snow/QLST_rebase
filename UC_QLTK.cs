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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QLST_rebase
{
    public partial class UC_QLTK : UserControl
    {
        public UC_QLTK()
        {
            InitializeComponent();
        }

        private void UC_QLTK_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToShortDateString();
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
            FAddAccount f = new();
            f.ShowDialog();
            LoadDgv();
        }
        private void LoadDgv()
        {
            this.dgvTK.Rows.Clear();
            using (DataDBContext context = new())
            {
                List<account> temp = context.accounts.ToList();
                foreach (account item in temp)
                {
                    dgvTK.Rows.Insert(0, new object[] { item._account, item._password, item.staffId });
                }
            }
        }

        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvTK.Columns[3].Index)
                {
                    using (DataDBContext context = new())
                    {
                        var account = context.accounts.FirstOrDefault(p => p.staffId == int.Parse(dgvTK.Rows[e.RowIndex].Cells[2].Value.ToString()));
                        if (account != null)
                        {
                            DialogResult temp = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xoá", MessageBoxButtons.YesNo);
                            if (temp == DialogResult.Yes)
                            {
                                context.accounts.Remove(account);
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
            this.dgvTK.Rows.Clear();
            if (txtSearch.Content == "")
            {
                LoadDgv();
            }
            else
            {
                using (DataDBContext context = new())
                {
                    List<account> temp = context.accounts.Where(p => p._account.Contains(txtSearch.Content)).ToList();
                    foreach (account item in temp)
                    {
                        dgvTK.Rows.Insert(0, new object[] { item._account, item._password, item.staffId });
                    }
                }
            }
        }
    }
}
