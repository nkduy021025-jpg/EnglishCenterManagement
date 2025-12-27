namespace EnglishCenterManagement
{
    partial class UC_ThuChi
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
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.cbbLyDo = new System.Windows.Forms.ComboBox();
            this.dtpNgayThuChi = new System.Windows.Forms.DateTimePicker();
            this.btnTimPhieuThuChi = new System.Windows.Forms.Button();
            this.btnLuuPhieuThuChi = new System.Windows.Forms.Button();
            this.btnSuaPhieuThuChi = new System.Windows.Forms.Button();
            this.btnXoaPhieuThuChi = new System.Windows.Forms.Button();
            this.btnThemPhieuThuChi = new System.Windows.Forms.Button();
            this.dgvDanhSachThuChi = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuaChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChuongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblMucDich = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblNgayThuChi = new System.Windows.Forms.Label();
            this.lblLuaChonThuChi = new System.Windows.Forms.Label();
            this.lblMaThietBi = new System.Windows.Forms.Label();
            this.lblThoiKhoaBieu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLuaChonThuChi = new System.Windows.Forms.ComboBox();
            this.txtSoTienThuChi = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnTinhTienTheoKhoa = new System.Windows.Forms.Button();
            this.txtMaKhoaHoc = new System.Windows.Forms.TextBox();
            this.txtThangThuChi = new System.Windows.Forms.TextBox();
            this.cbbThuChiTheoThang = new System.Windows.Forms.ComboBox();
            this.btnTinhDoanhThu = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbLuaChonTimKiem = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMaCT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBieuDoThuChiTheoThang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuChi)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(308, 238);
            this.lblNoiDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(87, 13);
            this.lblNoiDung.TabIndex = 143;
            this.lblNoiDung.Text = "Nội dung thu/chi";
            // 
            // cbbLyDo
            // 
            this.cbbLyDo.FormattingEnabled = true;
            this.cbbLyDo.Items.AddRange(new object[] {
            "Thu học phí học viên",
            "Thu mua/bán cơ sở vật chất",
            "Bảo trì cơ sở vật chất",
            "Hoàn học phí cho học viên",
            "Lương cho nhân viên",
            "Chi phí điện nước",
            "Chi phí duy trì",
            "Khác(ghi rõ ở nội dung)..."});
            this.cbbLyDo.Location = new System.Drawing.Point(405, 194);
            this.cbbLyDo.Name = "cbbLyDo";
            this.cbbLyDo.Size = new System.Drawing.Size(175, 21);
            this.cbbLyDo.TabIndex = 142;
            this.cbbLyDo.Text = "Thu học phí học viên";
            // 
            // dtpNgayThuChi
            // 
            this.dtpNgayThuChi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThuChi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThuChi.Location = new System.Drawing.Point(129, 227);
            this.dtpNgayThuChi.Name = "dtpNgayThuChi";
            this.dtpNgayThuChi.Size = new System.Drawing.Size(174, 20);
            this.dtpNgayThuChi.TabIndex = 140;
            this.dtpNgayThuChi.Value = new System.DateTime(2025, 12, 17, 14, 6, 8, 0);
            // 
            // btnTimPhieuThuChi
            // 
            this.btnTimPhieuThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhieuThuChi.Location = new System.Drawing.Point(5, 153);
            this.btnTimPhieuThuChi.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimPhieuThuChi.Name = "btnTimPhieuThuChi";
            this.btnTimPhieuThuChi.Size = new System.Drawing.Size(70, 30);
            this.btnTimPhieuThuChi.TabIndex = 137;
            this.btnTimPhieuThuChi.Text = "Tìm kiếm";
            this.btnTimPhieuThuChi.UseVisualStyleBackColor = true;
            this.btnTimPhieuThuChi.Click += new System.EventHandler(this.btnTimPhieuThuChi_Click);
            // 
            // btnLuuPhieuThuChi
            // 
            this.btnLuuPhieuThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieuThuChi.Location = new System.Drawing.Point(5, 119);
            this.btnLuuPhieuThuChi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuPhieuThuChi.Name = "btnLuuPhieuThuChi";
            this.btnLuuPhieuThuChi.Size = new System.Drawing.Size(70, 30);
            this.btnLuuPhieuThuChi.TabIndex = 136;
            this.btnLuuPhieuThuChi.Text = "Lưu";
            this.btnLuuPhieuThuChi.UseVisualStyleBackColor = true;
            this.btnLuuPhieuThuChi.Click += new System.EventHandler(this.btnLuuPhieuThuChi_Click);
            // 
            // btnSuaPhieuThuChi
            // 
            this.btnSuaPhieuThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhieuThuChi.Location = new System.Drawing.Point(5, 83);
            this.btnSuaPhieuThuChi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPhieuThuChi.Name = "btnSuaPhieuThuChi";
            this.btnSuaPhieuThuChi.Size = new System.Drawing.Size(70, 30);
            this.btnSuaPhieuThuChi.TabIndex = 135;
            this.btnSuaPhieuThuChi.Text = "Sửa";
            this.btnSuaPhieuThuChi.UseVisualStyleBackColor = true;
            this.btnSuaPhieuThuChi.Click += new System.EventHandler(this.btnSuaPhieuThuChi_Click);
            // 
            // btnXoaPhieuThuChi
            // 
            this.btnXoaPhieuThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieuThuChi.Location = new System.Drawing.Point(5, 51);
            this.btnXoaPhieuThuChi.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPhieuThuChi.Name = "btnXoaPhieuThuChi";
            this.btnXoaPhieuThuChi.Size = new System.Drawing.Size(70, 30);
            this.btnXoaPhieuThuChi.TabIndex = 134;
            this.btnXoaPhieuThuChi.Text = "Xóa";
            this.btnXoaPhieuThuChi.UseVisualStyleBackColor = true;
            this.btnXoaPhieuThuChi.Click += new System.EventHandler(this.btnXoaPhieuThuChi_Click);
            // 
            // btnThemPhieuThuChi
            // 
            this.btnThemPhieuThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhieuThuChi.Location = new System.Drawing.Point(5, 18);
            this.btnThemPhieuThuChi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhieuThuChi.Name = "btnThemPhieuThuChi";
            this.btnThemPhieuThuChi.Size = new System.Drawing.Size(70, 30);
            this.btnThemPhieuThuChi.TabIndex = 133;
            this.btnThemPhieuThuChi.Text = "Thêm";
            this.btnThemPhieuThuChi.UseVisualStyleBackColor = true;
            this.btnThemPhieuThuChi.Click += new System.EventHandler(this.btnThemPhieuThuChi_Click);
            // 
            // dgvDanhSachThuChi
            // 
            this.dgvDanhSachThuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachThuChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.LuaChon,
            this.ThoiGian,
            this.SoTien,
            this.LyDo,
            this.NoiDung,
            this.MaChuongTrinh});
            this.dgvDanhSachThuChi.Location = new System.Drawing.Point(12, 339);
            this.dgvDanhSachThuChi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSachThuChi.Name = "dgvDanhSachThuChi";
            this.dgvDanhSachThuChi.RowHeadersWidth = 51;
            this.dgvDanhSachThuChi.RowTemplate.Height = 24;
            this.dgvDanhSachThuChi.Size = new System.Drawing.Size(892, 138);
            this.dgvDanhSachThuChi.TabIndex = 132;
            this.dgvDanhSachThuChi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachThuChi_CellClick);
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "maThuChi";
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.MinimumWidth = 6;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Width = 125;
            // 
            // LuaChon
            // 
            this.LuaChon.DataPropertyName = "luaChonThuChi";
            this.LuaChon.HeaderText = "Lựa chọn";
            this.LuaChon.MinimumWidth = 6;
            this.LuaChon.Name = "LuaChon";
            this.LuaChon.Width = 125;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ngayThuChi";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.ThoiGian.DefaultCellStyle = dataGridViewCellStyle1;
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Width = 125;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "soTien";
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.Width = 125;
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "lyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.Width = 125;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "noiDung";
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Width = 125;
            // 
            // MaChuongTrinh
            // 
            this.MaChuongTrinh.DataPropertyName = "MaChuongTrinh";
            this.MaChuongTrinh.HeaderText = "Chương trình học";
            this.MaChuongTrinh.Name = "MaChuongTrinh";
            this.MaChuongTrinh.ReadOnly = true;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(129, 152);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(175, 20);
            this.txtMaPhieu.TabIndex = 131;
            this.txtMaPhieu.Text = "TC00";
            // 
            // lblMucDich
            // 
            this.lblMucDich.AutoSize = true;
            this.lblMucDich.Location = new System.Drawing.Point(314, 197);
            this.lblMucDich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMucDich.Name = "lblMucDich";
            this.lblMucDich.Size = new System.Drawing.Size(70, 13);
            this.lblMucDich.TabIndex = 130;
            this.lblMucDich.Text = "Lý do thu/chi";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(314, 157);
            this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(40, 13);
            this.lblNgayNhap.TabIndex = 129;
            this.lblNgayNhap.Text = "Số tiền";
            // 
            // lblNgayThuChi
            // 
            this.lblNgayThuChi.AutoSize = true;
            this.lblNgayThuChi.Location = new System.Drawing.Point(9, 233);
            this.lblNgayThuChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayThuChi.Name = "lblNgayThuChi";
            this.lblNgayThuChi.Size = new System.Drawing.Size(51, 13);
            this.lblNgayThuChi.TabIndex = 128;
            this.lblNgayThuChi.Text = "Thời gian";
            // 
            // lblLuaChonThuChi
            // 
            this.lblLuaChonThuChi.AutoSize = true;
            this.lblLuaChonThuChi.Location = new System.Drawing.Point(9, 197);
            this.lblLuaChonThuChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLuaChonThuChi.Name = "lblLuaChonThuChi";
            this.lblLuaChonThuChi.Size = new System.Drawing.Size(89, 13);
            this.lblLuaChonThuChi.TabIndex = 127;
            this.lblLuaChonThuChi.Text = "Lựa chọn thu/chi";
            // 
            // lblMaThietBi
            // 
            this.lblMaThietBi.AutoSize = true;
            this.lblMaThietBi.Location = new System.Drawing.Point(9, 157);
            this.lblMaThietBi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaThietBi.Name = "lblMaThietBi";
            this.lblMaThietBi.Size = new System.Drawing.Size(88, 13);
            this.lblMaThietBi.TabIndex = 126;
            this.lblMaThietBi.Text = "Mã phiếu thu/chi";
            // 
            // lblThoiKhoaBieu
            // 
            this.lblThoiKhoaBieu.AutoSize = true;
            this.lblThoiKhoaBieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblThoiKhoaBieu.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblThoiKhoaBieu.Location = new System.Drawing.Point(286, 79);
            this.lblThoiKhoaBieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThoiKhoaBieu.Name = "lblThoiKhoaBieu";
            this.lblThoiKhoaBieu.Size = new System.Drawing.Size(194, 31);
            this.lblThoiKhoaBieu.TabIndex = 125;
            this.lblThoiKhoaBieu.Text = "Quản lý thu chi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(149, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(587, 46);
            this.label4.TabIndex = 124;
            this.label4.Text = "ENGLISH CENTER DOUBLE D";
            // 
            // cbbLuaChonThuChi
            // 
            this.cbbLuaChonThuChi.FormattingEnabled = true;
            this.cbbLuaChonThuChi.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cbbLuaChonThuChi.Location = new System.Drawing.Point(129, 189);
            this.cbbLuaChonThuChi.Name = "cbbLuaChonThuChi";
            this.cbbLuaChonThuChi.Size = new System.Drawing.Size(175, 21);
            this.cbbLuaChonThuChi.TabIndex = 145;
            this.cbbLuaChonThuChi.Text = "Thu";
            // 
            // txtSoTienThuChi
            // 
            this.txtSoTienThuChi.Location = new System.Drawing.Point(405, 157);
            this.txtSoTienThuChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoTienThuChi.Name = "txtSoTienThuChi";
            this.txtSoTienThuChi.Size = new System.Drawing.Size(175, 20);
            this.txtSoTienThuChi.TabIndex = 146;
            this.txtSoTienThuChi.Text = "20000000";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(405, 231);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(175, 20);
            this.txtNoiDung.TabIndex = 147;
            this.txtNoiDung.Text = "Thu học phí tháng 12";
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnBieuDoThuChiTheoThang);
            this.grpChucNang.Controls.Add(this.btnTinhTienTheoKhoa);
            this.grpChucNang.Controls.Add(this.txtMaKhoaHoc);
            this.grpChucNang.Controls.Add(this.txtThangThuChi);
            this.grpChucNang.Controls.Add(this.cbbThuChiTheoThang);
            this.grpChucNang.Controls.Add(this.btnTinhDoanhThu);
            this.grpChucNang.Controls.Add(this.txtTimKiem);
            this.grpChucNang.Controls.Add(this.cbbLuaChonTimKiem);
            this.grpChucNang.Controls.Add(this.btnTimPhieuThuChi);
            this.grpChucNang.Controls.Add(this.btnLuuPhieuThuChi);
            this.grpChucNang.Controls.Add(this.btnSuaPhieuThuChi);
            this.grpChucNang.Controls.Add(this.btnXoaPhieuThuChi);
            this.grpChucNang.Controls.Add(this.btnThemPhieuThuChi);
            this.grpChucNang.Location = new System.Drawing.Point(584, 100);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(320, 234);
            this.grpChucNang.TabIndex = 148;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnTinhTienTheoKhoa
            // 
            this.btnTinhTienTheoKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTienTheoKhoa.Location = new System.Drawing.Point(216, 15);
            this.btnTinhTienTheoKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnTinhTienTheoKhoa.Name = "btnTinhTienTheoKhoa";
            this.btnTinhTienTheoKhoa.Size = new System.Drawing.Size(84, 88);
            this.btnTinhTienTheoKhoa.TabIndex = 146;
            this.btnTinhTienTheoKhoa.Text = "Tính tổng tiền học theo khóa học\r\n";
            this.btnTinhTienTheoKhoa.UseVisualStyleBackColor = true;
            this.btnTinhTienTheoKhoa.Click += new System.EventHandler(this.btnTinhTienTheoKhoa_Click_1);
            // 
            // txtMaKhoaHoc
            // 
            this.txtMaKhoaHoc.Location = new System.Drawing.Point(216, 107);
            this.txtMaKhoaHoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKhoaHoc.Name = "txtMaKhoaHoc";
            this.txtMaKhoaHoc.Size = new System.Drawing.Size(84, 20);
            this.txtMaKhoaHoc.TabIndex = 145;
            // 
            // txtThangThuChi
            // 
            this.txtThangThuChi.Location = new System.Drawing.Point(125, 62);
            this.txtThangThuChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtThangThuChi.Name = "txtThangThuChi";
            this.txtThangThuChi.Size = new System.Drawing.Size(39, 20);
            this.txtThangThuChi.TabIndex = 142;
            // 
            // cbbThuChiTheoThang
            // 
            this.cbbThuChiTheoThang.FormattingEnabled = true;
            this.cbbThuChiTheoThang.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cbbThuChiTheoThang.Location = new System.Drawing.Point(80, 62);
            this.cbbThuChiTheoThang.Margin = new System.Windows.Forms.Padding(2);
            this.cbbThuChiTheoThang.Name = "cbbThuChiTheoThang";
            this.cbbThuChiTheoThang.Size = new System.Drawing.Size(42, 21);
            this.cbbThuChiTheoThang.TabIndex = 141;
            // 
            // btnTinhDoanhThu
            // 
            this.btnTinhDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhDoanhThu.Location = new System.Drawing.Point(80, 15);
            this.btnTinhDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTinhDoanhThu.Name = "btnTinhDoanhThu";
            this.btnTinhDoanhThu.Size = new System.Drawing.Size(124, 42);
            this.btnTinhDoanhThu.TabIndex = 140;
            this.btnTinhDoanhThu.Text = "Tính tổng thu/chi theo tháng";
            this.btnTinhDoanhThu.UseVisualStyleBackColor = true;
            this.btnTinhDoanhThu.Click += new System.EventHandler(this.btnTinhDoanhThu_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 188);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(90, 20);
            this.txtTimKiem.TabIndex = 139;
            // 
            // cbbLuaChonTimKiem
            // 
            this.cbbLuaChonTimKiem.FormattingEnabled = true;
            this.cbbLuaChonTimKiem.Items.AddRange(new object[] {
            "Tìm theo mã phiếu",
            "Tìm theo số tiền",
            "Tìm theo thời gian"});
            this.cbbLuaChonTimKiem.Location = new System.Drawing.Point(80, 159);
            this.cbbLuaChonTimKiem.Name = "cbbLuaChonTimKiem";
            this.cbbLuaChonTimKiem.Size = new System.Drawing.Size(137, 21);
            this.cbbLuaChonTimKiem.TabIndex = 138;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 309);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(67, 25);
            this.btnLoad.TabIndex = 180;
            this.btnLoad.Text = "Làm mới ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 16);
            this.label1.TabIndex = 184;
            this.label1.Text = "---------------------------------------------------------------------------\r\n";
            // 
            // cbbMaCT
            // 
            this.cbbMaCT.FormattingEnabled = true;
            this.cbbMaCT.Items.AddRange(new object[] {
            "Không có"});
            this.cbbMaCT.Location = new System.Drawing.Point(405, 274);
            this.cbbMaCT.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaCT.Name = "cbbMaCT";
            this.cbbMaCT.Size = new System.Drawing.Size(174, 21);
            this.cbbMaCT.TabIndex = 146;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 186;
            this.label2.Text = "Mã chương trình";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EnglishCenterManagement.Properties.Resources.z7257614198401_9f47daa8ab828779f1ab0654d6b1fe48;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(15, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 72);
            this.panel1.TabIndex = 185;
            // 
            // btnBieuDoThuChiTheoThang
            // 
            this.btnBieuDoThuChiTheoThang.ForeColor = System.Drawing.Color.Turquoise;
            this.btnBieuDoThuChiTheoThang.Location = new System.Drawing.Point(224, 148);
            this.btnBieuDoThuChiTheoThang.Name = "btnBieuDoThuChiTheoThang";
            this.btnBieuDoThuChiTheoThang.Size = new System.Drawing.Size(76, 60);
            this.btnBieuDoThuChiTheoThang.TabIndex = 147;
            this.btnBieuDoThuChiTheoThang.Text = "Biểu đồ thu chi ";
            this.btnBieuDoThuChiTheoThang.UseVisualStyleBackColor = true;
            this.btnBieuDoThuChiTheoThang.Click += new System.EventHandler(this.btnBieuDoThuChiTheoThang_Click);
            // 
            // UC_ThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbMaCT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtSoTienThuChi);
            this.Controls.Add(this.cbbLuaChonThuChi);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.cbbLyDo);
            this.Controls.Add(this.dtpNgayThuChi);
            this.Controls.Add(this.dgvDanhSachThuChi);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.lblMucDich);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.lblNgayThuChi);
            this.Controls.Add(this.lblLuaChonThuChi);
            this.Controls.Add(this.lblMaThietBi);
            this.Controls.Add(this.lblThoiKhoaBieu);
            this.Controls.Add(this.label4);
            this.Name = "UC_ThuChi";
            this.Size = new System.Drawing.Size(1167, 652);
            this.Load += new System.EventHandler(this.UC_ThuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuChi)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.grpChucNang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.ComboBox cbbLyDo;
        private System.Windows.Forms.DateTimePicker dtpNgayThuChi;
        private System.Windows.Forms.Button btnTimPhieuThuChi;
        private System.Windows.Forms.Button btnLuuPhieuThuChi;
        private System.Windows.Forms.Button btnSuaPhieuThuChi;
        private System.Windows.Forms.Button btnXoaPhieuThuChi;
        private System.Windows.Forms.Button btnThemPhieuThuChi;
        private System.Windows.Forms.DataGridView dgvDanhSachThuChi;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblMucDich;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblNgayThuChi;
        private System.Windows.Forms.Label lblLuaChonThuChi;
        private System.Windows.Forms.Label lblMaThietBi;
        private System.Windows.Forms.Label lblThoiKhoaBieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLuaChonThuChi;
        private System.Windows.Forms.TextBox txtSoTienThuChi;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.ComboBox cbbLuaChonTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtThangThuChi;
        private System.Windows.Forms.ComboBox cbbThuChiTheoThang;
        private System.Windows.Forms.Button btnTinhDoanhThu;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaKhoaHoc;
        private System.Windows.Forms.ComboBox cbbMaCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuongTrinh;
        private System.Windows.Forms.Button btnTinhTienTheoKhoa;
        private System.Windows.Forms.Button btnBieuDoThuChiTheoThang;
    }
}
