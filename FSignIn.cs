using QLST_rebase.DTO;

namespace QLST_rebase
{
    public partial class FSignIn : Form
    {
        public FSignIn()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(50, Color.Black);
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            AccountTransfer accountTransfer = new AccountTransfer();
            //if (accountTransfer.CheckSignIn(txtAccount.Text, txtPassword.Text))
            if(true)
            {
                this.Hide();
                FQuanLy f = new();
                f.ShowDialog();
                Application.Exit();
            }
        }
        private void txtAccount_Enter(object sender, EventArgs e)
        {
            if (txtAccount.Text == "Vui lòng nhập tài khoản")
            {
                txtAccount.Text = "";
                txtAccount.ForeColor = Color.Black;
            }
        }

        private void txtAccount_Leave(object sender, EventArgs e)
        {
            if (txtAccount.Text == "")
            {
                txtAccount.Text = "Vui lòng nhập tài khoản";
                txtAccount.ForeColor = Color.DimGray;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Vui lòng nhập mật khẩu")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Vui lòng nhập mật khẩu";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
