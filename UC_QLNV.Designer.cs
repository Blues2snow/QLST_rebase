namespace QLST_rebase
{
    partial class UC_QLNV
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
            dgvNV = new ReaLTaiizor.Controls.PoisonDataGridView();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            btnAdd = new CuoreUI.Controls.cuiButton();
            txtSearch = new CuoreUI.Controls.cuiTextBox2();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            lbDate = new CuoreUI.Controls.cuiLabel();
            lbTime = new CuoreUI.Controls.cuiLabel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            staffId = new DataGridViewTextBoxColumn();
            staffName = new DataGridViewTextBoxColumn();
            birthDate = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            salary = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            phoneNumber = new DataGridViewTextBoxColumn();
            position = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvNV
            // 
            dgvNV.AllowUserToAddRows = false;
            dgvNV.AllowUserToDeleteRows = false;
            dgvNV.AllowUserToResizeColumns = false;
            dgvNV.AllowUserToResizeRows = false;
            dgvNV.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvNV.BorderStyle = BorderStyle.None;
            dgvNV.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvNV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNV.Columns.AddRange(new DataGridViewColumn[] { staffId, staffName, birthDate, gender, address, salary, email, phoneNumber, position, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNV.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNV.Dock = DockStyle.Bottom;
            dgvNV.EnableHeadersVisualStyles = false;
            dgvNV.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvNV.GridColor = Color.FromArgb(255, 255, 255);
            dgvNV.Location = new Point(0, 168);
            dgvNV.Name = "dgvNV";
            dgvNV.ReadOnly = true;
            dgvNV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvNV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNV.Size = new Size(905, 466);
            dgvNV.TabIndex = 1;
            dgvNV.CellClick += dgvNV_CellClick;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Nhân\\ viên";
            cuiLabel1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            cuiLabel1.Location = new Point(4, 97);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(192, 35);
            cuiLabel1.TabIndex = 2;
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
            btnAdd.TabIndex = 3;
            btnAdd.TextOffset = new Point(0, 0);
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderColor = Color.FromArgb(64, 64, 64);
            txtSearch.BorderFocusColor = Color.FromArgb(255, 106, 0);
            txtSearch.BorderSize = 1;
            txtSearch.Content = "";
            txtSearch.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(617, 97);
            txtSearch.Margin = new Padding(4);
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(40, 10, 40, 0);
            txtSearch.PasswordChar = false;
            txtSearch.PlaceholderColor = Color.DimGray;
            txtSearch.PlaceholderText = "Tìm kiếm tên";
            txtSearch.Rounding = 16;
            txtSearch.Size = new Size(266, 35);
            txtSearch.TabIndex = 4;
            txtSearch.TextOffset = new Size(25, 0);
            txtSearch.UnderlinedStyle = false;
            txtSearch.ContentChanged += txtSearch_ContentChanged;
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
            cuiLabel2.TabIndex = 5;
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
            lbDate.TabIndex = 6;
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
            lbTime.TabIndex = 7;
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
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // staffId
            // 
            staffId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            staffId.HeaderText = "Mã nhân viên";
            staffId.Name = "staffId";
            staffId.ReadOnly = true;
            // 
            // staffName
            // 
            staffName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            staffName.HeaderText = "Tên nhân viên";
            staffName.Name = "staffName";
            staffName.ReadOnly = true;
            // 
            // birthDate
            // 
            birthDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            birthDate.HeaderText = "Ngày sinh";
            birthDate.Name = "birthDate";
            birthDate.ReadOnly = true;
            // 
            // gender
            // 
            gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gender.HeaderText = "Giới tính";
            gender.Name = "gender";
            gender.ReadOnly = true;
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.HeaderText = "Địa chỉ";
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // salary
            // 
            salary.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            salary.HeaderText = "Lương";
            salary.Name = "salary";
            salary.ReadOnly = true;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // phoneNumber
            // 
            phoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phoneNumber.HeaderText = "SDT";
            phoneNumber.Name = "phoneNumber";
            phoneNumber.ReadOnly = true;
            // 
            // position
            // 
            position.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            position.HeaderText = "Chức vụ";
            position.Name = "position";
            position.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.edit;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Width = 50;
            // 
            // Delete
            // 
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.delete;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Width = 50;
            // 
            // UC_QLNV
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
            Controls.Add(dgvNV);
            Name = "UC_QLNV";
            Size = new Size(905, 634);
            Load += UC_QLNV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView dgvNV;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton btnAdd;
        private CuoreUI.Controls.cuiTextBox2 txtSearch;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel lbDate;
        private CuoreUI.Controls.cuiLabel lbTime;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn staffId;
        private DataGridViewTextBoxColumn staffName;
        private DataGridViewTextBoxColumn birthDate;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn salary;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phoneNumber;
        private DataGridViewTextBoxColumn position;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}
