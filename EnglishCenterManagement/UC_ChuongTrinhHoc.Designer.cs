namespace EnglishCenterManagement
{
    partial class UC_ChuongTrinhHoc
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
            this.txtMoTaCTH = new System.Windows.Forms.TextBox();
            this.lblMoTaChuongTrinh = new System.Windows.Forms.Label();
            this.btnLuuChuongTrinh = new System.Windows.Forms.Button();
            this.btnSuaChuongTrinh = new System.Windows.Forms.Button();
            this.btnXoaChuongTrinh = new System.Windows.Forms.Button();
            this.btnThemChuongTrinh = new System.Windows.Forms.Button();
            this.txtMaChuongTrinhHoc = new System.Windows.Forms.TextBox();
            this.lblMucDich = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblNgayThuChi = new System.Windows.Forms.Label();
            this.lblLuaChonThuChi = new System.Windows.Forms.Label();
            this.lblMaThietBi = new System.Windows.Forms.Label();
            this.lblThoiKhoaBieu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvChuongTrinh = new System.Windows.Forms.DataGridView();
            this.MaChuongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoiTuongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbThoiGianHoc = new System.Windows.Forms.ComboBox();
            this.txtTenChuongTrinhHoc = new System.Windows.Forms.TextBox();
            this.txtHocPhi = new System.Windows.Forms.TextBox();
            this.cbbDoiTuongHoc = new System.Windows.Forms.ComboBox();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.cbbLoTrinh = new System.Windows.Forms.ComboBox();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongTrinh)).BeginInit();
            this.grpTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMoTaCTH
            // 
            this.txtMoTaCTH.Location = new System.Drawing.Point(426, 225);
            this.txtMoTaCTH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMoTaCTH.Name = "txtMoTaCTH";
            this.txtMoTaCTH.Size = new System.Drawing.Size(175, 20);
            this.txtMoTaCTH.TabIndex = 168;
            this.txtMoTaCTH.Text = "Dành cho người mất gốc";
            // 
            // lblMoTaChuongTrinh
            // 
            this.lblMoTaChuongTrinh.AutoSize = true;
            this.lblMoTaChuongTrinh.Location = new System.Drawing.Point(342, 228);
            this.lblMoTaChuongTrinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoTaChuongTrinh.Name = "lblMoTaChuongTrinh";
            this.lblMoTaChuongTrinh.Size = new System.Drawing.Size(37, 13);
            this.lblMoTaChuongTrinh.TabIndex = 165;
            this.lblMoTaChuongTrinh.Text = "Mô tả \r\n";
            // 
            // btnLuuChuongTrinh
            // 
            this.btnLuuChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuChuongTrinh.Location = new System.Drawing.Point(15, 126);
            this.btnLuuChuongTrinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuuChuongTrinh.Name = "btnLuuChuongTrinh";
            this.btnLuuChuongTrinh.Size = new System.Drawing.Size(70, 30);
            this.btnLuuChuongTrinh.TabIndex = 160;
            this.btnLuuChuongTrinh.Text = "Lưu";
            this.btnLuuChuongTrinh.UseVisualStyleBackColor = true;
            this.btnLuuChuongTrinh.Click += new System.EventHandler(this.btnLuuChuongTrinh_Click);
            // 
            // btnSuaChuongTrinh
            // 
            this.btnSuaChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChuongTrinh.Location = new System.Drawing.Point(15, 88);
            this.btnSuaChuongTrinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaChuongTrinh.Name = "btnSuaChuongTrinh";
            this.btnSuaChuongTrinh.Size = new System.Drawing.Size(70, 30);
            this.btnSuaChuongTrinh.TabIndex = 159;
            this.btnSuaChuongTrinh.Text = "Sửa";
            this.btnSuaChuongTrinh.UseVisualStyleBackColor = true;
            this.btnSuaChuongTrinh.Click += new System.EventHandler(this.btnSuaChuongTrinh_Click);
            // 
            // btnXoaChuongTrinh
            // 
            this.btnXoaChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChuongTrinh.Location = new System.Drawing.Point(14, 52);
            this.btnXoaChuongTrinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaChuongTrinh.Name = "btnXoaChuongTrinh";
            this.btnXoaChuongTrinh.Size = new System.Drawing.Size(70, 30);
            this.btnXoaChuongTrinh.TabIndex = 158;
            this.btnXoaChuongTrinh.Text = "Xóa";
            this.btnXoaChuongTrinh.UseVisualStyleBackColor = true;
            this.btnXoaChuongTrinh.Click += new System.EventHandler(this.btnXoaChuongTrinh_Click);
            // 
            // btnThemChuongTrinh
            // 
            this.btnThemChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChuongTrinh.Location = new System.Drawing.Point(15, 18);
            this.btnThemChuongTrinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemChuongTrinh.Name = "btnThemChuongTrinh";
            this.btnThemChuongTrinh.Size = new System.Drawing.Size(70, 30);
            this.btnThemChuongTrinh.TabIndex = 157;
            this.btnThemChuongTrinh.Text = "Thêm";
            this.btnThemChuongTrinh.UseVisualStyleBackColor = true;
            this.btnThemChuongTrinh.Click += new System.EventHandler(this.btnThemChuongTrinh_Click);
            // 
            // txtMaChuongTrinhHoc
            // 
            this.txtMaChuongTrinhHoc.Location = new System.Drawing.Point(158, 144);
            this.txtMaChuongTrinhHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaChuongTrinhHoc.Name = "txtMaChuongTrinhHoc";
            this.txtMaChuongTrinhHoc.Size = new System.Drawing.Size(175, 20);
            this.txtMaChuongTrinhHoc.TabIndex = 155;
            this.txtMaChuongTrinhHoc.Text = "CT00";
            // 
            // lblMucDich
            // 
            this.lblMucDich.AutoSize = true;
            this.lblMucDich.Location = new System.Drawing.Point(342, 189);
            this.lblMucDich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMucDich.Name = "lblMucDich";
            this.lblMucDich.Size = new System.Drawing.Size(46, 13);
            this.lblMucDich.TabIndex = 154;
            this.lblMucDich.Text = "Học phí";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(342, 152);
            this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(74, 13);
            this.lblNgayNhap.TabIndex = 153;
            this.lblNgayNhap.Text = "Đối tượng học";
            // 
            // lblNgayThuChi
            // 
            this.lblNgayThuChi.AutoSize = true;
            this.lblNgayThuChi.Location = new System.Drawing.Point(38, 225);
            this.lblNgayThuChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayThuChi.Name = "lblNgayThuChi";
            this.lblNgayThuChi.Size = new System.Drawing.Size(72, 13);
            this.lblNgayThuChi.TabIndex = 152;
            this.lblNgayThuChi.Text = "Thời gian học";
            // 
            // lblLuaChonThuChi
            // 
            this.lblLuaChonThuChi.AutoSize = true;
            this.lblLuaChonThuChi.Location = new System.Drawing.Point(38, 189);
            this.lblLuaChonThuChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLuaChonThuChi.Name = "lblLuaChonThuChi";
            this.lblLuaChonThuChi.Size = new System.Drawing.Size(0, 13);
            this.lblLuaChonThuChi.TabIndex = 151;
            // 
            // lblMaThietBi
            // 
            this.lblMaThietBi.AutoSize = true;
            this.lblMaThietBi.Location = new System.Drawing.Point(38, 149);
            this.lblMaThietBi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaThietBi.Name = "lblMaThietBi";
            this.lblMaThietBi.Size = new System.Drawing.Size(105, 13);
            this.lblMaThietBi.TabIndex = 150;
            this.lblMaThietBi.Text = "Mã chương trình học";
            // 
            // lblThoiKhoaBieu
            // 
            this.lblThoiKhoaBieu.AutoSize = true;
            this.lblThoiKhoaBieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblThoiKhoaBieu.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblThoiKhoaBieu.Location = new System.Drawing.Point(284, 107);
            this.lblThoiKhoaBieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThoiKhoaBieu.Name = "lblThoiKhoaBieu";
            this.lblThoiKhoaBieu.Size = new System.Drawing.Size(220, 31);
            this.lblThoiKhoaBieu.TabIndex = 149;
            this.lblThoiKhoaBieu.Text = "Chương trình học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(150, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(587, 46);
            this.label4.TabIndex = 148;
            this.label4.Text = "ENGLISH CENTER DOUBLE D";
            // 
            // dgvChuongTrinh
            // 
            this.dgvChuongTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuongTrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuongTrinh,
            this.TenChuongTrinh,
            this.LoTrinh,
            this.ThoiGianHoc,
            this.DoiTuongHoc,
            this.HocPhi,
            this.MoTa});
            this.dgvChuongTrinh.Location = new System.Drawing.Point(20, 354);
            this.dgvChuongTrinh.Name = "dgvChuongTrinh";
            this.dgvChuongTrinh.RowHeadersWidth = 51;
            this.dgvChuongTrinh.Size = new System.Drawing.Size(696, 177);
            this.dgvChuongTrinh.TabIndex = 169;
            this.dgvChuongTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuongTrinh_CellClick);
            // 
            // MaChuongTrinh
            // 
            this.MaChuongTrinh.DataPropertyName = "MaChuongTrinh";
            this.MaChuongTrinh.HeaderText = "Mã chương trình";
            this.MaChuongTrinh.MinimumWidth = 6;
            this.MaChuongTrinh.Name = "MaChuongTrinh";
            this.MaChuongTrinh.ReadOnly = true;
            this.MaChuongTrinh.Width = 125;
            // 
            // TenChuongTrinh
            // 
            this.TenChuongTrinh.DataPropertyName = "TenChuongTrinh";
            this.TenChuongTrinh.HeaderText = "Tên chương trình ";
            this.TenChuongTrinh.MinimumWidth = 6;
            this.TenChuongTrinh.Name = "TenChuongTrinh";
            this.TenChuongTrinh.ReadOnly = true;
            this.TenChuongTrinh.Width = 125;
            // 
            // LoTrinh
            // 
            this.LoTrinh.DataPropertyName = "LoTrinhHoc";
            this.LoTrinh.HeaderText = "Lộ trình học";
            this.LoTrinh.MinimumWidth = 6;
            this.LoTrinh.Name = "LoTrinh";
            this.LoTrinh.ReadOnly = true;
            this.LoTrinh.Width = 125;
            // 
            // ThoiGianHoc
            // 
            this.ThoiGianHoc.DataPropertyName = "ThoiGianHoc";
            this.ThoiGianHoc.HeaderText = "Thời gian học";
            this.ThoiGianHoc.MinimumWidth = 6;
            this.ThoiGianHoc.Name = "ThoiGianHoc";
            this.ThoiGianHoc.ReadOnly = true;
            this.ThoiGianHoc.Width = 125;
            // 
            // DoiTuongHoc
            // 
            this.DoiTuongHoc.HeaderText = "Đối tượng học";
            this.DoiTuongHoc.MinimumWidth = 6;
            this.DoiTuongHoc.Name = "DoiTuongHoc";
            this.DoiTuongHoc.ReadOnly = true;
            this.DoiTuongHoc.Width = 125;
            // 
            // HocPhi
            // 
            this.HocPhi.DataPropertyName = "HocPhi";
            this.HocPhi.HeaderText = "Học phí";
            this.HocPhi.MinimumWidth = 6;
            this.HocPhi.Name = "HocPhi";
            this.HocPhi.ReadOnly = true;
            this.HocPhi.Width = 125;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả chương trình học";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 170;
            this.label1.Text = "Tên chương trình học";
            // 
            // cbbThoiGianHoc
            // 
            this.cbbThoiGianHoc.FormattingEnabled = true;
            this.cbbThoiGianHoc.Items.AddRange(new object[] {
            "3 tháng",
            "6 tháng",
            "1 năm",
            "2 năm",
            ">5 năm"});
            this.cbbThoiGianHoc.Location = new System.Drawing.Point(158, 226);
            this.cbbThoiGianHoc.Name = "cbbThoiGianHoc";
            this.cbbThoiGianHoc.Size = new System.Drawing.Size(175, 21);
            this.cbbThoiGianHoc.TabIndex = 171;
            this.cbbThoiGianHoc.Text = "3 tháng";
            // 
            // txtTenChuongTrinhHoc
            // 
            this.txtTenChuongTrinhHoc.Location = new System.Drawing.Point(158, 179);
            this.txtTenChuongTrinhHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenChuongTrinhHoc.Name = "txtTenChuongTrinhHoc";
            this.txtTenChuongTrinhHoc.Size = new System.Drawing.Size(175, 20);
            this.txtTenChuongTrinhHoc.TabIndex = 173;
            this.txtTenChuongTrinhHoc.Text = "Mất gốc plus";
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.Location = new System.Drawing.Point(426, 182);
            this.txtHocPhi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Size = new System.Drawing.Size(175, 20);
            this.txtHocPhi.TabIndex = 174;
            this.txtHocPhi.Text = "1200000";
            // 
            // cbbDoiTuongHoc
            // 
            this.cbbDoiTuongHoc.FormattingEnabled = true;
            this.cbbDoiTuongHoc.Items.AddRange(new object[] {
            "Học sinh",
            "Sinh viên",
            "Người đã đi làm"});
            this.cbbDoiTuongHoc.Location = new System.Drawing.Point(426, 143);
            this.cbbDoiTuongHoc.Name = "cbbDoiTuongHoc";
            this.cbbDoiTuongHoc.Size = new System.Drawing.Size(175, 21);
            this.cbbDoiTuongHoc.TabIndex = 172;
            this.cbbDoiTuongHoc.Text = "Học sinh";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(38, 267);
            this.lblThoiGian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(63, 13);
            this.lblThoiGian.TabIndex = 175;
            this.lblThoiGian.Text = "Lộ trình học";
            // 
            // cbbLoTrinh
            // 
            this.cbbLoTrinh.FormattingEnabled = true;
            this.cbbLoTrinh.Items.AddRange(new object[] {
            "Học 3 buổi/tuần , kĩ năng nói/viết , hoàn thành trong 48 buổi",
            "Học 3 buổi/tuần , kĩ năng nghe/đọc , hoàn thành trong 48 buổi",
            "..."});
            this.cbbLoTrinh.Location = new System.Drawing.Point(158, 264);
            this.cbbLoTrinh.Name = "cbbLoTrinh";
            this.cbbLoTrinh.Size = new System.Drawing.Size(175, 21);
            this.cbbLoTrinh.TabIndex = 176;
            this.cbbLoTrinh.Text = "Học 3 buổi/tuần , kĩ năng nói/viết , hoàn thành trong 48 buổi";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Controls.Add(this.cbbTimKiem);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.btnLuuChuongTrinh);
            this.grpTimKiem.Controls.Add(this.btnSuaChuongTrinh);
            this.grpTimKiem.Controls.Add(this.btnXoaChuongTrinh);
            this.grpTimKiem.Controls.Add(this.btnThemChuongTrinh);
            this.grpTimKiem.Location = new System.Drawing.Point(607, 113);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(194, 235);
            this.grpTimKiem.TabIndex = 177;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Chức năng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(15, 195);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(90, 20);
            this.txtTimKiem.TabIndex = 163;
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Theo mã chương trình",
            "Theo tên chương trình",
            "Theo học phí",
            "Theo đối tượng học"});
            this.cbbTimKiem.Location = new System.Drawing.Point(90, 166);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(98, 21);
            this.cbbTimKiem.TabIndex = 162;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(15, 160);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(70, 30);
            this.btnTimKiem.TabIndex = 161;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(20, 323);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(67, 25);
            this.btnLoad.TabIndex = 178;
            this.btnLoad.Text = "Làm mới ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 24);
            this.label2.TabIndex = 179;
            this.label2.Text = "---------------------------------------------------------------------------\r\n";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EnglishCenterManagement.Properties.Resources.z7257614198401_9f47daa8ab828779f1ab0654d6b1fe48;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 72);
            this.panel1.TabIndex = 184;
            // 
            // UC_ChuongTrinhHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.cbbLoTrinh);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.txtHocPhi);
            this.Controls.Add(this.txtTenChuongTrinhHoc);
            this.Controls.Add(this.cbbDoiTuongHoc);
            this.Controls.Add(this.cbbThoiGianHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChuongTrinh);
            this.Controls.Add(this.txtMoTaCTH);
            this.Controls.Add(this.lblMoTaChuongTrinh);
            this.Controls.Add(this.txtMaChuongTrinhHoc);
            this.Controls.Add(this.lblMucDich);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.lblNgayThuChi);
            this.Controls.Add(this.lblLuaChonThuChi);
            this.Controls.Add(this.lblMaThietBi);
            this.Controls.Add(this.lblThoiKhoaBieu);
            this.Controls.Add(this.label4);
            this.Name = "UC_ChuongTrinhHoc";
            this.Size = new System.Drawing.Size(866, 584);
            this.Load += new System.EventHandler(this.UC_ChuongTrinhHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongTrinh)).EndInit();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoTaCTH;
        private System.Windows.Forms.Label lblMoTaChuongTrinh;
        private System.Windows.Forms.Button btnLuuChuongTrinh;
        private System.Windows.Forms.Button btnSuaChuongTrinh;
        private System.Windows.Forms.Button btnXoaChuongTrinh;
        private System.Windows.Forms.Button btnThemChuongTrinh;
        private System.Windows.Forms.TextBox txtMaChuongTrinhHoc;
        private System.Windows.Forms.Label lblMucDich;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblNgayThuChi;
        private System.Windows.Forms.Label lblLuaChonThuChi;
        private System.Windows.Forms.Label lblMaThietBi;
        private System.Windows.Forms.Label lblThoiKhoaBieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvChuongTrinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbThoiGianHoc;
        private System.Windows.Forms.TextBox txtTenChuongTrinhHoc;
        private System.Windows.Forms.TextBox txtHocPhi;
        private System.Windows.Forms.ComboBox cbbDoiTuongHoc;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.ComboBox cbbLoTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoiTuongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}
