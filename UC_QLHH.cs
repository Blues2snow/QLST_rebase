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
    public partial class UC_QLHH : UserControl
    {
        public UC_QLHH()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }
        private void UC_QLHH_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToLongDateString();
            lbTime.Text = DateTime.Now.ToShortTimeString();
            LoadDgv();
        }

        private void dgvHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvHH.Columns[8].Index)
                {
                    FEditHH f = new();
                    f.getId(dgvHH.Rows[e.RowIndex].Cells[0].Value.ToString());
                    f.ShowDialog();
                    LoadDgv();
                }
                if (e.ColumnIndex == dgvHH.Columns[9].Index)
                {
                    using (DataDBContext context = new())
                    {
                        var goods = context.goodss.FirstOrDefault(p => p.goodsId == int.Parse(dgvHH.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        if (goods != null)
                        {
                            DialogResult temp = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xoá", MessageBoxButtons.YesNo);
                            if (temp == DialogResult.Yes)
                            {
                                context.goodss.Remove(goods);
                                context.SaveChanges();
                                MessageBox.Show("Đã xoá thành công!");
                                LoadDgv();
                            }
                        }
                    }
                }
            }
        }
        private void LoadDgv()
        {
            this.dgvHH.Rows.Clear();
            using (DataDBContext context = new())
            {
                this.dgvHH.Rows.Clear();
                List<goods> temp = context.goodss.ToList();
                foreach (goods item in temp)
                {
                    dgvHH.Rows.Insert(0, new object[] { item.goodsId, item.goodsName, item.entryDate, item.price, item.quantity, item.unit, item.suppiler, item.type });
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FAddHH f = new();
            f.ShowDialog();
            LoadDgv();
        }
        private void txtSearch_ContentChanged(object sender, EventArgs e)
        {
            this.dgvHH.Rows.Clear();
            if (txtSearch.Content == "")
            {
                LoadDgv();
            }
            else
            {
                using (DataDBContext context = new())
                {
                    List<goods> temp = context.goodss.Where(p => p.goodsName.Contains(txtSearch.Content)).ToList();
                    foreach (goods item in temp)
                    {
                        dgvHH.Rows.Insert(0, new object[] { item.goodsId, item.goodsName, item.entryDate, item.price, item.quantity, item.unit, item.suppiler, item.type });
                    }
                }
            }
        }
    }
}
