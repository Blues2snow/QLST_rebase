namespace QLST_rebase
{
    partial class FAddNV
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
            txtSDT = new Krypton.Toolkit.KryptonTextBox();
            cbGioiTinh = new ReaLTaiizor.Controls.AloneComboBox();
            cbChucVu = new ReaLTaiizor.Controls.AloneComboBox();
            txtTenNV = new Krypton.Toolkit.KryptonTextBox();
            txtLuong = new Krypton.Toolkit.KryptonTextBox();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            cuiLabel7 = new CuoreUI.Controls.cuiLabel();
            cuiLabel8 = new CuoreUI.Controls.cuiLabel();
            txtDiaChi = new Krypton.Toolkit.KryptonTextBox();
            btnConfirm = new CuoreUI.Controls.cuiButton();
            dtNgaySinh = new DateTimePicker();
            SuspendLayout();
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(526, 180);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(190, 25);
            txtSDT.StateActive.Content.Color1 = Color.Black;
            txtSDT.StateActive.Content.Font = new Font("Segoe UI", 10F);
            txtSDT.TabIndex = 7;
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.BackColor = Color.White;
            cbGioiTinh.DrawMode = DrawMode.OwnerDrawFixed;
            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioiTinh.EnabledCalc = true;
            cbGioiTinh.ForeColor = Color.Black;
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.ItemHeight = 20;
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioiTinh.Location = new Point(181, 180);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(190, 26);
            cbGioiTinh.TabIndex = 3;
            // 
            // cbChucVu
            // 
            cbChucVu.BackColor = Color.White;
            cbChucVu.DrawMode = DrawMode.OwnerDrawFixed;
            cbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChucVu.EnabledCalc = true;
            cbChucVu.ForeColor = Color.Black;
            cbChucVu.FormattingEnabled = true;
            cbChucVu.ItemHeight = 20;
            cbChucVu.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cbChucVu.Location = new Point(526, 241);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new Size(190, 26);
            cbChucVu.TabIndex = 8;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(181, 54);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(190, 25);
            txtTenNV.StateActive.Content.Color1 = Color.Black;
            txtTenNV.StateActive.Content.Font = new Font("Segoe UI", 10F);
            txtTenNV.TabIndex = 1;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(526, 54);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(190, 25);
            txtLuong.StateActive.Content.Color1 = Color.Black;
            txtLuong.StateActive.Content.Font = new Font("Segoe UI", 10F);
            txtLuong.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(526, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(190, 25);
            txtEmail.StateActive.Content.Color1 = Color.Black;
            txtEmail.StateActive.Content.Font = new Font("Segoe UI", 10F);
            txtEmail.TabIndex = 6;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "SDT";
            cuiLabel1.Font = new Font("Segoe UI", 12F);
            cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel1.Location = new Point(409, 177);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(78, 28);
            cuiLabel1.TabIndex = 18;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Chức\\ vụ";
            cuiLabel2.Font = new Font("Segoe UI", 12F);
            cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel2.Location = new Point(409, 239);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(78, 28);
            cuiLabel2.TabIndex = 19;
            // 
            // cuiLabel3
            // 
            cuiLabel3.Content = "Email";
            cuiLabel3.Font = new Font("Segoe UI", 12F);
            cuiLabel3.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel3.Location = new Point(409, 112);
            cuiLabel3.Margin = new Padding(4, 3, 4, 3);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(78, 28);
            cuiLabel3.TabIndex = 20;
            // 
            // cuiLabel4
            // 
            cuiLabel4.Content = "Lương";
            cuiLabel4.Font = new Font("Segoe UI", 12F);
            cuiLabel4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel4.Location = new Point(409, 51);
            cuiLabel4.Margin = new Padding(4, 3, 4, 3);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(78, 28);
            cuiLabel4.TabIndex = 21;
            // 
            // cuiLabel5
            // 
            cuiLabel5.Content = "Địa\\ chỉ";
            cuiLabel5.Font = new Font("Segoe UI", 12F);
            cuiLabel5.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel5.Location = new Point(29, 238);
            cuiLabel5.Margin = new Padding(4, 3, 4, 3);
            cuiLabel5.Name = "cuiLabel5";
            cuiLabel5.Size = new Size(117, 28);
            cuiLabel5.TabIndex = 22;
            // 
            // cuiLabel6
            // 
            cuiLabel6.Content = "Giới\\ tính";
            cuiLabel6.Font = new Font("Segoe UI", 12F);
            cuiLabel6.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel6.Location = new Point(29, 178);
            cuiLabel6.Margin = new Padding(4, 3, 4, 3);
            cuiLabel6.Name = "cuiLabel6";
            cuiLabel6.Size = new Size(117, 28);
            cuiLabel6.TabIndex = 23;
            // 
            // cuiLabel7
            // 
            cuiLabel7.Content = "Ngày\\ sinh";
            cuiLabel7.Font = new Font("Segoe UI", 12F);
            cuiLabel7.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel7.Location = new Point(29, 116);
            cuiLabel7.Margin = new Padding(4, 3, 4, 3);
            cuiLabel7.Name = "cuiLabel7";
            cuiLabel7.Size = new Size(117, 28);
            cuiLabel7.TabIndex = 24;
            // 
            // cuiLabel8
            // 
            cuiLabel8.Content = "Tên\\ nhân\\ viên";
            cuiLabel8.Font = new Font("Segoe UI", 12F);
            cuiLabel8.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel8.Location = new Point(29, 51);
            cuiLabel8.Margin = new Padding(4, 3, 4, 3);
            cuiLabel8.Name = "cuiLabel8";
            cuiLabel8.Size = new Size(117, 28);
            cuiLabel8.TabIndex = 25;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(181, 241);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(190, 25);
            txtDiaChi.StateActive.Content.Color1 = Color.Black;
            txtDiaChi.StateActive.Content.Font = new Font("Segoe UI", 10F);
            txtDiaChi.TabIndex = 4;
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
            btnConfirm.Location = new Point(526, 312);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.NormalBackground = Color.FromArgb(255, 106, 0);
            btnConfirm.NormalOutline = Color.Empty;
            btnConfirm.OutlineThickness = 1.6F;
            btnConfirm.PressedBackground = Color.FromArgb(255, 106, 0);
            btnConfirm.PressedForeColor = Color.White;
            btnConfirm.PressedImageTint = Color.White;
            btnConfirm.PressedOutline = Color.Empty;
            btnConfirm.Rounding = new Padding(8);
            btnConfirm.Size = new Size(159, 36);
            btnConfirm.TabIndex = 9;
            btnConfirm.TextOffset = new Point(0, 0);
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Font = new Font("Segoe UI", 10F);
            dtNgaySinh.Format = DateTimePickerFormat.Custom;
            dtNgaySinh.Location = new Point(181, 115);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(190, 25);
            dtNgaySinh.TabIndex = 2;
            dtNgaySinh.Value = new DateTime(2025, 3, 8, 0, 0, 0, 0);
            // 
            // FAddNV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(dtNgaySinh);
            Controls.Add(btnConfirm);
            Controls.Add(txtDiaChi);
            Controls.Add(cuiLabel8);
            Controls.Add(cuiLabel7);
            Controls.Add(cuiLabel6);
            Controls.Add(cuiLabel5);
            Controls.Add(cuiLabel4);
            Controls.Add(cuiLabel3);
            Controls.Add(cuiLabel2);
            Controls.Add(cuiLabel1);
            Controls.Add(txtEmail);
            Controls.Add(txtLuong);
            Controls.Add(txtTenNV);
            Controls.Add(cbChucVu);
            Controls.Add(cbGioiTinh);
            Controls.Add(txtSDT);
            Name = "FAddNV";
            Text = "Thêm nhân viên";
            Load += FAddNV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtSDT;
        private ReaLTaiizor.Controls.AloneComboBox cbGioiTinh;
        private ReaLTaiizor.Controls.AloneComboBox cbChucVu;
        private Krypton.Toolkit.KryptonTextBox txtTenNV;
        private Krypton.Toolkit.KryptonTextBox txtLuong;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private CuoreUI.Controls.cuiLabel cuiLabel7;
        private CuoreUI.Controls.cuiLabel cuiLabel8;
        private Krypton.Toolkit.KryptonTextBox txtDiaChi;
        private CuoreUI.Controls.cuiButton btnConfirm;
        private DateTimePicker dtNgaySinh;
    }
}