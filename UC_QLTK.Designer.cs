namespace QLST_rebase
{
    partial class UC_QLTK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            lbTime = new CuoreUI.Controls.cuiLabel();
            lbDate = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            txtSearch = new CuoreUI.Controls.cuiTextBox2();
            btnAdd = new CuoreUI.Controls.cuiButton();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            dgvTK = new ReaLTaiizor.Controls.PoisonDataGridView();
            _account = new DataGridViewTextBoxColumn();
            _password = new DataGridViewTextBoxColumn();
            staffId = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTK).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.icons8_search_26;
            pictureBox1.Location = new Point(626, 105);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // lbTime
            // 
            lbTime.Content = "N/A";
            lbTime.Font = new Font("Segoe UI", 12F);
            lbTime.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            lbTime.Location = new Point(729, 50);
            lbTime.Margin = new Padding(4, 3, 4, 3);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(172, 27);
            lbTime.TabIndex = 15;
            // 
            // lbDate
            // 
            lbDate.Content = "N/A";
            lbDate.Font = new Font("Segoe UI", 12F);
            lbDate.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            lbDate.Location = new Point(729, 17);
            lbDate.Margin = new Padding(4, 3, 4, 3);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(172, 27);
            lbDate.TabIndex = 14;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Hôm\\ nay\\ là:";
            cuiLabel2.Font = new Font("Segoe UI", 12F);
            cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            cuiLabel2.Location = new Point(617, 17);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(104, 27);
            cuiLabel2.TabIndex = 13;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderColor = Color.FromArgb(64, 64, 64);
            txtSearch.BorderFocusColor = Color.FromArgb(255, 106, 0);
            txtSearch.BorderSize = 1;
            txtSearch.Content = "";
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(617, 97);
            txtSearch.Margin = new Padding(4);
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(44, 8, 44, 0);
            txtSearch.PasswordChar = false;
            txtSearch.PlaceholderColor = Color.DimGray;
            txtSearch.PlaceholderText = "Tìm kiếm tên";
            txtSearch.Rounding = 16;
            txtSearch.Size = new Size(266, 35);
            txtSearch.TabIndex = 12;
            txtSearch.TextOffset = new Size(25, 0);
            txtSearch.UnderlinedStyle = false;
            txtSearch.ContentChanged += txtSearch_ContentChanged;
            // 
            // btnAdd
            // 
            btnAdd.CheckButton = false;
            btnAdd.Checked = false;
            btnAdd.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnAdd.CheckedForeColor = Color.White;
            btnAdd.CheckedImageTint = Color.White;
            btnAdd.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnAdd.Content = "Thêm";
            btnAdd.DialogResult = DialogResult.None;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.HoverBackground = Color.FromArgb(200, 255, 106, 0);
            btnAdd.HoveredImageTint = Color.White;
            btnAdd.HoverForeColor = Color.White;
            btnAdd.HoverOutline = Color.Empty;
            btnAdd.Image = null;
            btnAdd.ImageAutoCenter = true;
            btnAdd.ImageExpand = new Point(0, 0);
            btnAdd.ImageOffset = new Point(0, 0);
            btnAdd.ImageTint = Color.White;
            btnAdd.Location = new Point(192, 97);
            btnAdd.Name = "btnAdd";
            btnAdd.NormalBackground = Color.FromArgb(255, 106, 0);
            btnAdd.NormalOutline = Color.Empty;
            btnAdd.OutlineThickness = 1.6F;
            btnAdd.PressedBackground = Color.FromArgb(255, 106, 0);
            btnAdd.PressedForeColor = Color.White;
            btnAdd.PressedImageTint = Color.White;
            btnAdd.PressedOutline = Color.Empty;
            btnAdd.Rounding = new Padding(8);
            btnAdd.Size = new Size(122, 35);
            btnAdd.TabIndex = 11;
            btnAdd.TextOffset = new Point(0, 0);
            btnAdd.Click += btnAdd_Click;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Tài\\ khoản";
            cuiLabel1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            cuiLabel1.Location = new Point(4, 97);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(192, 35);
            cuiLabel1.TabIndex = 10;
            // 
            // dgvTK
            // 
            dgvTK.AllowUserToAddRows = false;
            dgvTK.AllowUserToDeleteRows = false;
            dgvTK.AllowUserToResizeRows = false;
            dgvTK.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvTK.BorderStyle = BorderStyle.None;
            dgvTK.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTK.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTK.Columns.AddRange(new DataGridViewColumn[] { _account, _password, staffId, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTK.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTK.EnableHeadersVisualStyles = false;
            dgvTK.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvTK.GridColor = Color.FromArgb(255, 255, 255);
            dgvTK.Location = new Point(0, 168);
            dgvTK.MultiSelect = false;
            dgvTK.Name = "dgvTK";
            dgvTK.ReadOnly = true;
            dgvTK.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTK.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTK.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTK.Size = new Size(905, 466);
            dgvTK.TabIndex = 9;
            dgvTK.CellClick += dgvTK_CellClick;
            // 
            // _account
            // 
            _account.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _account.HeaderText = "Tài khoản";
            _account.Name = "_account";
            _account.ReadOnly = true;
            _account.Resizable = DataGridViewTriState.False;
            // 
            // _password
            // 
            _password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _password.HeaderText = "Mật khẩu";
            _password.Name = "_password";
            _password.ReadOnly = true;
            _password.Resizable = DataGridViewTriState.False;
            // 
            // staffId
            // 
            staffId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            staffId.HeaderText = "Mã nhân viên";
            staffId.Name = "staffId";
            staffId.ReadOnly = true;
            staffId.Resizable = DataGridViewTriState.False;
            // 
            // Delete
            // 
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.delete;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.False;
            Delete.Width = 50;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // UC_QLTK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(lbTime);
            Controls.Add(lbDate);
            Controls.Add(cuiLabel2);
            Controls.Add(txtSearch);
            Controls.Add(btnAdd);
            Controls.Add(cuiLabel1);
            Controls.Add(dgvTK);
            Name = "UC_QLTK";
            Size = new Size(905, 634);
            Load += UC_QLTK_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiLabel lbTime;
        private CuoreUI.Controls.cuiLabel lbDate;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiTextBox2 txtSearch;
        private CuoreUI.Controls.cuiButton btnAdd;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvTK;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn _account;
        private DataGridViewTextBoxColumn _password;
        private DataGridViewTextBoxColumn staffId;
        private DataGridViewImageColumn Delete;
    }
}
