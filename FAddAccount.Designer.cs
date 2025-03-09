namespace QLST_rebase
{
    partial class FAddAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            btnConfirm = new CuoreUI.Controls.cuiButton();
            cbMaNV = new ReaLTaiizor.Controls.AloneComboBox();
            txtTaiKhoan = new Krypton.Toolkit.KryptonTextBox();
            txtMatKhau = new Krypton.Toolkit.KryptonTextBox();
            txtMatKhau2 = new Krypton.Toolkit.KryptonTextBox();
            SuspendLayout();
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Mã\\ nhân\\ viên:";
            cuiLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel1.Location = new Point(53, 56);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(122, 26);
            cuiLabel1.TabIndex = 0;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Tài\\ khoản:";
            cuiLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel2.Location = new Point(82, 117);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(93, 26);
            cuiLabel2.TabIndex = 1;
            cuiLabel2.TabStop = false;
            // 
            // cuiLabel3
            // 
            cuiLabel3.Content = "Nhập\\ lại\\ mật\\ khẩu:";
            cuiLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel3.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel3.Location = new Point(16, 242);
            cuiLabel3.Margin = new Padding(4, 3, 4, 3);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(159, 26);
            cuiLabel3.TabIndex = 2;
            cuiLabel3.TabStop = false;
            // 
            // cuiLabel4
            // 
            cuiLabel4.Content = "Mật\\ khẩu:";
            cuiLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel4.Location = new Point(82, 177);
            cuiLabel4.Margin = new Padding(4, 3, 4, 3);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(93, 26);
            cuiLabel4.TabIndex = 3;
            cuiLabel4.TabStop = false;
            // 
            // btnConfirm
            // 
            btnConfirm.CheckButton = false;
            btnConfirm.Checked = false;
            btnConfirm.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnConfirm.CheckedForeColor = Color.White;
            btnConfirm.CheckedImageTint = Color.White;
            btnConfirm.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnConfirm.Content = "Xác nhận";
            btnConfirm.DialogResult = DialogResult.None;
            btnConfirm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.HoverBackground = Color.FromArgb(200, 255, 106, 0);
            btnConfirm.HoveredImageTint = Color.White;
            btnConfirm.HoverForeColor = Color.White;
            btnConfirm.HoverOutline = Color.Empty;
            btnConfirm.Image = null;
            btnConfirm.ImageAutoCenter = true;
            btnConfirm.ImageExpand = new Point(0, 0);
            btnConfirm.ImageOffset = new Point(0, 0);
            btnConfirm.ImageTint = Color.White;
            btnConfirm.Location = new Point(427, 302);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.NormalBackground = Color.FromArgb(255, 106, 0);
            btnConfirm.NormalOutline = Color.Empty;
            btnConfirm.OutlineThickness = 1.6F;
            btnConfirm.PressedBackground = Color.FromArgb(255, 106, 0);
            btnConfirm.PressedForeColor = Color.White;
            btnConfirm.PressedImageTint = Color.White;
            btnConfirm.PressedOutline = Color.Empty;
            btnConfirm.Rounding = new Padding(8);
            btnConfirm.Size = new Size(136, 36);
            btnConfirm.TabIndex = 10;
            btnConfirm.TextOffset = new Point(0, 0);
            btnConfirm.Click += btnConfirm_Click;
            // 
            // cbMaNV
            // 
            cbMaNV.BackColor = Color.White;
            cbMaNV.DrawMode = DrawMode.OwnerDrawFixed;
            cbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaNV.EnabledCalc = true;
            cbMaNV.ForeColor = Color.Black;
            cbMaNV.FormattingEnabled = true;
            cbMaNV.ItemHeight = 20;
            cbMaNV.Location = new Point(198, 56);
            cbMaNV.Name = "cbMaNV";
            cbMaNV.Size = new Size(286, 26);
            cbMaNV.TabIndex = 1;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(198, 118);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(286, 25);
            txtTaiKhoan.StateActive.Content.Color1 = Color.Black;
            txtTaiKhoan.StateActive.Content.Font = new Font("Segoe UI", 10F);
            txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(198, 178);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(286, 25);
            txtMatKhau.StateActive.Content.Color1 = Color.Black;
            txtMatKhau.StateActive.Content.Font = new Font("Segoe UI", 10F);
            txtMatKhau.TabIndex = 3;
            // 
            // txtMatKhau2
            // 
            txtMatKhau2.Location = new Point(198, 243);
            txtMatKhau2.Name = "txtMatKhau2";
            txtMatKhau2.Size = new Size(286, 25);
            txtMatKhau2.StateActive.Content.Color1 = Color.Black;
            txtMatKhau2.StateActive.Content.Font = new Font("Segoe UI", 10F);
            txtMatKhau2.TabIndex = 4;
            // 
            // FAddAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 359);
            Controls.Add(txtMatKhau2);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(cbMaNV);
            Controls.Add(btnConfirm);
            Controls.Add(cuiLabel4);
            Controls.Add(cuiLabel3);
            Controls.Add(cuiLabel2);
            Controls.Add(cuiLabel1);
            Name = "FAddAccount";
            Text = "Thêm tài khoản";
            Load += FAddAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiButton btnConfirm;
        private ReaLTaiizor.Controls.AloneComboBox cbMaNV;
        private Krypton.Toolkit.KryptonTextBox txtTaiKhoan;
        private Krypton.Toolkit.KryptonTextBox txtMatKhau;
        private Krypton.Toolkit.KryptonTextBox txtMatKhau2;
    }
}