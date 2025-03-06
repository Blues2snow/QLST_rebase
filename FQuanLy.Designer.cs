namespace QLST_rebase
{
    partial class FQuanLy
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
            panel1 = new Panel();
            btnDangXuat = new CuoreUI.Controls.cuiButton();
            btnQLTK = new CuoreUI.Controls.cuiButtonGroup();
            btnQLHH = new CuoreUI.Controls.cuiButtonGroup();
            cuiButtonGroup3 = new CuoreUI.Controls.cuiButtonGroup();
            cuiButtonGroup2 = new CuoreUI.Controls.cuiButtonGroup();
            btnQLNV = new CuoreUI.Controls.cuiButtonGroup();
            uC_qlnv1 = new UC_QLNV();
            uC_qltk1 = new UC_QLTK();
            uC_qlhh1 = new UC_QLHH();
            uC_tk1 = new UC_TK();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(btnQLTK);
            panel1.Controls.Add(btnQLHH);
            panel1.Controls.Add(cuiButtonGroup3);
            panel1.Controls.Add(cuiButtonGroup2);
            panel1.Controls.Add(btnQLNV);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 634);
            panel1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.CheckButton = false;
            btnDangXuat.Checked = false;
            btnDangXuat.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnDangXuat.CheckedForeColor = Color.White;
            btnDangXuat.CheckedImageTint = Color.White;
            btnDangXuat.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnDangXuat.Content = "Đăng xuất";
            btnDangXuat.DialogResult = DialogResult.None;
            btnDangXuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.HoverBackground = Color.FromArgb(200, 255, 106, 0);
            btnDangXuat.HoveredImageTint = Color.White;
            btnDangXuat.HoverForeColor = Color.White;
            btnDangXuat.HoverOutline = Color.Empty;
            btnDangXuat.Image = null;
            btnDangXuat.ImageAutoCenter = true;
            btnDangXuat.ImageExpand = new Point(0, 0);
            btnDangXuat.ImageOffset = new Point(0, 0);
            btnDangXuat.ImageTint = Color.White;
            btnDangXuat.Location = new Point(12, 526);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.NormalBackground = Color.FromArgb(255, 106, 0);
            btnDangXuat.NormalOutline = Color.Empty;
            btnDangXuat.OutlineThickness = 1.6F;
            btnDangXuat.PressedBackground = Color.FromArgb(255, 106, 0);
            btnDangXuat.PressedForeColor = Color.White;
            btnDangXuat.PressedImageTint = Color.White;
            btnDangXuat.PressedOutline = Color.Empty;
            btnDangXuat.Rounding = new Padding(8);
            btnDangXuat.Size = new Size(153, 45);
            btnDangXuat.TabIndex = 11;
            btnDangXuat.TextOffset = new Point(0, 0);
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnQLTK
            // 
            btnQLTK.Checked = false;
            btnQLTK.CheckedBackground = Color.White;
            btnQLTK.CheckedForeColor = Color.Blue;
            btnQLTK.CheckedImageTint = Color.Bisque;
            btnQLTK.CheckedOutline = Color.Transparent;
            btnQLTK.Content = "Quản lý tài khoản";
            btnQLTK.Font = new Font("Microsoft Sans Serif", 10F);
            btnQLTK.ForeColor = Color.Black;
            btnQLTK.Group = 0;
            btnQLTK.HoverBackground = Color.FromArgb(224, 224, 224);
            btnQLTK.HoveredImageTint = Color.Black;
            btnQLTK.HoverForeColor = Color.Black;
            btnQLTK.HoverOutline = Color.Empty;
            btnQLTK.Image = null;
            btnQLTK.ImageAutoCenter = true;
            btnQLTK.ImageExpand = new Point(0, 0);
            btnQLTK.ImageOffset = new Point(0, 0);
            btnQLTK.ImageTint = Color.Coral;
            btnQLTK.Location = new Point(0, 175);
            btnQLTK.Margin = new Padding(4, 3, 4, 3);
            btnQLTK.Name = "btnQLTK";
            btnQLTK.NormalBackground = Color.White;
            btnQLTK.NormalOutline = Color.Empty;
            btnQLTK.OutlineThickness = 1.6F;
            btnQLTK.PressedBackground = Color.White;
            btnQLTK.PressedForeColor = Color.Black;
            btnQLTK.PressedImageTint = Color.White;
            btnQLTK.PressedOutline = Color.Empty;
            btnQLTK.Rounding = new Padding(0);
            btnQLTK.Size = new Size(190, 45);
            btnQLTK.TabIndex = 10;
            btnQLTK.TextOffset = new Point(0, 0);
            btnQLTK.Click += btnQLTK_Click;
            // 
            // btnQLHH
            // 
            btnQLHH.Checked = false;
            btnQLHH.CheckedBackground = Color.White;
            btnQLHH.CheckedForeColor = Color.Blue;
            btnQLHH.CheckedImageTint = Color.Bisque;
            btnQLHH.CheckedOutline = Color.Transparent;
            btnQLHH.Content = "Quản lý hàng hoá";
            btnQLHH.Font = new Font("Microsoft Sans Serif", 10F);
            btnQLHH.ForeColor = Color.Black;
            btnQLHH.Group = 0;
            btnQLHH.HoverBackground = Color.FromArgb(224, 224, 224);
            btnQLHH.HoveredImageTint = Color.Black;
            btnQLHH.HoverForeColor = Color.Black;
            btnQLHH.HoverOutline = Color.Empty;
            btnQLHH.Image = null;
            btnQLHH.ImageAutoCenter = true;
            btnQLHH.ImageExpand = new Point(0, 0);
            btnQLHH.ImageOffset = new Point(0, 0);
            btnQLHH.ImageTint = Color.Coral;
            btnQLHH.Location = new Point(0, 219);
            btnQLHH.Margin = new Padding(4, 3, 4, 3);
            btnQLHH.Name = "btnQLHH";
            btnQLHH.NormalBackground = Color.White;
            btnQLHH.NormalOutline = Color.Empty;
            btnQLHH.OutlineThickness = 1.6F;
            btnQLHH.PressedBackground = Color.White;
            btnQLHH.PressedForeColor = Color.Black;
            btnQLHH.PressedImageTint = Color.White;
            btnQLHH.PressedOutline = Color.Empty;
            btnQLHH.Rounding = new Padding(0);
            btnQLHH.Size = new Size(190, 45);
            btnQLHH.TabIndex = 9;
            btnQLHH.TextOffset = new Point(0, 0);
            btnQLHH.Click += btnQLHH_Click;
            // 
            // cuiButtonGroup3
            // 
            cuiButtonGroup3.Checked = false;
            cuiButtonGroup3.CheckedBackground = Color.White;
            cuiButtonGroup3.CheckedForeColor = Color.Blue;
            cuiButtonGroup3.CheckedImageTint = Color.Bisque;
            cuiButtonGroup3.CheckedOutline = Color.Transparent;
            cuiButtonGroup3.Content = "Thống kê";
            cuiButtonGroup3.Font = new Font("Microsoft Sans Serif", 10F);
            cuiButtonGroup3.ForeColor = Color.Black;
            cuiButtonGroup3.Group = 0;
            cuiButtonGroup3.HoverBackground = Color.FromArgb(224, 224, 224);
            cuiButtonGroup3.HoveredImageTint = Color.Black;
            cuiButtonGroup3.HoverForeColor = Color.Black;
            cuiButtonGroup3.HoverOutline = Color.Empty;
            cuiButtonGroup3.Image = null;
            cuiButtonGroup3.ImageAutoCenter = true;
            cuiButtonGroup3.ImageExpand = new Point(0, 0);
            cuiButtonGroup3.ImageOffset = new Point(0, 0);
            cuiButtonGroup3.ImageTint = Color.Coral;
            cuiButtonGroup3.Location = new Point(0, 265);
            cuiButtonGroup3.Margin = new Padding(4, 3, 4, 3);
            cuiButtonGroup3.Name = "cuiButtonGroup3";
            cuiButtonGroup3.NormalBackground = Color.White;
            cuiButtonGroup3.NormalOutline = Color.Empty;
            cuiButtonGroup3.OutlineThickness = 1.6F;
            cuiButtonGroup3.PressedBackground = Color.White;
            cuiButtonGroup3.PressedForeColor = Color.Black;
            cuiButtonGroup3.PressedImageTint = Color.White;
            cuiButtonGroup3.PressedOutline = Color.Empty;
            cuiButtonGroup3.Rounding = new Padding(0);
            cuiButtonGroup3.Size = new Size(190, 45);
            cuiButtonGroup3.TabIndex = 8;
            cuiButtonGroup3.TextOffset = new Point(0, 0);
            // 
            // cuiButtonGroup2
            // 
            cuiButtonGroup2.Checked = false;
            cuiButtonGroup2.CheckedBackground = Color.White;
            cuiButtonGroup2.CheckedForeColor = Color.Blue;
            cuiButtonGroup2.CheckedImageTint = Color.Bisque;
            cuiButtonGroup2.CheckedOutline = Color.Transparent;
            cuiButtonGroup2.Content = "Tài khoản";
            cuiButtonGroup2.Font = new Font("Microsoft Sans Serif", 10F);
            cuiButtonGroup2.ForeColor = Color.Black;
            cuiButtonGroup2.Group = 0;
            cuiButtonGroup2.HoverBackground = Color.FromArgb(224, 224, 224);
            cuiButtonGroup2.HoveredImageTint = Color.Transparent;
            cuiButtonGroup2.HoverForeColor = Color.Black;
            cuiButtonGroup2.HoverOutline = Color.Empty;
            cuiButtonGroup2.Image = null;
            cuiButtonGroup2.ImageAutoCenter = true;
            cuiButtonGroup2.ImageExpand = new Point(0, 0);
            cuiButtonGroup2.ImageOffset = new Point(0, 0);
            cuiButtonGroup2.ImageTint = Color.Coral;
            cuiButtonGroup2.Location = new Point(0, 309);
            cuiButtonGroup2.Margin = new Padding(4, 3, 4, 3);
            cuiButtonGroup2.Name = "cuiButtonGroup2";
            cuiButtonGroup2.NormalBackground = Color.White;
            cuiButtonGroup2.NormalOutline = Color.Empty;
            cuiButtonGroup2.OutlineThickness = 1.6F;
            cuiButtonGroup2.PressedBackground = Color.White;
            cuiButtonGroup2.PressedForeColor = Color.Black;
            cuiButtonGroup2.PressedImageTint = Color.White;
            cuiButtonGroup2.PressedOutline = Color.Empty;
            cuiButtonGroup2.Rounding = new Padding(0);
            cuiButtonGroup2.Size = new Size(190, 45);
            cuiButtonGroup2.TabIndex = 7;
            cuiButtonGroup2.TextOffset = new Point(0, 0);
            cuiButtonGroup2.Click += cuiButtonGroup2_Click;
            // 
            // btnQLNV
            // 
            btnQLNV.Checked = true;
            btnQLNV.CheckedBackground = Color.White;
            btnQLNV.CheckedForeColor = Color.Blue;
            btnQLNV.CheckedImageTint = Color.Bisque;
            btnQLNV.CheckedOutline = Color.Transparent;
            btnQLNV.Content = "Quản lý nhân viên";
            btnQLNV.Font = new Font("Microsoft Sans Serif", 10F);
            btnQLNV.ForeColor = Color.Black;
            btnQLNV.Group = 0;
            btnQLNV.HoverBackground = Color.FromArgb(224, 224, 224);
            btnQLNV.HoveredImageTint = Color.Black;
            btnQLNV.HoverForeColor = Color.Black;
            btnQLNV.HoverOutline = Color.Empty;
            btnQLNV.Image = null;
            btnQLNV.ImageAutoCenter = true;
            btnQLNV.ImageExpand = new Point(0, 0);
            btnQLNV.ImageOffset = new Point(0, 0);
            btnQLNV.ImageTint = Color.Coral;
            btnQLNV.Location = new Point(0, 130);
            btnQLNV.Margin = new Padding(4, 3, 4, 3);
            btnQLNV.Name = "btnQLNV";
            btnQLNV.NormalBackground = Color.White;
            btnQLNV.NormalOutline = Color.Empty;
            btnQLNV.OutlineThickness = 1.6F;
            btnQLNV.PressedBackground = Color.White;
            btnQLNV.PressedForeColor = Color.Black;
            btnQLNV.PressedImageTint = Color.White;
            btnQLNV.PressedOutline = Color.Empty;
            btnQLNV.Rounding = new Padding(0);
            btnQLNV.Size = new Size(190, 45);
            btnQLNV.TabIndex = 6;
            btnQLNV.TextOffset = new Point(0, 0);
            btnQLNV.Click += btnQLNV_Click;
            // 
            // uC_qlnv1
            // 
            uC_qlnv1.Dock = DockStyle.Fill;
            uC_qlnv1.Location = new Point(190, 0);
            uC_qlnv1.Name = "uC_qlnv1";
            uC_qlnv1.Size = new Size(905, 634);
            uC_qlnv1.TabIndex = 1;
            // 
            // uC_qltk1
            // 
            uC_qltk1.Dock = DockStyle.Fill;
            uC_qltk1.Location = new Point(190, 0);
            uC_qltk1.Name = "uC_qltk1";
            uC_qltk1.Size = new Size(905, 634);
            uC_qltk1.TabIndex = 2;
            // 
            // uC_qlhh1
            // 
            uC_qlhh1.Dock = DockStyle.Fill;
            uC_qlhh1.Location = new Point(190, 0);
            uC_qlhh1.Name = "uC_qlhh1";
            uC_qlhh1.Size = new Size(905, 634);
            uC_qlhh1.TabIndex = 3;
            // 
            // uC_tk1
            // 
            uC_tk1.Dock = DockStyle.Fill;
            uC_tk1.Location = new Point(190, 0);
            uC_tk1.Name = "uC_tk1";
            uC_tk1.Size = new Size(905, 634);
            uC_tk1.TabIndex = 4;
            // 
            // FQuanLy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 634);
            Controls.Add(uC_qlnv1);
            Controls.Add(uC_tk1);
            Controls.Add(uC_qltk1);
            Controls.Add(uC_qlhh1);
            Controls.Add(panel1);
            Name = "FQuanLy";
            Text = "Quản lý";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CuoreUI.Controls.cuiButtonGroup btnQLNV;
        private CuoreUI.Controls.cuiButtonGroup btnQLTK;
        private CuoreUI.Controls.cuiButtonGroup btnQLHH;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup3;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup2;
        private CuoreUI.Controls.cuiButton btnDangXuat;
        private UC_QLNV uC_qlnv1;
        private UC_QLTK uC_qltk1;
        private UC_QLHH uC_qlhh1;
        private UC_TK uC_tk1;
    }
}