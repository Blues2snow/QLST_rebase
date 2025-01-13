namespace QLST_rebase
{
    partial class FSignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtPassword = new Krypton.Toolkit.KryptonTextBox();
            txtAccount = new Krypton.Toolkit.KryptonTextBox();
            btnExit = new CuoreUI.Controls.cuiButton();
            btnSignin = new CuoreUI.Controls.cuiButton();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtAccount);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSignin);
            panel1.Controls.Add(cuiLabel2);
            panel1.Controls.Add(cuiLabel1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(398, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 450);
            panel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(57, 264);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(286, 34);
            txtPassword.StateActive.Border.Color1 = Color.Black;
            txtPassword.StateActive.Border.Color2 = Color.Black;
            txtPassword.StateActive.Border.ColorAngle = 1F;
            txtPassword.StateActive.Border.Rounding = 12F;
            txtPassword.StateActive.Border.Width = 1;
            txtPassword.StateActive.Content.Color1 = Color.DimGray;
            txtPassword.StateActive.Content.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.StateCommon.Border.Color1 = Color.Black;
            txtPassword.StateCommon.Border.Color2 = Color.Black;
            txtPassword.StateCommon.Border.Rounding = 12F;
            txtPassword.StateCommon.Border.Width = 1;
            txtPassword.StateDisabled.Border.Color1 = Color.Black;
            txtPassword.StateDisabled.Border.Rounding = 10F;
            txtPassword.StateDisabled.Border.Width = 1;
            txtPassword.StateNormal.Border.Color1 = Color.Black;
            txtPassword.StateNormal.Border.Rounding = 12F;
            txtPassword.StateNormal.Border.Width = 1;
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Vui lòng nhập mật khẩu";
            txtPassword.Enter += txtPassword_Enter;
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(57, 182);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(286, 34);
            txtAccount.StateActive.Border.Color1 = Color.Black;
            txtAccount.StateActive.Border.Color2 = Color.Black;
            txtAccount.StateActive.Border.ColorAngle = 1F;
            txtAccount.StateActive.Border.Rounding = 12F;
            txtAccount.StateActive.Border.Width = 1;
            txtAccount.StateActive.Content.Color1 = Color.DimGray;
            txtAccount.StateActive.Content.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAccount.StateCommon.Border.Color1 = Color.Black;
            txtAccount.StateCommon.Border.Color2 = Color.Black;
            txtAccount.StateCommon.Border.Rounding = 12F;
            txtAccount.StateCommon.Border.Width = 1;
            txtAccount.StateDisabled.Border.Color1 = Color.Black;
            txtAccount.StateDisabled.Border.Rounding = 10F;
            txtAccount.StateDisabled.Border.Width = 1;
            txtAccount.StateNormal.Border.Color1 = Color.Black;
            txtAccount.StateNormal.Border.Rounding = 12F;
            txtAccount.StateNormal.Border.Width = 1;
            txtAccount.TabIndex = 1;
            txtAccount.Text = "Vui lòng nhập tài khoản";
            txtAccount.Enter += txtAccount_Enter;
            txtAccount.Leave += txtAccount_Leave;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.CheckButton = false;
            btnExit.Checked = false;
            btnExit.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnExit.CheckedForeColor = Color.White;
            btnExit.CheckedImageTint = Color.White;
            btnExit.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnExit.Content = "Thoát";
            btnExit.DialogResult = DialogResult.None;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.HoverBackground = Color.FromArgb(200, 255, 106, 0);
            btnExit.HoveredImageTint = Color.White;
            btnExit.HoverForeColor = Color.White;
            btnExit.HoverOutline = Color.Empty;
            btnExit.Image = null;
            btnExit.ImageAutoCenter = true;
            btnExit.ImageExpand = new Point(0, 0);
            btnExit.ImageOffset = new Point(0, 0);
            btnExit.ImageTint = Color.White;
            btnExit.Location = new Point(230, 343);
            btnExit.Name = "btnExit";
            btnExit.NormalBackground = Color.FromArgb(255, 106, 0);
            btnExit.NormalOutline = Color.Empty;
            btnExit.OutlineThickness = 1.6F;
            btnExit.PressedBackground = Color.FromArgb(255, 106, 0);
            btnExit.PressedForeColor = Color.White;
            btnExit.PressedImageTint = Color.White;
            btnExit.PressedOutline = Color.Empty;
            btnExit.Rounding = new Padding(16);
            btnExit.Size = new Size(113, 42);
            btnExit.TabIndex = 3;
            btnExit.TextOffset = new Point(0, 0);
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.Transparent;
            btnSignin.CheckButton = false;
            btnSignin.Checked = false;
            btnSignin.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnSignin.CheckedForeColor = Color.White;
            btnSignin.CheckedImageTint = Color.White;
            btnSignin.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnSignin.Content = "Đăng nhập";
            btnSignin.DialogResult = DialogResult.None;
            btnSignin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSignin.ForeColor = Color.White;
            btnSignin.HoverBackground = Color.FromArgb(200, 255, 106, 0);
            btnSignin.HoveredImageTint = Color.White;
            btnSignin.HoverForeColor = Color.White;
            btnSignin.HoverOutline = Color.Empty;
            btnSignin.Image = null;
            btnSignin.ImageAutoCenter = true;
            btnSignin.ImageExpand = new Point(0, 0);
            btnSignin.ImageOffset = new Point(0, 0);
            btnSignin.ImageTint = Color.White;
            btnSignin.Location = new Point(57, 343);
            btnSignin.Name = "btnSignin";
            btnSignin.NormalBackground = Color.FromArgb(255, 106, 0);
            btnSignin.NormalOutline = Color.Empty;
            btnSignin.OutlineThickness = 1.6F;
            btnSignin.PressedBackground = Color.FromArgb(255, 106, 0);
            btnSignin.PressedForeColor = Color.White;
            btnSignin.PressedImageTint = Color.White;
            btnSignin.PressedOutline = Color.Empty;
            btnSignin.Rounding = new Padding(16);
            btnSignin.Size = new Size(113, 42);
            btnSignin.TabIndex = 2;
            btnSignin.TextOffset = new Point(0, 0);
            btnSignin.Click += btnSignin_Click;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Xin\\ vui\\ lòng\\ đăng\\ nhập\\ để\\ tiếp\\ tục";
            cuiLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            cuiLabel2.Location = new Point(57, 109);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(286, 41);
            cuiLabel2.TabIndex = 3;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Xin\\ chào!";
            cuiLabel1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            cuiLabel1.Location = new Point(57, 62);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(286, 41);
            cuiLabel1.TabIndex = 2;
            // 
            // FSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FSignIn";
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CuoreUI.Controls.cuiButton btnExit;
        private CuoreUI.Controls.cuiButton btnSignin;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Krypton.Toolkit.KryptonTextBox txtAccount;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
    }
}
