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
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongTrinh)).BeginInit();
            this.grpTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMoTaCTH
            // 
            this.txtMoTaCTH.Location = new System.Drawing.Point(568, 277);
            this.txtMoTaCTH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoTaCTH.Name = "txtMoTaCTH";
            this.txtMoTaCTH.Size = new System.Drawing.Size(232, 22);
            this.txtMoTaCTH.TabIndex = 168;
            this.txtMoTaCTH.Text = "Dành cho người mất gốc";
            // 
            // lblMoTaChuongTrinh
            // 
            this.lblMoTaChuongTrinh.AutoSize = true;
            this.lblMoTaChuongTrinh.Location = new System.Drawing.Point(456, 281);
            this.lblMoTaChuongTrinh.Name = "lblMoTaChuongTrinh";
            this.lblMoTaChuongTrinh.Size = new System.Drawing.Size(43, 16);
            this.lblMoTaChuongTrinh.TabIndex = 165;
            this.lblMoTaChuongTrinh.Text = "Mô tả \r\n";
            // 
            // btnLuuChuongTrinh
            // 
            this.btnLuuChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuChuongTrinh.Location = new System.Drawing.Point(20, 155);
            this.btnLuuChuongTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuChuongTrinh.Name = "btnLuuChuongTrinh";
            this.btnLuuChuongTrinh.Size = new System.Drawing.Size(93, 37);
            this.btnLuuChuongTrinh.TabIndex = 160;
            this.btnLuuChuongTrinh.Text = "Lưu";
            this.btnLuuChuongTrinh.UseVisualStyleBackColor = true;
            this.btnLuuChuongTrinh.Click += new System.EventHandler(this.btnLuuChuongTrinh_Click);
            // 
            // btnSuaChuongTrinh
            // 
            this.btnSuaChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChuongTrinh.Location = new System.Drawing.Point(20, 108);
            this.btnSuaChuongTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaChuongTrinh.Name = "btnSuaChuongTrinh";
            this.btnSuaChuongTrinh.Size = new System.Drawing.Size(93, 37);
            this.btnSuaChuongTrinh.TabIndex = 159;
            this.btnSuaChuongTrinh.Text = "Sửa";
            this.btnSuaChuongTrinh.UseVisualStyleBackColor = true;
            this.btnSuaChuongTrinh.Click += new System.EventHandler(this.btnSuaChuongTrinh_Click);
            // 
            // btnXoaChuongTrinh
            // 
            this.btnXoaChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChuongTrinh.Location = new System.Drawing.Point(19, 64);
            this.btnXoaChuongTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaChuongTrinh.Name = "btnXoaChuongTrinh";
            this.btnXoaChuongTrinh.Size = new System.Drawing.Size(93, 37);
            this.btnXoaChuongTrinh.TabIndex = 158;
            this.btnXoaChuongTrinh.Text = "Xóa";
            this.btnXoaChuongTrinh.UseVisualStyleBackColor = true;
            this.btnXoaChuongTrinh.Click += new System.EventHandler(this.btnXoaChuongTrinh_Click);
            // 
            // btnThemChuongTrinh
            // 
            this.btnThemChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChuongTrinh.Location = new System.Drawing.Point(20, 22);
            this.btnThemChuongTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemChuongTrinh.Name = "btnThemChuongTrinh";
            this.btnThemChuongTrinh.Size = new System.Drawing.Size(93, 37);
            this.btnThemChuongTrinh.TabIndex = 157;
            this.btnThemChuongTrinh.Text = "Thêm";
            this.btnThemChuongTrinh.UseVisualStyleBackColor = true;
            this.btnThemChuongTrinh.Click += new System.EventHandler(this.btnThemChuongTrinh_Click);
            // 
            // txtMaChuongTrinhHoc
            // 
            this.txtMaChuongTrinhHoc.Location = new System.Drawing.Point(211, 177);
            this.txtMaChuongTrinhHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaChuongTrinhHoc.Name = "txtMaChuongTrinhHoc";
            this.txtMaChuongTrinhHoc.Size = new System.Drawing.Size(232, 22);
            this.txtMaChuongTrinhHoc.TabIndex = 155;
            this.txtMaChuongTrinhHoc.Text = "CT00";
            // 
            // lblMucDich
            // 
            this.lblMucDich.AutoSize = true;
            this.lblMucDich.Location = new System.Drawing.Point(456, 233);
            this.lblMucDich.Name = "lblMucDich";
            this.lblMucDich.Size = new System.Drawing.Size(53, 16);
            this.lblMucDich.TabIndex = 154;
            this.lblMucDich.Text = "Học phí";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(456, 187);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(88, 16);
            this.lblNgayNhap.TabIndex = 153;
            this.lblNgayNhap.Text = "Đối tượng học";
            // 
            // lblNgayThuChi
            // 
            this.lblNgayThuChi.AutoSize = true;
            this.lblNgayThuChi.Location = new System.Drawing.Point(51, 277);
            this.lblNgayThuChi.Name = "lblNgayThuChi";
            this.lblNgayThuChi.Size = new System.Drawing.Size(88, 16);
            this.lblNgayThuChi.TabIndex = 152;
            this.lblNgayThuChi.Text = "Thời gian học";
            // 
            // lblLuaChonThuChi
            // 
            this.lblLuaChonThuChi.AutoSize = true;
            this.lblLuaChonThuChi.Location = new System.Drawing.Point(51, 233);
            this.lblLuaChonThuChi.Name = "lblLuaChonThuChi";
            this.lblLuaChonThuChi.Size = new System.Drawing.Size(0, 16);
            this.lblLuaChonThuChi.TabIndex = 151;
            // 
            // lblMaThietBi
            // 
            this.lblMaThietBi.AutoSize = true;
            this.lblMaThietBi.Location = new System.Drawing.Point(51, 183);
            this.lblMaThietBi.Name = "lblMaThietBi";
            this.lblMaThietBi.Size = new System.Drawing.Size(125, 16);
            this.lblMaThietBi.TabIndex = 150;
            this.lblMaThietBi.Text = "Mã chương trình học";
            // 
            // lblThoiKhoaBieu
            // 
            this.lblThoiKhoaBieu.AutoSize = true;
            this.lblThoiKhoaBieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblThoiKhoaBieu.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblThoiKhoaBieu.Location = new System.Drawing.Point(409, 113);
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
            this.label4.Location = new System.Drawing.Point(200, 46);
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
            this.dgvChuongTrinh.Location = new System.Drawing.Point(27, 436);
            this.dgvChuongTrinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvChuongTrinh.Name = "dgvChuongTrinh";
            this.dgvChuongTrinh.Size = new System.Drawing.Size(749, 218);
            this.dgvChuongTrinh.TabIndex = 169;
            this.dgvChuongTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuongTrinh_CellClick);
            // 
            // MaChuongTrinh
            // 
            this.MaChuongTrinh.DataPropertyName = "MaChuongTrinh";
            this.MaChuongTrinh.HeaderText = "Mã chương trình";
            this.MaChuongTrinh.Name = "MaChuongTrinh";
            this.MaChuongTrinh.ReadOnly = true;
            // 
            // TenChuongTrinh
            // 
            this.TenChuongTrinh.DataPropertyName = "TenChuongTrinh";
            this.TenChuongTrinh.HeaderText = "Tên chương trình ";
            this.TenChuongTrinh.Name = "TenChuongTrinh";
            this.TenChuongTrinh.ReadOnly = true;
            // 
            // LoTrinh
            // 
            this.LoTrinh.DataPropertyName = "LoTrinhHoc";
            this.LoTrinh.HeaderText = "Lộ trình học";
            this.LoTrinh.Name = "LoTrinh";
            this.LoTrinh.ReadOnly = true;
            // 
            // ThoiGianHoc
            // 
            this.ThoiGianHoc.DataPropertyName = "ThoiGianHoc";
            this.ThoiGianHoc.HeaderText = "Thời gian học";
            this.ThoiGianHoc.Name = "ThoiGianHoc";
            this.ThoiGianHoc.ReadOnly = true;
            // 
            // DoiTuongHoc
            // 
            this.DoiTuongHoc.HeaderText = "Đối tượng học";
            this.DoiTuongHoc.Name = "DoiTuongHoc";
            this.DoiTuongHoc.ReadOnly = true;
            // 
            // HocPhi
            // 
            this.HocPhi.DataPropertyName = "HocPhi";
            this.HocPhi.HeaderText = "Học phí";
            this.HocPhi.Name = "HocPhi";
            this.HocPhi.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả chương trình học";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
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
            this.cbbThoiGianHoc.Location = new System.Drawing.Point(211, 278);
            this.cbbThoiGianHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbThoiGianHoc.Name = "cbbThoiGianHoc";
            this.cbbThoiGianHoc.Size = new System.Drawing.Size(232, 24);
            this.cbbThoiGianHoc.TabIndex = 171;
            // 
            // txtTenChuongTrinhHoc
            // 
            this.txtTenChuongTrinhHoc.Location = new System.Drawing.Point(211, 220);
            this.txtTenChuongTrinhHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenChuongTrinhHoc.Name = "txtTenChuongTrinhHoc";
            this.txtTenChuongTrinhHoc.Size = new System.Drawing.Size(232, 22);
            this.txtTenChuongTrinhHoc.TabIndex = 173;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.Location = new System.Drawing.Point(568, 224);
            this.txtHocPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Size = new System.Drawing.Size(232, 22);
            this.txtHocPhi.TabIndex = 174;
            this.txtHocPhi.Text = "2000000";
            // 
            // cbbDoiTuongHoc
            // 
            this.cbbDoiTuongHoc.FormattingEnabled = true;
            this.cbbDoiTuongHoc.Items.AddRange(new object[] {
            "Học sinh",
            "Sinh viên",
            "Người đã đi làm"});
            this.cbbDoiTuongHoc.Location = new System.Drawing.Point(568, 176);
            this.cbbDoiTuongHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbDoiTuongHoc.Name = "cbbDoiTuongHoc";
            this.cbbDoiTuongHoc.Size = new System.Drawing.Size(232, 24);
            this.cbbDoiTuongHoc.TabIndex = 172;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(51, 329);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(74, 16);
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
            this.cbbLoTrinh.Location = new System.Drawing.Point(211, 325);
            this.cbbLoTrinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbLoTrinh.Name = "cbbLoTrinh";
            this.cbbLoTrinh.Size = new System.Drawing.Size(232, 24);
            this.cbbLoTrinh.TabIndex = 176;
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
            this.grpTimKiem.Location = new System.Drawing.Point(809, 139);
            this.grpTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTimKiem.Size = new System.Drawing.Size(259, 289);
            this.grpTimKiem.TabIndex = 177;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Chức năng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(20, 240);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(119, 22);
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
            this.cbbTimKiem.Location = new System.Drawing.Point(120, 204);
            this.cbbTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(129, 24);
            this.cbbTimKiem.TabIndex = 162;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(20, 197);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 37);
            this.btnTimKiem.TabIndex = 161;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(27, 397);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 31);
            this.btnLoad.TabIndex = 178;
            this.btnLoad.Text = "Làm mới ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // UC_ChuongTrinhHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_ChuongTrinhHoc";
            this.Size = new System.Drawing.Size(1155, 719);
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
    }
}
