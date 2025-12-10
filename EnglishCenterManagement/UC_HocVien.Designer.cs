namespace EnglishCenterManagement
{
    partial class UC_HocVien
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
            this.btnDocHV = new System.Windows.Forms.Button();
            this.cbbChuongTrinhHoc = new System.Windows.Forms.ComboBox();
            this.cbbTrinhDo = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLuuHV = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDanhSachHocVien = new System.Windows.Forms.DataGridView();
            this.gbGioTinh = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.lblNgayDangKy = new System.Windows.Forms.Label();
            this.lblChuongTrinhHoc = new System.Windows.Forms.Label();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaHV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenTT = new System.Windows.Forms.Label();
            this.lblMaTKB = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuongTrinhHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimTheoGioiTinh = new System.Windows.Forms.Button();
            this.btnTimTheoTen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocVien)).BeginInit();
            this.gbGioTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDocHV
            // 
            this.btnDocHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocHV.Location = new System.Drawing.Point(895, 337);
            this.btnDocHV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDocHV.Name = "btnDocHV";
            this.btnDocHV.Size = new System.Drawing.Size(93, 34);
            this.btnDocHV.TabIndex = 88;
            this.btnDocHV.Text = "Đọc File";
            this.btnDocHV.UseVisualStyleBackColor = true;
            this.btnDocHV.Click += new System.EventHandler(this.btnDocHV_Click);
            // 
            // cbbChuongTrinhHoc
            // 
            this.cbbChuongTrinhHoc.FormattingEnabled = true;
            this.cbbChuongTrinhHoc.Items.AddRange(new object[] {
            "Toeic 450",
            "Toeic 700",
            "Ielts 7.0",
            "Huy Forum"});
            this.cbbChuongTrinhHoc.Location = new System.Drawing.Point(600, 250);
            this.cbbChuongTrinhHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbChuongTrinhHoc.Name = "cbbChuongTrinhHoc";
            this.cbbChuongTrinhHoc.Size = new System.Drawing.Size(211, 24);
            this.cbbChuongTrinhHoc.TabIndex = 87;
            // 
            // cbbTrinhDo
            // 
            this.cbbTrinhDo.FormattingEnabled = true;
            this.cbbTrinhDo.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1"});
            this.cbbTrinhDo.Location = new System.Drawing.Point(600, 210);
            this.cbbTrinhDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTrinhDo.Name = "cbbTrinhDo";
            this.cbbTrinhDo.Size = new System.Drawing.Size(211, 24);
            this.cbbTrinhDo.TabIndex = 86;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(895, 292);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 39);
            this.btnTimKiem.TabIndex = 85;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLuuHV
            // 
            this.btnLuuHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHV.Location = new System.Drawing.Point(895, 252);
            this.btnLuuHV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuHV.Name = "btnLuuHV";
            this.btnLuuHV.Size = new System.Drawing.Size(93, 39);
            this.btnLuuHV.TabIndex = 84;
            this.btnLuuHV.Text = "Lưu";
            this.btnLuuHV.UseVisualStyleBackColor = true;
            this.btnLuuHV.Click += new System.EventHandler(this.btnLuuHV_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(895, 203);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 39);
            this.btnSua.TabIndex = 83;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(895, 154);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 39);
            this.btnXoa.TabIndex = 82;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(895, 105);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 39);
            this.btnThem.TabIndex = 81;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDanhSachHocVien
            // 
            this.dgvDanhSachHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHV,
            this.hoTen,
            this.CCCD,
            this.ngaySinh,
            this.gioiTinh,
            this.diaChi,
            this.SDT,
            this.trinhDo,
            this.chuongTrinhHoc,
            this.ngayDangKy});
            this.dgvDanhSachHocVien.Location = new System.Drawing.Point(15, 436);
            this.dgvDanhSachHocVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachHocVien.Name = "dgvDanhSachHocVien";
            this.dgvDanhSachHocVien.RowHeadersWidth = 51;
            this.dgvDanhSachHocVien.RowTemplate.Height = 24;
            this.dgvDanhSachHocVien.Size = new System.Drawing.Size(1144, 256);
            this.dgvDanhSachHocVien.TabIndex = 80;
            // 
            // gbGioTinh
            // 
            this.gbGioTinh.Controls.Add(this.radNu);
            this.gbGioTinh.Controls.Add(this.radNam);
            this.gbGioTinh.Location = new System.Drawing.Point(129, 290);
            this.gbGioTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGioTinh.Name = "gbGioTinh";
            this.gbGioTinh.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGioTinh.Size = new System.Drawing.Size(140, 57);
            this.gbGioTinh.TabIndex = 79;
            this.gbGioTinh.TabStop = false;
            this.gbGioTinh.Text = "Giới Tính";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(80, 21);
            this.radNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(5, 21);
            this.radNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Location = new System.Drawing.Point(600, 290);
            this.dtpNgayDangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(228, 22);
            this.dtpNgayDangKy.TabIndex = 78;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(129, 250);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(233, 22);
            this.dtpNgaySinh.TabIndex = 77;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(600, 169);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(211, 22);
            this.txtSDT.TabIndex = 76;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(600, 132);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(211, 22);
            this.txtDiaChi.TabIndex = 75;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(129, 207);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(219, 22);
            this.txtCCCD.TabIndex = 74;
            this.txtCCCD.Text = "2005";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(129, 169);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(219, 22);
            this.txtHoTen.TabIndex = 73;
            this.txtHoTen.Text = "Nguyễn Duy";
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(129, 129);
            this.txtMaHV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(219, 22);
            this.txtMaHV.TabIndex = 72;
            this.txtMaHV.Text = "DuyNguyen";
            // 
            // lblNgayDangKy
            // 
            this.lblNgayDangKy.AutoSize = true;
            this.lblNgayDangKy.Location = new System.Drawing.Point(472, 290);
            this.lblNgayDangKy.Name = "lblNgayDangKy";
            this.lblNgayDangKy.Size = new System.Drawing.Size(91, 16);
            this.lblNgayDangKy.TabIndex = 71;
            this.lblNgayDangKy.Text = "Ngày đăng ký";
            // 
            // lblChuongTrinhHoc
            // 
            this.lblChuongTrinhHoc.AutoSize = true;
            this.lblChuongTrinhHoc.Location = new System.Drawing.Point(472, 250);
            this.lblChuongTrinhHoc.Name = "lblChuongTrinhHoc";
            this.lblChuongTrinhHoc.Size = new System.Drawing.Size(105, 16);
            this.lblChuongTrinhHoc.TabIndex = 70;
            this.lblChuongTrinhHoc.Text = "Chương trình học";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Location = new System.Drawing.Point(472, 210);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(75, 16);
            this.lblTrinhDo.TabIndex = 69;
            this.lblTrinhDo.Text = "Trình độ EL";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(472, 175);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(85, 16);
            this.lblSDT.TabIndex = 68;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(472, 132);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(49, 16);
            this.lblDiaChi.TabIndex = 67;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(11, 290);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(60, 16);
            this.lblGioiTinh.TabIndex = 66;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(11, 250);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(69, 16);
            this.lblNgaySinh.TabIndex = 65;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(11, 213);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(44, 16);
            this.lblCCCD.TabIndex = 64;
            this.lblCCCD.Text = "CCCD";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(11, 175);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(64, 16);
            this.lblHoTen.TabIndex = 63;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // lblMaHV
            // 
            this.lblMaHV.AutoSize = true;
            this.lblMaHV.Location = new System.Drawing.Point(11, 129);
            this.lblMaHV.Name = "lblMaHV";
            this.lblMaHV.Size = new System.Drawing.Size(84, 16);
            this.lblMaHV.TabIndex = 62;
            this.lblMaHV.Text = "Mã Học Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(371, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 39);
            this.label2.TabIndex = 61;
            this.label2.Text = "Quản Lý Học Viên";
            // 
            // lblTenTT
            // 
            this.lblTenTT.AutoSize = true;
            this.lblTenTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTenTT.ForeColor = System.Drawing.Color.Crimson;
            this.lblTenTT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTenTT.Location = new System.Drawing.Point(177, 9);
            this.lblTenTT.Name = "lblTenTT";
            this.lblTenTT.Size = new System.Drawing.Size(729, 58);
            this.lblTenTT.TabIndex = 60;
            this.lblTenTT.Text = "ENGLISH CENTER DOUBLE D";
            // 
            // lblMaTKB
            // 
            this.lblMaTKB.AutoSize = true;
            this.lblMaTKB.Location = new System.Drawing.Point(472, 340);
            this.lblMaTKB.Name = "lblMaTKB";
            this.lblMaTKB.Size = new System.Drawing.Size(112, 16);
            this.lblMaTKB.TabIndex = 89;
            this.lblMaTKB.Text = "Mã thời khóa biểu";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CA1LE",
            "CA2LE",
            "CA3LE",
            "CA4LE",
            "CA1CHAN",
            "CA2CHAN",
            "CA3CHAN",
            "CA4CHAN"});
            this.comboBox1.Location = new System.Drawing.Point(601, 335);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 24);
            this.comboBox1.TabIndex = 90;
            // 
            // maHV
            // 
            this.maHV.DataPropertyName = "maHV";
            this.maHV.HeaderText = "Mã học viên";
            this.maHV.MinimumWidth = 6;
            this.maHV.Name = "maHV";
            this.maHV.Width = 125;
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ tên";
            this.hoTen.MinimumWidth = 6;
            this.hoTen.Name = "hoTen";
            this.hoTen.Width = 125;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "cccdhv";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.Width = 125;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Width = 125;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Width = 125;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // trinhDo
            // 
            this.trinhDo.DataPropertyName = "trinhDo";
            this.trinhDo.HeaderText = "Trình độ";
            this.trinhDo.MinimumWidth = 6;
            this.trinhDo.Name = "trinhDo";
            this.trinhDo.Width = 125;
            // 
            // chuongTrinhHoc
            // 
            this.chuongTrinhHoc.DataPropertyName = "chuongTrinhHoc";
            this.chuongTrinhHoc.HeaderText = "Chương trình học";
            this.chuongTrinhHoc.MinimumWidth = 6;
            this.chuongTrinhHoc.Name = "chuongTrinhHoc";
            this.chuongTrinhHoc.Width = 125;
            // 
            // ngayDangKy
            // 
            this.ngayDangKy.DataPropertyName = "ngayDangKy";
            this.ngayDangKy.HeaderText = "Ngày đăng ký";
            this.ngayDangKy.MinimumWidth = 6;
            this.ngayDangKy.Name = "ngayDangKy";
            this.ngayDangKy.Width = 125;
            // 
            // btnTimTheoGioiTinh
            // 
            this.btnTimTheoGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoGioiTinh.Location = new System.Drawing.Point(1014, 273);
            this.btnTimTheoGioiTinh.Name = "btnTimTheoGioiTinh";
            this.btnTimTheoGioiTinh.Size = new System.Drawing.Size(190, 40);
            this.btnTimTheoGioiTinh.TabIndex = 126;
            this.btnTimTheoGioiTinh.Text = "Tìm theo giới tính";
            this.btnTimTheoGioiTinh.UseVisualStyleBackColor = true;
            this.btnTimTheoGioiTinh.Click += new System.EventHandler(this.btnTimTheoGioiTinh_Click);
            // 
            // btnTimTheoTen
            // 
            this.btnTimTheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoTen.Location = new System.Drawing.Point(1014, 152);
            this.btnTimTheoTen.Name = "btnTimTheoTen";
            this.btnTimTheoTen.Size = new System.Drawing.Size(138, 40);
            this.btnTimTheoTen.TabIndex = 124;
            this.btnTimTheoTen.Text = "Tìm theo tên";
            this.btnTimTheoTen.UseVisualStyleBackColor = true;
            this.btnTimTheoTen.Click += new System.EventHandler(this.btnTimTheoTen_Click);
            // 
            // UC_HocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTimTheoGioiTinh);
            this.Controls.Add(this.btnTimTheoTen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMaTKB);
            this.Controls.Add(this.btnDocHV);
            this.Controls.Add(this.cbbChuongTrinhHoc);
            this.Controls.Add(this.cbbTrinhDo);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLuuHV);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhSachHocVien);
            this.Controls.Add(this.gbGioTinh);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaHV);
            this.Controls.Add(this.lblNgayDangKy);
            this.Controls.Add(this.lblChuongTrinhHoc);
            this.Controls.Add(this.lblTrinhDo);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaHV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTenTT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_HocVien";
            this.Size = new System.Drawing.Size(1228, 629);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocVien)).EndInit();
            this.gbGioTinh.ResumeLayout(false);
            this.gbGioTinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDocHV;
        private System.Windows.Forms.ComboBox cbbChuongTrinhHoc;
        private System.Windows.Forms.ComboBox cbbTrinhDo;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLuuHV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDanhSachHocVien;
        private System.Windows.Forms.GroupBox gbGioTinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label lblNgayDangKy;
        private System.Windows.Forms.Label lblChuongTrinhHoc;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaHV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenTT;
        private System.Windows.Forms.Label lblMaTKB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuongTrinhHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDangKy;
        private System.Windows.Forms.Button btnTimTheoGioiTinh;
        private System.Windows.Forms.Button btnTimTheoTen;
    }
}
