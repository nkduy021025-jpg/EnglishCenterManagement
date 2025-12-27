namespace EnglishCenterManagement
{
    partial class UC_GiaoVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbbBangCap = new System.Windows.Forms.ComboBox();
            this.cbbThamNien = new System.Windows.Forms.ComboBox();
            this.btnTimGV = new System.Windows.Forms.Button();
            this.btnLuuGV = new System.Windows.Forms.Button();
            this.btnSuaGV = new System.Windows.Forms.Button();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.dgvDanhSachGiaoVien = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbGioiTinhGV = new System.Windows.Forms.GroupBox();
            this.radNuGV = new System.Windows.Forms.RadioButton();
            this.radNamGV = new System.Windows.Forms.RadioButton();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySinhGV = new System.Windows.Forms.DateTimePicker();
            this.txtSDTGV = new System.Windows.Forms.TextBox();
            this.txtDiaChiGV = new System.Windows.Forms.TextBox();
            this.txtCCCDGV = new System.Windows.Forms.TextBox();
            this.txtHoTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.lblBangCap = new System.Windows.Forms.Label();
            this.lblThamNien = new System.Windows.Forms.Label();
            this.lblSDTGV = new System.Windows.Forms.Label();
            this.lblDiaChiGV = new System.Windows.Forms.Label();
            this.lblGioiTinhGV = new System.Windows.Forms.Label();
            this.lblNgaySinhGV = new System.Windows.Forms.Label();
            this.lblHoTenGV = new System.Windows.Forms.Label();
            this.lblMaGiaoVien = new System.Windows.Forms.Label();
            this.lblQuanLyGiaoVien = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCCCDGV = new System.Windows.Forms.Label();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiaoVien)).BeginInit();
            this.gbGioiTinhGV.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(519, 159);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 22);
            this.txtEmail.TabIndex = 118;
            this.txtEmail.Text = "DungDH523002662@gmail.com";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(391, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 117;
            this.lblEmail.Text = "Email";
            // 
            // cbbBangCap
            // 
            this.cbbBangCap.FormattingEnabled = true;
            this.cbbBangCap.Items.AddRange(new object[] {
            "Toeic 450 - 700",
            "Toeic 700 - 990",
            "Ielts 4.5 - 6.5",
            "Ielts 6.5 - 8.0",
            "Ielts > 8.0",
            "C1",
            "C2"});
            this.cbbBangCap.Location = new System.Drawing.Point(519, 278);
            this.cbbBangCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbBangCap.Name = "cbbBangCap";
            this.cbbBangCap.Size = new System.Drawing.Size(211, 24);
            this.cbbBangCap.TabIndex = 116;
            this.cbbBangCap.Text = "Toeic 450 - 700";
            // 
            // cbbThamNien
            // 
            this.cbbThamNien.FormattingEnabled = true;
            this.cbbThamNien.Items.AddRange(new object[] {
            "1",
            "3",
            "5 ",
            "7",
            "10",
            "15"});
            this.cbbThamNien.Location = new System.Drawing.Point(519, 236);
            this.cbbThamNien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbThamNien.Name = "cbbThamNien";
            this.cbbThamNien.Size = new System.Drawing.Size(211, 24);
            this.cbbThamNien.TabIndex = 115;
            this.cbbThamNien.Text = "5 ";
            // 
            // btnTimGV
            // 
            this.btnTimGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimGV.Location = new System.Drawing.Point(13, 207);
            this.btnTimGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimGV.Name = "btnTimGV";
            this.btnTimGV.Size = new System.Drawing.Size(93, 39);
            this.btnTimGV.TabIndex = 114;
            this.btnTimGV.Text = "Tìm kiếm";
            this.btnTimGV.UseVisualStyleBackColor = true;
            this.btnTimGV.Click += new System.EventHandler(this.btnTimGV_Click);
            // 
            // btnLuuGV
            // 
            this.btnLuuGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuGV.Location = new System.Drawing.Point(13, 162);
            this.btnLuuGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuGV.Name = "btnLuuGV";
            this.btnLuuGV.Size = new System.Drawing.Size(93, 39);
            this.btnLuuGV.TabIndex = 113;
            this.btnLuuGV.Text = "Lưu";
            this.btnLuuGV.UseVisualStyleBackColor = true;
            this.btnLuuGV.Click += new System.EventHandler(this.btnLuuGV_Click);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaGV.Location = new System.Drawing.Point(13, 119);
            this.btnSuaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(93, 39);
            this.btnSuaGV.TabIndex = 112;
            this.btnSuaGV.Text = "Sửa";
            this.btnSuaGV.UseVisualStyleBackColor = true;
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGV.Location = new System.Drawing.Point(13, 69);
            this.btnXoaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(93, 39);
            this.btnXoaGV.TabIndex = 111;
            this.btnXoaGV.Text = "Xóa";
            this.btnXoaGV.UseVisualStyleBackColor = true;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnThemGV
            // 
            this.btnThemGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGV.Location = new System.Drawing.Point(13, 20);
            this.btnThemGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(93, 39);
            this.btnThemGV.TabIndex = 110;
            this.btnThemGV.Text = "Thêm";
            this.btnThemGV.UseVisualStyleBackColor = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // dgvDanhSachGiaoVien
            // 
            this.dgvDanhSachGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.email,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.luong});
            this.dgvDanhSachGiaoVien.Location = new System.Drawing.Point(12, 443);
            this.dgvDanhSachGiaoVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachGiaoVien.Name = "dgvDanhSachGiaoVien";
            this.dgvDanhSachGiaoVien.RowHeadersWidth = 51;
            this.dgvDanhSachGiaoVien.RowTemplate.Height = 24;
            this.dgvDanhSachGiaoVien.Size = new System.Drawing.Size(1017, 256);
            this.dgvDanhSachGiaoVien.TabIndex = 109;
            this.dgvDanhSachGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachGiaoVien_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "maGV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã giáo viên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "hoTenGV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cccdgv";
            this.dataGridViewTextBoxColumn3.HeaderText = "CCCD";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ngaySinhGV";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "gioiTinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "diaChiGV";
            this.dataGridViewTextBoxColumn6.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SDTGV";
            this.dataGridViewTextBoxColumn7.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "thamNien";
            this.dataGridViewTextBoxColumn8.HeaderText = "Thâm niên";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "bangCap";
            this.dataGridViewTextBoxColumn9.HeaderText = "Bằng cấp";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ngayVaoLam";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn10.HeaderText = "Ngày vào làm";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // luong
            // 
            this.luong.DataPropertyName = "luong";
            this.luong.HeaderText = "Lương";
            this.luong.MinimumWidth = 6;
            this.luong.Name = "luong";
            this.luong.Width = 125;
            // 
            // gbGioiTinhGV
            // 
            this.gbGioiTinhGV.Controls.Add(this.radNuGV);
            this.gbGioiTinhGV.Controls.Add(this.radNamGV);
            this.gbGioiTinhGV.Location = new System.Drawing.Point(135, 290);
            this.gbGioiTinhGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGioiTinhGV.Name = "gbGioiTinhGV";
            this.gbGioiTinhGV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGioiTinhGV.Size = new System.Drawing.Size(140, 57);
            this.gbGioiTinhGV.TabIndex = 108;
            this.gbGioiTinhGV.TabStop = false;
            this.gbGioiTinhGV.Text = "Giới Tính";
            // 
            // radNuGV
            // 
            this.radNuGV.AutoSize = true;
            this.radNuGV.Location = new System.Drawing.Point(80, 21);
            this.radNuGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNuGV.Name = "radNuGV";
            this.radNuGV.Size = new System.Drawing.Size(45, 20);
            this.radNuGV.TabIndex = 1;
            this.radNuGV.TabStop = true;
            this.radNuGV.Text = "Nữ";
            this.radNuGV.UseVisualStyleBackColor = true;
            // 
            // radNamGV
            // 
            this.radNamGV.AutoSize = true;
            this.radNamGV.Checked = true;
            this.radNamGV.Location = new System.Drawing.Point(5, 21);
            this.radNamGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNamGV.Name = "radNamGV";
            this.radNamGV.Size = new System.Drawing.Size(57, 20);
            this.radNamGV.TabIndex = 0;
            this.radNamGV.TabStop = true;
            this.radNamGV.Text = "Nam";
            this.radNamGV.UseVisualStyleBackColor = true;
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(519, 319);
            this.dtpNgayVaoLam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(228, 22);
            this.dtpNgayVaoLam.TabIndex = 107;
            // 
            // dtpNgaySinhGV
            // 
            this.dtpNgaySinhGV.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinhGV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhGV.Location = new System.Drawing.Point(135, 250);
            this.dtpNgaySinhGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinhGV.Name = "dtpNgaySinhGV";
            this.dtpNgaySinhGV.Size = new System.Drawing.Size(233, 22);
            this.dtpNgaySinhGV.TabIndex = 106;
            // 
            // txtSDTGV
            // 
            this.txtSDTGV.Location = new System.Drawing.Point(519, 197);
            this.txtSDTGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTGV.Name = "txtSDTGV";
            this.txtSDTGV.Size = new System.Drawing.Size(211, 22);
            this.txtSDTGV.TabIndex = 105;
            this.txtSDTGV.Text = "012345";
            // 
            // txtDiaChiGV
            // 
            this.txtDiaChiGV.Location = new System.Drawing.Point(519, 126);
            this.txtDiaChiGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChiGV.Name = "txtDiaChiGV";
            this.txtDiaChiGV.Size = new System.Drawing.Size(211, 22);
            this.txtDiaChiGV.TabIndex = 104;
            this.txtDiaChiGV.Text = "Bình Phước";
            // 
            // txtCCCDGV
            // 
            this.txtCCCDGV.Location = new System.Drawing.Point(135, 207);
            this.txtCCCDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCDGV.Name = "txtCCCDGV";
            this.txtCCCDGV.Size = new System.Drawing.Size(219, 22);
            this.txtCCCDGV.TabIndex = 103;
            this.txtCCCDGV.Text = "07020500";
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.Location = new System.Drawing.Point(135, 169);
            this.txtHoTenGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.Size = new System.Drawing.Size(219, 22);
            this.txtHoTenGV.TabIndex = 102;
            this.txtHoTenGV.Text = "Nguyễn Tuấn Dũng";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(135, 129);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(219, 22);
            this.txtMaGV.TabIndex = 101;
            this.txtMaGV.Text = "GV001";
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.AutoSize = true;
            this.lblNgayVaoLam.Location = new System.Drawing.Point(391, 324);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(91, 16);
            this.lblNgayVaoLam.TabIndex = 100;
            this.lblNgayVaoLam.Text = "Ngày vào làm";
            // 
            // lblBangCap
            // 
            this.lblBangCap.AutoSize = true;
            this.lblBangCap.Location = new System.Drawing.Point(391, 286);
            this.lblBangCap.Name = "lblBangCap";
            this.lblBangCap.Size = new System.Drawing.Size(65, 16);
            this.lblBangCap.TabIndex = 99;
            this.lblBangCap.Text = "Bằng cấp";
            // 
            // lblThamNien
            // 
            this.lblThamNien.AutoSize = true;
            this.lblThamNien.Location = new System.Drawing.Point(391, 247);
            this.lblThamNien.Name = "lblThamNien";
            this.lblThamNien.Size = new System.Drawing.Size(70, 16);
            this.lblThamNien.TabIndex = 98;
            this.lblThamNien.Text = "Thâm niên";
            // 
            // lblSDTGV
            // 
            this.lblSDTGV.AutoSize = true;
            this.lblSDTGV.Location = new System.Drawing.Point(391, 203);
            this.lblSDTGV.Name = "lblSDTGV";
            this.lblSDTGV.Size = new System.Drawing.Size(85, 16);
            this.lblSDTGV.TabIndex = 97;
            this.lblSDTGV.Text = "Số điện thoại";
            // 
            // lblDiaChiGV
            // 
            this.lblDiaChiGV.AutoSize = true;
            this.lblDiaChiGV.Location = new System.Drawing.Point(391, 126);
            this.lblDiaChiGV.Name = "lblDiaChiGV";
            this.lblDiaChiGV.Size = new System.Drawing.Size(49, 16);
            this.lblDiaChiGV.TabIndex = 96;
            this.lblDiaChiGV.Text = "Địa Chỉ";
            // 
            // lblGioiTinhGV
            // 
            this.lblGioiTinhGV.AutoSize = true;
            this.lblGioiTinhGV.Location = new System.Drawing.Point(17, 290);
            this.lblGioiTinhGV.Name = "lblGioiTinhGV";
            this.lblGioiTinhGV.Size = new System.Drawing.Size(60, 16);
            this.lblGioiTinhGV.TabIndex = 95;
            this.lblGioiTinhGV.Text = "Giới Tính";
            // 
            // lblNgaySinhGV
            // 
            this.lblNgaySinhGV.AutoSize = true;
            this.lblNgaySinhGV.Location = new System.Drawing.Point(17, 250);
            this.lblNgaySinhGV.Name = "lblNgaySinhGV";
            this.lblNgaySinhGV.Size = new System.Drawing.Size(69, 16);
            this.lblNgaySinhGV.TabIndex = 94;
            this.lblNgaySinhGV.Text = "Ngày Sinh";
            // 
            // lblHoTenGV
            // 
            this.lblHoTenGV.AutoSize = true;
            this.lblHoTenGV.Location = new System.Drawing.Point(17, 175);
            this.lblHoTenGV.Name = "lblHoTenGV";
            this.lblHoTenGV.Size = new System.Drawing.Size(64, 16);
            this.lblHoTenGV.TabIndex = 93;
            this.lblHoTenGV.Text = "Họ và tên";
            // 
            // lblMaGiaoVien
            // 
            this.lblMaGiaoVien.AutoSize = true;
            this.lblMaGiaoVien.Location = new System.Drawing.Point(17, 129);
            this.lblMaGiaoVien.Name = "lblMaGiaoVien";
            this.lblMaGiaoVien.Size = new System.Drawing.Size(88, 16);
            this.lblMaGiaoVien.TabIndex = 92;
            this.lblMaGiaoVien.Text = "Mã Giáo Viên";
            // 
            // lblQuanLyGiaoVien
            // 
            this.lblQuanLyGiaoVien.AutoSize = true;
            this.lblQuanLyGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQuanLyGiaoVien.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblQuanLyGiaoVien.Location = new System.Drawing.Point(367, 85);
            this.lblQuanLyGiaoVien.Name = "lblQuanLyGiaoVien";
            this.lblQuanLyGiaoVien.Size = new System.Drawing.Size(304, 39);
            this.lblQuanLyGiaoVien.TabIndex = 91;
            this.lblQuanLyGiaoVien.Text = "Quản Lý Giáo Viên";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Location = new System.Drawing.Point(191, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(729, 58);
            this.label14.TabIndex = 90;
            this.label14.Text = "ENGLISH CENTER DOUBLE D";
            // 
            // lblCCCDGV
            // 
            this.lblCCCDGV.AutoSize = true;
            this.lblCCCDGV.Location = new System.Drawing.Point(17, 210);
            this.lblCCCDGV.Name = "lblCCCDGV";
            this.lblCCCDGV.Size = new System.Drawing.Size(44, 16);
            this.lblCCCDGV.TabIndex = 121;
            this.lblCCCDGV.Text = "CCCD";
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.txtTimKiem);
            this.grpChucNang.Controls.Add(this.cbbTimKiem);
            this.grpChucNang.Controls.Add(this.btnTimGV);
            this.grpChucNang.Controls.Add(this.btnLuuGV);
            this.grpChucNang.Controls.Add(this.btnSuaGV);
            this.grpChucNang.Controls.Add(this.btnXoaGV);
            this.grpChucNang.Controls.Add(this.btnThemGV);
            this.grpChucNang.Location = new System.Drawing.Point(760, 82);
            this.grpChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChucNang.Size = new System.Drawing.Size(277, 289);
            this.grpChucNang.TabIndex = 124;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(19, 254);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(199, 22);
            this.txtTimKiem.TabIndex = 116;
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Tìm theo mã",
            "Tìm theo tên",
            "Tìm theo thâm niên",
            "Tìm theo giới tính"});
            this.cbbTimKiem.Location = new System.Drawing.Point(112, 208);
            this.cbbTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(164, 24);
            this.cbbTimKiem.TabIndex = 115;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 407);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 31);
            this.btnLoad.TabIndex = 181;
            this.btnLoad.Text = "Làm mới ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(459, 20);
            this.label4.TabIndex = 182;
            this.label4.Text = "---------------------------------------------------------------------------\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EnglishCenterManagement.Properties.Resources.z7257614198401_9f47daa8ab828779f1ab0654d6b1fe48;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 89);
            this.panel1.TabIndex = 183;
            // 
            // UC_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.lblCCCDGV);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cbbBangCap);
            this.Controls.Add(this.cbbThamNien);
            this.Controls.Add(this.dgvDanhSachGiaoVien);
            this.Controls.Add(this.gbGioiTinhGV);
            this.Controls.Add(this.dtpNgayVaoLam);
            this.Controls.Add(this.dtpNgaySinhGV);
            this.Controls.Add(this.txtSDTGV);
            this.Controls.Add(this.txtDiaChiGV);
            this.Controls.Add(this.txtCCCDGV);
            this.Controls.Add(this.txtHoTenGV);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.lblNgayVaoLam);
            this.Controls.Add(this.lblBangCap);
            this.Controls.Add(this.lblThamNien);
            this.Controls.Add(this.lblSDTGV);
            this.Controls.Add(this.lblDiaChiGV);
            this.Controls.Add(this.lblGioiTinhGV);
            this.Controls.Add(this.lblNgaySinhGV);
            this.Controls.Add(this.lblHoTenGV);
            this.Controls.Add(this.lblMaGiaoVien);
            this.Controls.Add(this.lblQuanLyGiaoVien);
            this.Controls.Add(this.label14);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_GiaoVien";
            this.Size = new System.Drawing.Size(1595, 783);
            this.Load += new System.EventHandler(this.UC_GiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGiaoVien)).EndInit();
            this.gbGioiTinhGV.ResumeLayout(false);
            this.gbGioiTinhGV.PerformLayout();
            this.grpChucNang.ResumeLayout(false);
            this.grpChucNang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cbbBangCap;
        private System.Windows.Forms.ComboBox cbbThamNien;
        private System.Windows.Forms.Button btnTimGV;
        private System.Windows.Forms.Button btnLuuGV;
        private System.Windows.Forms.Button btnSuaGV;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.DataGridView dgvDanhSachGiaoVien;
        private System.Windows.Forms.GroupBox gbGioiTinhGV;
        private System.Windows.Forms.RadioButton radNuGV;
        private System.Windows.Forms.RadioButton radNamGV;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhGV;
        private System.Windows.Forms.TextBox txtSDTGV;
        private System.Windows.Forms.TextBox txtDiaChiGV;
        private System.Windows.Forms.TextBox txtCCCDGV;
        private System.Windows.Forms.TextBox txtHoTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.Label lblBangCap;
        private System.Windows.Forms.Label lblThamNien;
        private System.Windows.Forms.Label lblSDTGV;
        private System.Windows.Forms.Label lblDiaChiGV;
        private System.Windows.Forms.Label lblGioiTinhGV;
        private System.Windows.Forms.Label lblNgaySinhGV;
        private System.Windows.Forms.Label lblHoTenGV;
        private System.Windows.Forms.Label lblMaGiaoVien;
        private System.Windows.Forms.Label lblQuanLyGiaoVien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCCCDGV;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
    }
}
