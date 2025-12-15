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
            this.txtKetQuaThuChi = new System.Windows.Forms.TextBox();
            this.txtThangThuChi = new System.Windows.Forms.TextBox();
            this.cbbThuChiTheoThang = new System.Windows.Forms.ComboBox();
            this.btnTinhDoanhThu = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbLuaChonTimKiem = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuChi)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(432, 287);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(102, 16);
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
            "Khác"});
            this.cbbLyDo.Location = new System.Drawing.Point(540, 239);
            this.cbbLyDo.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLyDo.Name = "cbbLyDo";
            this.cbbLyDo.Size = new System.Drawing.Size(232, 24);
            this.cbbLyDo.TabIndex = 142;
            // 
            // dtpNgayThuChi
            // 
            this.dtpNgayThuChi.Location = new System.Drawing.Point(172, 279);
            this.dtpNgayThuChi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayThuChi.Name = "dtpNgayThuChi";
            this.dtpNgayThuChi.Size = new System.Drawing.Size(231, 22);
            this.dtpNgayThuChi.TabIndex = 140;
            // 
            // btnTimPhieuThuChi
            // 
            this.btnTimPhieuThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhieuThuChi.Location = new System.Drawing.Point(7, 188);
            this.btnTimPhieuThuChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimPhieuThuChi.Name = "btnTimPhieuThuChi";
            this.btnTimPhieuThuChi.Size = new System.Drawing.Size(93, 37);
            this.btnTimPhieuThuChi.TabIndex = 137;
            this.btnTimPhieuThuChi.Text = "Tìm kiếm";
            this.btnTimPhieuThuChi.UseVisualStyleBackColor = true;
            this.btnTimPhieuThuChi.Click += new System.EventHandler(this.btnTimPhieuThuChi_Click);
            // 
            // btnLuuPhieuThuChi
            // 
            this.btnLuuPhieuThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieuThuChi.Location = new System.Drawing.Point(7, 146);
            this.btnLuuPhieuThuChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuPhieuThuChi.Name = "btnLuuPhieuThuChi";
            this.btnLuuPhieuThuChi.Size = new System.Drawing.Size(93, 37);
            this.btnLuuPhieuThuChi.TabIndex = 136;
            this.btnLuuPhieuThuChi.Text = "Lưu";
            this.btnLuuPhieuThuChi.UseVisualStyleBackColor = true;
            this.btnLuuPhieuThuChi.Click += new System.EventHandler(this.btnLuuPhieuThuChi_Click);
            // 
            // btnSuaPhieuThuChi
            // 
            this.btnSuaPhieuThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhieuThuChi.Location = new System.Drawing.Point(7, 102);
            this.btnSuaPhieuThuChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaPhieuThuChi.Name = "btnSuaPhieuThuChi";
            this.btnSuaPhieuThuChi.Size = new System.Drawing.Size(93, 37);
            this.btnSuaPhieuThuChi.TabIndex = 135;
            this.btnSuaPhieuThuChi.Text = "Sửa";
            this.btnSuaPhieuThuChi.UseVisualStyleBackColor = true;
            this.btnSuaPhieuThuChi.Click += new System.EventHandler(this.btnSuaPhieuThuChi_Click);
            // 
            // btnXoaPhieuThuChi
            // 
            this.btnXoaPhieuThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieuThuChi.Location = new System.Drawing.Point(7, 63);
            this.btnXoaPhieuThuChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPhieuThuChi.Name = "btnXoaPhieuThuChi";
            this.btnXoaPhieuThuChi.Size = new System.Drawing.Size(93, 37);
            this.btnXoaPhieuThuChi.TabIndex = 134;
            this.btnXoaPhieuThuChi.Text = "Xóa";
            this.btnXoaPhieuThuChi.UseVisualStyleBackColor = true;
            this.btnXoaPhieuThuChi.Click += new System.EventHandler(this.btnXoaPhieuThuChi_Click);
            // 
            // btnThemPhieuThuChi
            // 
            this.btnThemPhieuThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhieuThuChi.Location = new System.Drawing.Point(7, 22);
            this.btnThemPhieuThuChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPhieuThuChi.Name = "btnThemPhieuThuChi";
            this.btnThemPhieuThuChi.Size = new System.Drawing.Size(93, 37);
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
            this.NoiDung});
            this.dgvDanhSachThuChi.Location = new System.Drawing.Point(16, 417);
            this.dgvDanhSachThuChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachThuChi.Name = "dgvDanhSachThuChi";
            this.dgvDanhSachThuChi.RowHeadersWidth = 51;
            this.dgvDanhSachThuChi.RowTemplate.Height = 24;
            this.dgvDanhSachThuChi.Size = new System.Drawing.Size(831, 170);
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
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(172, 187);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(232, 22);
            this.txtMaPhieu.TabIndex = 131;
            // 
            // lblMucDich
            // 
            this.lblMucDich.AutoSize = true;
            this.lblMucDich.Location = new System.Drawing.Point(432, 242);
            this.lblMucDich.Name = "lblMucDich";
            this.lblMucDich.Size = new System.Drawing.Size(81, 16);
            this.lblMucDich.TabIndex = 130;
            this.lblMucDich.Text = "Lý do thu/chi";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(432, 193);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(48, 16);
            this.lblNgayNhap.TabIndex = 129;
            this.lblNgayNhap.Text = "Số tiền";
            // 
            // lblNgayThuChi
            // 
            this.lblNgayThuChi.AutoSize = true;
            this.lblNgayThuChi.Location = new System.Drawing.Point(12, 287);
            this.lblNgayThuChi.Name = "lblNgayThuChi";
            this.lblNgayThuChi.Size = new System.Drawing.Size(63, 16);
            this.lblNgayThuChi.TabIndex = 128;
            this.lblNgayThuChi.Text = "Thời gian";
            // 
            // lblLuaChonThuChi
            // 
            this.lblLuaChonThuChi.AutoSize = true;
            this.lblLuaChonThuChi.Location = new System.Drawing.Point(12, 242);
            this.lblLuaChonThuChi.Name = "lblLuaChonThuChi";
            this.lblLuaChonThuChi.Size = new System.Drawing.Size(102, 16);
            this.lblLuaChonThuChi.TabIndex = 127;
            this.lblLuaChonThuChi.Text = "Lựa chọn thu/chi";
            // 
            // lblMaThietBi
            // 
            this.lblMaThietBi.AutoSize = true;
            this.lblMaThietBi.Location = new System.Drawing.Point(12, 193);
            this.lblMaThietBi.Name = "lblMaThietBi";
            this.lblMaThietBi.Size = new System.Drawing.Size(103, 16);
            this.lblMaThietBi.TabIndex = 126;
            this.lblMaThietBi.Text = "Mã phiếu thu/chi";
            // 
            // lblThoiKhoaBieu
            // 
            this.lblThoiKhoaBieu.AutoSize = true;
            this.lblThoiKhoaBieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblThoiKhoaBieu.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblThoiKhoaBieu.Location = new System.Drawing.Point(371, 123);
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
            this.label4.Location = new System.Drawing.Point(199, 53);
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
            this.cbbLuaChonThuChi.Location = new System.Drawing.Point(172, 233);
            this.cbbLuaChonThuChi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLuaChonThuChi.Name = "cbbLuaChonThuChi";
            this.cbbLuaChonThuChi.Size = new System.Drawing.Size(232, 24);
            this.cbbLuaChonThuChi.TabIndex = 145;
            // 
            // txtSoTienThuChi
            // 
            this.txtSoTienThuChi.Location = new System.Drawing.Point(540, 193);
            this.txtSoTienThuChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTienThuChi.Name = "txtSoTienThuChi";
            this.txtSoTienThuChi.Size = new System.Drawing.Size(232, 22);
            this.txtSoTienThuChi.TabIndex = 146;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(540, 284);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(232, 22);
            this.txtNoiDung.TabIndex = 147;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.txtKetQuaThuChi);
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
            this.grpChucNang.Location = new System.Drawing.Point(779, 123);
            this.grpChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Padding = new System.Windows.Forms.Padding(4);
            this.grpChucNang.Size = new System.Drawing.Size(289, 288);
            this.grpChucNang.TabIndex = 148;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // txtKetQuaThuChi
            // 
            this.txtKetQuaThuChi.Location = new System.Drawing.Point(107, 106);
            this.txtKetQuaThuChi.Name = "txtKetQuaThuChi";
            this.txtKetQuaThuChi.ReadOnly = true;
            this.txtKetQuaThuChi.Size = new System.Drawing.Size(175, 22);
            this.txtKetQuaThuChi.TabIndex = 143;
            // 
            // txtThangThuChi
            // 
            this.txtThangThuChi.Location = new System.Drawing.Point(167, 76);
            this.txtThangThuChi.Name = "txtThangThuChi";
            this.txtThangThuChi.Size = new System.Drawing.Size(51, 22);
            this.txtThangThuChi.TabIndex = 142;
            // 
            // cbbThuChiTheoThang
            // 
            this.cbbThuChiTheoThang.FormattingEnabled = true;
            this.cbbThuChiTheoThang.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cbbThuChiTheoThang.Location = new System.Drawing.Point(107, 76);
            this.cbbThuChiTheoThang.Name = "cbbThuChiTheoThang";
            this.cbbThuChiTheoThang.Size = new System.Drawing.Size(54, 24);
            this.cbbThuChiTheoThang.TabIndex = 141;
            // 
            // btnTinhDoanhThu
            // 
            this.btnTinhDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhDoanhThu.Location = new System.Drawing.Point(107, 19);
            this.btnTinhDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTinhDoanhThu.Name = "btnTinhDoanhThu";
            this.btnTinhDoanhThu.Size = new System.Drawing.Size(166, 52);
            this.btnTinhDoanhThu.TabIndex = 140;
            this.btnTinhDoanhThu.Text = "Tính tổng thu/chi theo tháng";
            this.btnTinhDoanhThu.UseVisualStyleBackColor = true;
            this.btnTinhDoanhThu.Click += new System.EventHandler(this.btnTinhDoanhThu_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(8, 231);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(119, 22);
            this.txtTimKiem.TabIndex = 139;
            // 
            // cbbLuaChonTimKiem
            // 
            this.cbbLuaChonTimKiem.FormattingEnabled = true;
            this.cbbLuaChonTimKiem.Items.AddRange(new object[] {
            "Tìm theo mã phiếu",
            "Tìm theo số tiền",
            "Tìm theo thời gian"});
            this.cbbLuaChonTimKiem.Location = new System.Drawing.Point(107, 196);
            this.cbbLuaChonTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLuaChonTimKiem.Name = "cbbLuaChonTimKiem";
            this.cbbLuaChonTimKiem.Size = new System.Drawing.Size(111, 24);
            this.cbbLuaChonTimKiem.TabIndex = 138;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(16, 380);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 31);
            this.btnLoad.TabIndex = 180;
            this.btnLoad.Text = "Làm mới ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // UC_ThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ThuChi";
            this.Size = new System.Drawing.Size(1119, 623);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.ComboBox cbbLuaChonTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtThangThuChi;
        private System.Windows.Forms.ComboBox cbbThuChiTheoThang;
        private System.Windows.Forms.Button btnTinhDoanhThu;
        private System.Windows.Forms.TextBox txtKetQuaThuChi;
        private System.Windows.Forms.Button btnLoad;
    }
}
