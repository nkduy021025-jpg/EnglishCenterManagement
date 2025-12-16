namespace EnglishCenterManagement
{
    partial class UC_ThoiKhoaBieu
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
            this.btnTimTKB = new System.Windows.Forms.Button();
            this.btnLuuTKB = new System.Windows.Forms.Button();
            this.btnSuaTKB = new System.Windows.Forms.Button();
            this.btnXoaTKB = new System.Windows.Forms.Button();
            this.btnThemTKB = new System.Windows.Forms.Button();
            this.dgvTKB = new System.Windows.Forms.DataGridView();
            this.MaTKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBDHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaTKB = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblTenThietBi = new System.Windows.Forms.Label();
            this.lblMaThietBi = new System.Windows.Forms.Label();
            this.lblThoiKhoaBieu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTGBDH = new System.Windows.Forms.DateTimePicker();
            this.dtpTGKT = new System.Windows.Forms.DateTimePicker();
            this.cbbNgayHoc = new System.Windows.Forms.ComboBox();
            this.cbbCaHoc = new System.Windows.Forms.ComboBox();
            this.lblCaHoc = new System.Windows.Forms.Label();
            this.cbbPhongHoc = new System.Windows.Forms.ComboBox();
            this.cbbMaCTHoc = new System.Windows.Forms.ComboBox();
            this.lblMaChuongTrinh = new System.Windows.Forms.Label();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbChonTimKiemTKB = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimTKB
            // 
            this.btnTimTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTKB.Location = new System.Drawing.Point(21, 202);
            this.btnTimTKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimTKB.Name = "btnTimTKB";
            this.btnTimTKB.Size = new System.Drawing.Size(93, 37);
            this.btnTimTKB.TabIndex = 116;
            this.btnTimTKB.Text = "Tìm kiếm";
            this.btnTimTKB.UseVisualStyleBackColor = true;
            this.btnTimTKB.Click += new System.EventHandler(this.btnTimTKB_Click);
            // 
            // btnLuuTKB
            // 
            this.btnLuuTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTKB.Location = new System.Drawing.Point(21, 160);
            this.btnLuuTKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuTKB.Name = "btnLuuTKB";
            this.btnLuuTKB.Size = new System.Drawing.Size(93, 37);
            this.btnLuuTKB.TabIndex = 115;
            this.btnLuuTKB.Text = "Lưu";
            this.btnLuuTKB.UseVisualStyleBackColor = true;
            this.btnLuuTKB.Click += new System.EventHandler(this.btnLuuTKB_Click);
            // 
            // btnSuaTKB
            // 
            this.btnSuaTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTKB.Location = new System.Drawing.Point(21, 113);
            this.btnSuaTKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaTKB.Name = "btnSuaTKB";
            this.btnSuaTKB.Size = new System.Drawing.Size(93, 37);
            this.btnSuaTKB.TabIndex = 114;
            this.btnSuaTKB.Text = "Sửa";
            this.btnSuaTKB.UseVisualStyleBackColor = true;
            this.btnSuaTKB.Click += new System.EventHandler(this.btnSuaTKB_Click);
            // 
            // btnXoaTKB
            // 
            this.btnXoaTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTKB.Location = new System.Drawing.Point(21, 64);
            this.btnXoaTKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTKB.Name = "btnXoaTKB";
            this.btnXoaTKB.Size = new System.Drawing.Size(93, 37);
            this.btnXoaTKB.TabIndex = 113;
            this.btnXoaTKB.Text = "Xóa";
            this.btnXoaTKB.UseVisualStyleBackColor = true;
            this.btnXoaTKB.Click += new System.EventHandler(this.btnXoaTKB_Click);
            // 
            // btnThemTKB
            // 
            this.btnThemTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTKB.Location = new System.Drawing.Point(21, 15);
            this.btnThemTKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemTKB.Name = "btnThemTKB";
            this.btnThemTKB.Size = new System.Drawing.Size(93, 37);
            this.btnThemTKB.TabIndex = 112;
            this.btnThemTKB.Text = "Thêm";
            this.btnThemTKB.UseVisualStyleBackColor = true;
            this.btnThemTKB.Click += new System.EventHandler(this.btnThemTKB_Click);
            // 
            // dgvTKB
            // 
            this.dgvTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTKB,
            this.ThoiGianBDHoc,
            this.ThoiGianKT,
            this.MaCTH,
            this.NgayHoc,
            this.CaHoc,
            this.PhongHoc});
            this.dgvTKB.Location = new System.Drawing.Point(12, 373);
            this.dgvTKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.RowHeadersWidth = 51;
            this.dgvTKB.RowTemplate.Height = 24;
            this.dgvTKB.Size = new System.Drawing.Size(930, 220);
            this.dgvTKB.TabIndex = 111;
            this.dgvTKB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTKB_CellClick);
            // 
            // MaTKB
            // 
            this.MaTKB.DataPropertyName = "MaThoiKhoaBieu";
            this.MaTKB.HeaderText = "Mã thời khóa biểu";
            this.MaTKB.MinimumWidth = 6;
            this.MaTKB.Name = "MaTKB";
            this.MaTKB.ReadOnly = true;
            this.MaTKB.Width = 125;
            // 
            // ThoiGianBDHoc
            // 
            this.ThoiGianBDHoc.DataPropertyName = "NgayBatDauHoc";
            this.ThoiGianBDHoc.HeaderText = "Thời gian bắt đầu học";
            this.ThoiGianBDHoc.MinimumWidth = 6;
            this.ThoiGianBDHoc.Name = "ThoiGianBDHoc";
            this.ThoiGianBDHoc.ReadOnly = true;
            this.ThoiGianBDHoc.Width = 125;
            // 
            // ThoiGianKT
            // 
            this.ThoiGianKT.DataPropertyName = "NgayKetThuc";
            this.ThoiGianKT.HeaderText = "Thời gian kết thúc";
            this.ThoiGianKT.MinimumWidth = 6;
            this.ThoiGianKT.Name = "ThoiGianKT";
            this.ThoiGianKT.ReadOnly = true;
            this.ThoiGianKT.Width = 125;
            // 
            // MaCTH
            // 
            this.MaCTH.DataPropertyName = "MaChuongTrinhHoc";
            this.MaCTH.HeaderText = "Mã chương trình học";
            this.MaCTH.MinimumWidth = 6;
            this.MaCTH.Name = "MaCTH";
            this.MaCTH.ReadOnly = true;
            this.MaCTH.Width = 125;
            // 
            // NgayHoc
            // 
            this.NgayHoc.DataPropertyName = "NgayHoc";
            this.NgayHoc.HeaderText = "Ngày học";
            this.NgayHoc.MinimumWidth = 6;
            this.NgayHoc.Name = "NgayHoc";
            this.NgayHoc.ReadOnly = true;
            this.NgayHoc.Width = 125;
            // 
            // CaHoc
            // 
            this.CaHoc.DataPropertyName = "CaHoc";
            this.CaHoc.HeaderText = "Ca học";
            this.CaHoc.MinimumWidth = 6;
            this.CaHoc.Name = "CaHoc";
            this.CaHoc.ReadOnly = true;
            this.CaHoc.Width = 125;
            // 
            // PhongHoc
            // 
            this.PhongHoc.DataPropertyName = "PhongHoc";
            this.PhongHoc.HeaderText = "Phòng học";
            this.PhongHoc.MinimumWidth = 6;
            this.PhongHoc.Name = "PhongHoc";
            this.PhongHoc.ReadOnly = true;
            this.PhongHoc.Width = 125;
            // 
            // txtMaTKB
            // 
            this.txtMaTKB.Location = new System.Drawing.Point(163, 144);
            this.txtMaTKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTKB.Name = "txtMaTKB";
            this.txtMaTKB.Size = new System.Drawing.Size(232, 22);
            this.txtMaTKB.TabIndex = 106;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(407, 196);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(49, 16);
            this.lblTinhTrang.TabIndex = 105;
            this.lblTinhTrang.Text = "Ca học";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(407, 150);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(65, 16);
            this.lblNgayNhap.TabIndex = 104;
            this.lblNgayNhap.Text = "Ngày học";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Location = new System.Drawing.Point(5, 245);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(111, 16);
            this.lblGiaTien.TabIndex = 103;
            this.lblGiaTien.Text = "Thời gian kết thúc";
            // 
            // lblTenThietBi
            // 
            this.lblTenThietBi.AutoSize = true;
            this.lblTenThietBi.Location = new System.Drawing.Point(3, 193);
            this.lblTenThietBi.Name = "lblTenThietBi";
            this.lblTenThietBi.Size = new System.Drawing.Size(136, 16);
            this.lblTenThietBi.TabIndex = 102;
            this.lblTenThietBi.Text = "Thời gian bắt đầu học";
            // 
            // lblMaThietBi
            // 
            this.lblMaThietBi.AutoSize = true;
            this.lblMaThietBi.Location = new System.Drawing.Point(3, 150);
            this.lblMaThietBi.Name = "lblMaThietBi";
            this.lblMaThietBi.Size = new System.Drawing.Size(115, 16);
            this.lblMaThietBi.TabIndex = 101;
            this.lblMaThietBi.Text = " Mã thời khóa biểu";
            // 
            // lblThoiKhoaBieu
            // 
            this.lblThoiKhoaBieu.AutoSize = true;
            this.lblThoiKhoaBieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblThoiKhoaBieu.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblThoiKhoaBieu.Location = new System.Drawing.Point(373, 80);
            this.lblThoiKhoaBieu.Name = "lblThoiKhoaBieu";
            this.lblThoiKhoaBieu.Size = new System.Drawing.Size(241, 39);
            this.lblThoiKhoaBieu.TabIndex = 100;
            this.lblThoiKhoaBieu.Text = "Thời khóa biểu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(164, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(729, 58);
            this.label4.TabIndex = 99;
            this.label4.Text = "ENGLISH CENTER DOUBLE D";
            // 
            // dtpTGBDH
            // 
            this.dtpTGBDH.Location = new System.Drawing.Point(163, 193);
            this.dtpTGBDH.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTGBDH.Name = "dtpTGBDH";
            this.dtpTGBDH.Size = new System.Drawing.Size(231, 22);
            this.dtpTGBDH.TabIndex = 118;
            // 
            // dtpTGKT
            // 
            this.dtpTGKT.Location = new System.Drawing.Point(163, 245);
            this.dtpTGKT.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTGKT.Name = "dtpTGKT";
            this.dtpTGKT.Size = new System.Drawing.Size(231, 22);
            this.dtpTGKT.TabIndex = 119;
            // 
            // cbbNgayHoc
            // 
            this.cbbNgayHoc.FormattingEnabled = true;
            this.cbbNgayHoc.Items.AddRange(new object[] {
            "Thứ 2, 4, 6",
            "Thứ 3, 5, 7",
            ""});
            this.cbbNgayHoc.Location = new System.Drawing.Point(528, 146);
            this.cbbNgayHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNgayHoc.Name = "cbbNgayHoc";
            this.cbbNgayHoc.Size = new System.Drawing.Size(232, 24);
            this.cbbNgayHoc.TabIndex = 120;
            // 
            // cbbCaHoc
            // 
            this.cbbCaHoc.FormattingEnabled = true;
            this.cbbCaHoc.Items.AddRange(new object[] {
            "Ca 1 (8h - 10h)",
            "Ca 2 (13h30 - 15h30)",
            "Ca 3 (17h30 - 19h30)",
            "Ca 4 (20h - 22h)"});
            this.cbbCaHoc.Location = new System.Drawing.Point(528, 197);
            this.cbbCaHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCaHoc.Name = "cbbCaHoc";
            this.cbbCaHoc.Size = new System.Drawing.Size(232, 24);
            this.cbbCaHoc.TabIndex = 121;
            // 
            // lblCaHoc
            // 
            this.lblCaHoc.AutoSize = true;
            this.lblCaHoc.Location = new System.Drawing.Point(407, 245);
            this.lblCaHoc.Name = "lblCaHoc";
            this.lblCaHoc.Size = new System.Drawing.Size(71, 16);
            this.lblCaHoc.TabIndex = 122;
            this.lblCaHoc.Text = "Phòng học";
            // 
            // cbbPhongHoc
            // 
            this.cbbPhongHoc.FormattingEnabled = true;
            this.cbbPhongHoc.Items.AddRange(new object[] {
            "PA.1",
            "PA.2",
            "PB.1",
            "PB.2",
            "PC.1"});
            this.cbbPhongHoc.Location = new System.Drawing.Point(528, 241);
            this.cbbPhongHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPhongHoc.Name = "cbbPhongHoc";
            this.cbbPhongHoc.Size = new System.Drawing.Size(232, 24);
            this.cbbPhongHoc.TabIndex = 123;
            // 
            // cbbMaCTHoc
            // 
            this.cbbMaCTHoc.FormattingEnabled = true;
            this.cbbMaCTHoc.Location = new System.Drawing.Point(163, 297);
            this.cbbMaCTHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaCTHoc.Name = "cbbMaCTHoc";
            this.cbbMaCTHoc.Size = new System.Drawing.Size(224, 24);
            this.cbbMaCTHoc.TabIndex = 124;
            // 
            // lblMaChuongTrinh
            // 
            this.lblMaChuongTrinh.AutoSize = true;
            this.lblMaChuongTrinh.Location = new System.Drawing.Point(5, 306);
            this.lblMaChuongTrinh.Name = "lblMaChuongTrinh";
            this.lblMaChuongTrinh.Size = new System.Drawing.Size(125, 16);
            this.lblMaChuongTrinh.TabIndex = 125;
            this.lblMaChuongTrinh.Text = "Mã chương trình học";
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.txtTimKiem);
            this.grpChucNang.Controls.Add(this.cbbChonTimKiemTKB);
            this.grpChucNang.Controls.Add(this.btnTimTKB);
            this.grpChucNang.Controls.Add(this.btnLuuTKB);
            this.grpChucNang.Controls.Add(this.btnSuaTKB);
            this.grpChucNang.Controls.Add(this.btnXoaTKB);
            this.grpChucNang.Controls.Add(this.btnThemTKB);
            this.grpChucNang.Location = new System.Drawing.Point(769, 80);
            this.grpChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Padding = new System.Windows.Forms.Padding(4);
            this.grpChucNang.Size = new System.Drawing.Size(266, 287);
            this.grpChucNang.TabIndex = 126;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(21, 245);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(137, 22);
            this.txtTimKiem.TabIndex = 118;
            // 
            // cbbChonTimKiemTKB
            // 
            this.cbbChonTimKiemTKB.FormattingEnabled = true;
            this.cbbChonTimKiemTKB.Items.AddRange(new object[] {
            "Theo mã thời khóa biểu",
            "Theo mã chương trình học",
            "Theo phòng học",
            "Theo ca học"});
            this.cbbChonTimKiemTKB.Location = new System.Drawing.Point(134, 209);
            this.cbbChonTimKiemTKB.Margin = new System.Windows.Forms.Padding(4);
            this.cbbChonTimKiemTKB.Name = "cbbChonTimKiemTKB";
            this.cbbChonTimKiemTKB.Size = new System.Drawing.Size(121, 24);
            this.cbbChonTimKiemTKB.TabIndex = 117;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 337);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 31);
            this.btnLoad.TabIndex = 179;
            this.btnLoad.Text = "Làm mới ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // UC_ThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.lblMaChuongTrinh);
            this.Controls.Add(this.cbbMaCTHoc);
            this.Controls.Add(this.cbbPhongHoc);
            this.Controls.Add(this.lblCaHoc);
            this.Controls.Add(this.cbbCaHoc);
            this.Controls.Add(this.cbbNgayHoc);
            this.Controls.Add(this.dtpTGKT);
            this.Controls.Add(this.dtpTGBDH);
            this.Controls.Add(this.dgvTKB);
            this.Controls.Add(this.txtMaTKB);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.lblTenThietBi);
            this.Controls.Add(this.lblMaThietBi);
            this.Controls.Add(this.lblThoiKhoaBieu);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ThoiKhoaBieu";
            this.Size = new System.Drawing.Size(1141, 662);
            this.Load += new System.EventHandler(this.UC_ThoiKhoaBieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.grpChucNang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimTKB;
        private System.Windows.Forms.Button btnLuuTKB;
        private System.Windows.Forms.Button btnSuaTKB;
        private System.Windows.Forms.Button btnXoaTKB;
        private System.Windows.Forms.Button btnThemTKB;
        private System.Windows.Forms.DataGridView dgvTKB;
        private System.Windows.Forms.TextBox txtMaTKB;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lblTenThietBi;
        private System.Windows.Forms.Label lblMaThietBi;
        private System.Windows.Forms.Label lblThoiKhoaBieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTGBDH;
        private System.Windows.Forms.DateTimePicker dtpTGKT;
        private System.Windows.Forms.ComboBox cbbNgayHoc;
        private System.Windows.Forms.ComboBox cbbCaHoc;
        private System.Windows.Forms.Label lblCaHoc;
        private System.Windows.Forms.ComboBox cbbPhongHoc;
        private System.Windows.Forms.ComboBox cbbMaCTHoc;
        private System.Windows.Forms.Label lblMaChuongTrinh;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbbChonTimKiemTKB;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBDHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongHoc;
        private System.Windows.Forms.Button btnLoad;
    }
}
