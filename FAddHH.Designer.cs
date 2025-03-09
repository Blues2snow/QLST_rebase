namespace QLST_rebase
{
    partial class FAddHH
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
            btnConfirm = new CuoreUI.Controls.cuiButton();
            txtGiaTien = new Krypton.Toolkit.KryptonTextBox();
            cuiLabel8 = new CuoreUI.Controls.cuiLabel();
            cuiLabel7 = new CuoreUI.Controls.cuiLabel();
            cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            txtDonViTinh = new Krypton.Toolkit.KryptonTextBox();
            txtTenHang = new Krypton.Toolkit.KryptonTextBox();
            cbLoaiHang = new ReaLTaiizor.Controls.AloneComboBox();
            txtNhaCC = new Krypton.Toolkit.KryptonTextBox();
            dtNgayNhap = new DateTimePicker();
            NmrSoLuong = new Krypton.Toolkit.KryptonNumericUpDown();
            SuspendLayout();
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
            btnConfirm.Location = new Point(552, 240);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.NormalBackground = Color.FromArgb(255, 106, 0);
            btnConfirm.NormalOutline = Color.Empty;
            btnConfirm.OutlineThickness = 1.6F;
            btnConfirm.PressedBackground = Color.FromArgb(255, 106, 0);
            btnConfirm.PressedForeColor = Color.White;
            btnConfirm.PressedImageTint = Color.White;
            btnConfirm.PressedOutline = Color.Empty;
            btnConfirm.Rounding = new Padding(8);
            btnConfirm.Size = new Size(156, 36);
            btnConfirm.TabIndex = 8;
            btnConfirm.TextOffset = new Point(0, 0);
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(176, 181);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(190, 25);
            txtGiaTien.StateActive.Content.Color1 = Color.Black;
            txtGiaTien.StateActive.Content.Font = new Font("Segoe UI", 10F);
            txtGiaTien.TabIndex = 3;
            // 
            // cuiLabel8
            // 
            cuiLabel8.Content = "Tên\\ hàng";
            cuiLabel8.Font = new Font("Segoe UI", 12F);
            cuiLabel8.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel8.Location = new Point(22, 54);
            cuiLabel8.Margin = new Padding(4, 3, 4, 3);
            cuiLabel8.Name = "cuiLabel8";
            cuiLabel8.Size = new Size(122, 28);
            cuiLabel8.TabIndex = 44;
            // 
            // cuiLabel7
            // 
            cuiLabel7.Content = "Ngày\\ nhập";
            cuiLabel7.Font = new Font("Segoe UI", 12F);
            cuiLabel7.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel7.Location = new Point(22, 119);
            cuiLabel7.Margin = new Padding(4, 3, 4, 3);
            cuiLabel7.Name = "cuiLabel7";
            cuiLabel7.Size = new Size(122, 28);
            cuiLabel7.TabIndex = 43;
            // 
            // cuiLabel5
            // 
            cuiLabel5.Content = "Giá\\ tiền";
            cuiLabel5.Font = new Font("Segoe UI", 12F);
            cuiLabel5.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel5.Location = new Point(22, 178);
            cuiLabel5.Margin = new Padding(4, 3, 4, 3);
            cuiLabel5.Name = "cuiLabel5";
            cuiLabel5.Size = new Size(122, 28);
            cuiLabel5.TabIndex = 41;
            // 
            // cuiLabel4
            // 
            cuiLabel4.Content = "Số\\ lượng";
            cuiLabel4.Font = new Font("Segoe UI", 12F);
            cuiLabel4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel4.Location = new Point(399, 54);
            cuiLabel4.Margin = new Padding(4, 3, 4, 3);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(146, 28);
            cuiLabel4.TabIndex = 40;
            // 
            // cuiLabel3
            // 
            cuiLabel3.Content = "Đơn\\ vị\\ tính";
            cuiLabel3.Font = new Font("Segoe UI", 12F);
            cuiLabel3.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel3.Location = new Point(399, 115);
            cuiLabel3.Margin = new Padding(4, 3, 4, 3);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(146, 28);
            cuiLabel3.TabIndex = 39;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Loại\\ hàng";
            cuiLabel2.Font = new Font("Segoe UI", 12F);
            cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel2.Location = new Point(399, 178);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(146, 28);
            cuiLabel2.TabIndex = 38;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Nhà\\ cung\\ cấp";
            cuiLabel1.Font = new Font("Segoe UI", 12F);
            cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            cuiLabel1.Location = new Point(22, 240);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(146, 28);
            cuiLabel1.TabIndex = 37;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Location = new Point(552, 114);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(190, 25);
            txtDonViTinh.StateActive.Content.Color1 = Color.Black;
            txtDonViTinh.StateActive.Content.Font = new Font("Segoe UI", 10F);
            txtDonViTinh.TabIndex = 6;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(176, 57);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(190, 25);
            txtTenHang.StateActive.Content.Color1 = Color.Black;
            txtTenHang.StateActive.Content.Font = new Font("Segoe UI", 10F);
            txtTenHang.TabIndex = 1;
            // 
            // cbLoaiHang
            // 
            cbLoaiHang.BackColor = Color.White;
            cbLoaiHang.DrawMode = DrawMode.OwnerDrawFixed;
            cbLoaiHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiHang.EnabledCalc = true;
            cbLoaiHang.ForeColor = Color.Black;
            cbLoaiHang.FormattingEnabled = true;
            cbLoaiHang.ItemHeight = 20;
            cbLoaiHang.Items.AddRange(new object[] { "Thực phẩm", "Hoá phẩm" });
            cbLoaiHang.Location = new Point(552, 176);
            cbLoaiHang.Name = "cbLoaiHang";
            cbLoaiHang.Size = new Size(190, 26);
            cbLoaiHang.TabIndex = 7;
            // 
            // txtNhaCC
            // 
            txtNhaCC.Location = new Point(175, 239);
            txtNhaCC.Name = "txtNhaCC";
            txtNhaCC.Size = new Size(190, 25);
            txtNhaCC.StateActive.Content.Color1 = Color.Black;
            txtNhaCC.StateActive.Content.Font = new Font("Segoe UI", 10F);
            txtNhaCC.TabIndex = 4;
            // 
            // dtNgayNhap
            // 
            dtNgayNhap.Font = new Font("Segoe UI", 10F);
            dtNgayNhap.Format = DateTimePickerFormat.Custom;
            dtNgayNhap.Location = new Point(176, 121);
            dtNgayNhap.Name = "dtNgayNhap";
            dtNgayNhap.Size = new Size(190, 25);
            dtNgayNhap.TabIndex = 2;
            dtNgayNhap.Value = new DateTime(2025, 3, 8, 0, 0, 0, 0);
            // 
            // NmrSoLuong
            // 
            NmrSoLuong.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            NmrSoLuong.Location = new Point(552, 54);
            NmrSoLuong.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            NmrSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NmrSoLuong.Name = "NmrSoLuong";
            NmrSoLuong.Size = new Size(190, 25);
            NmrSoLuong.StateActive.Content.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NmrSoLuong.StateActive.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            NmrSoLuong.TabIndex = 5;
            NmrSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FAddHH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 342);
            Controls.Add(NmrSoLuong);
            Controls.Add(dtNgayNhap);
            Controls.Add(btnConfirm);
            Controls.Add(txtGiaTien);
            Controls.Add(cuiLabel8);
            Controls.Add(cuiLabel7);
            Controls.Add(cuiLabel5);
            Controls.Add(cuiLabel4);
            Controls.Add(cuiLabel3);
            Controls.Add(cuiLabel2);
            Controls.Add(cuiLabel1);
            Controls.Add(txtDonViTinh);
            Controls.Add(txtTenHang);
            Controls.Add(cbLoaiHang);
            Controls.Add(txtNhaCC);
            Name = "FAddHH";
            Text = "Thêm hàng";
            Load += FAddHH_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiButton btnConfirm;
        private Krypton.Toolkit.KryptonTextBox txtGiaTien;
        private CuoreUI.Controls.cuiLabel cuiLabel8;
        private CuoreUI.Controls.cuiLabel cuiLabel7;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Krypton.Toolkit.KryptonTextBox txtDonViTinh;
        private Krypton.Toolkit.KryptonTextBox txtTenHang;
        private ReaLTaiizor.Controls.AloneComboBox cbLoaiHang;
        private Krypton.Toolkit.KryptonTextBox txtNhaCC;
        private DateTimePicker dtNgayNhap;
        private Krypton.Toolkit.KryptonNumericUpDown NmrSoLuong;
    }
}