namespace EnglishCenterManagement
{
    partial class UC_ThietBi
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
            this.btnTimTB = new System.Windows.Forms.Button();
            this.btnLuuTB = new System.Windows.Forms.Button();
            this.btnSuaTB = new System.Windows.Forms.Button();
            this.btnXoaTB = new System.Windows.Forms.Button();
            this.btnThemTB = new System.Windows.Forms.Button();
            this.dgvDanhSachThietBi = new System.Windows.Forms.DataGridView();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtTenThietBi = new System.Windows.Forms.TextBox();
            this.txtMaThietBi = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblTenThietBi = new System.Windows.Forms.Label();
            this.lblMaThietBi = new System.Windows.Forms.Label();
            this.lblQuanLyThietBi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bthTimThietBiTheoTen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimTB
            // 
            this.btnTimTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTB.Location = new System.Drawing.Point(656, 371);
            this.btnTimTB.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimTB.Name = "btnTimTB";
            this.btnTimTB.Size = new System.Drawing.Size(70, 32);
            this.btnTimTB.TabIndex = 97;
            this.btnTimTB.Text = "Tìm kiếm";
            this.btnTimTB.UseVisualStyleBackColor = true;
            this.btnTimTB.Click += new System.EventHandler(this.btnTimTB_Click);
            // 
            // btnLuuTB
            // 
            this.btnLuuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTB.Location = new System.Drawing.Point(656, 339);
            this.btnLuuTB.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuTB.Name = "btnLuuTB";
            this.btnLuuTB.Size = new System.Drawing.Size(70, 32);
            this.btnLuuTB.TabIndex = 96;
            this.btnLuuTB.Text = "Lưu";
            this.btnLuuTB.UseVisualStyleBackColor = true;
            this.btnLuuTB.Click += new System.EventHandler(this.btnLuuTB_Click);
            // 
            // btnSuaTB
            // 
            this.btnSuaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTB.Location = new System.Drawing.Point(656, 299);
            this.btnSuaTB.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaTB.Name = "btnSuaTB";
            this.btnSuaTB.Size = new System.Drawing.Size(70, 32);
            this.btnSuaTB.TabIndex = 95;
            this.btnSuaTB.Text = "Sửa";
            this.btnSuaTB.UseVisualStyleBackColor = true;
            this.btnSuaTB.Click += new System.EventHandler(this.btnSuaTB_Click);
            // 
            // btnXoaTB
            // 
            this.btnXoaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTB.Location = new System.Drawing.Point(656, 259);
            this.btnXoaTB.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(70, 32);
            this.btnXoaTB.TabIndex = 94;
            this.btnXoaTB.Text = "Xóa";
            this.btnXoaTB.UseVisualStyleBackColor = true;
            this.btnXoaTB.Click += new System.EventHandler(this.btnXoaTB_Click);
            // 
            // btnThemTB
            // 
            this.btnThemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTB.Location = new System.Drawing.Point(656, 219);
            this.btnThemTB.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(70, 32);
            this.btnThemTB.TabIndex = 93;
            this.btnThemTB.Text = "Thêm";
            this.btnThemTB.UseVisualStyleBackColor = true;
            this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // dgvDanhSachThietBi
            // 
            this.dgvDanhSachThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThietBi,
            this.TenThietBi,
            this.GiaTien,
            this.NgayNhap,
            this.TinhTrang});
            this.dgvDanhSachThietBi.Location = new System.Drawing.Point(19, 258);
            this.dgvDanhSachThietBi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSachThietBi.Name = "dgvDanhSachThietBi";
            this.dgvDanhSachThietBi.RowHeadersWidth = 51;
            this.dgvDanhSachThietBi.RowTemplate.Height = 24;
            this.dgvDanhSachThietBi.Size = new System.Drawing.Size(633, 136);
            this.dgvDanhSachThietBi.TabIndex = 92;
            this.dgvDanhSachThietBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachThietBi_CellClick);
            // 
            // MaThietBi
            // 
            this.MaThietBi.DataPropertyName = "maTB";
            this.MaThietBi.HeaderText = "Mã thiết bị";
            this.MaThietBi.MinimumWidth = 6;
            this.MaThietBi.Name = "MaThietBi";
            this.MaThietBi.Width = 125;
            // 
            // TenThietBi
            // 
            this.TenThietBi.DataPropertyName = "tenTB";
            this.TenThietBi.HeaderText = "Tên thiết bị";
            this.TenThietBi.MinimumWidth = 6;
            this.TenThietBi.Name = "TenThietBi";
            this.TenThietBi.Width = 125;
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "giaTien";
            this.GiaTien.HeaderText = "Giá tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.Width = 125;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "ngayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "tinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "Mới",
            "Đã qua sử dụng",
            "Hỏng"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(503, 162);
            this.cbbTinhTrang.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(175, 21);
            this.cbbTinhTrang.TabIndex = 91;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(503, 121);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(175, 20);
            this.dtpNgayNhap.TabIndex = 90;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(132, 197);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(175, 20);
            this.txtGiaTien.TabIndex = 89;
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Location = new System.Drawing.Point(132, 158);
            this.txtTenThietBi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Size = new System.Drawing.Size(175, 20);
            this.txtTenThietBi.TabIndex = 88;
            // 
            // txtMaThietBi
            // 
            this.txtMaThietBi.Location = new System.Drawing.Point(132, 120);
            this.txtMaThietBi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaThietBi.Name = "txtMaThietBi";
            this.txtMaThietBi.Size = new System.Drawing.Size(175, 20);
            this.txtMaThietBi.TabIndex = 87;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(398, 162);
            this.lblTinhTrang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(55, 13);
            this.lblTinhTrang.TabIndex = 86;
            this.lblTinhTrang.Text = "Tình trạng";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(398, 125);
            this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(59, 13);
            this.lblNgayNhap.TabIndex = 85;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Location = new System.Drawing.Point(51, 197);
            this.lblGiaTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(43, 13);
            this.lblGiaTien.TabIndex = 84;
            this.lblGiaTien.Text = "Giá tiền";
            // 
            // lblTenThietBi
            // 
            this.lblTenThietBi.AutoSize = true;
            this.lblTenThietBi.Location = new System.Drawing.Point(51, 162);
            this.lblTenThietBi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenThietBi.Name = "lblTenThietBi";
            this.lblTenThietBi.Size = new System.Drawing.Size(60, 13);
            this.lblTenThietBi.TabIndex = 83;
            this.lblTenThietBi.Text = "Tên thiết bị";
            // 
            // lblMaThietBi
            // 
            this.lblMaThietBi.AutoSize = true;
            this.lblMaThietBi.Location = new System.Drawing.Point(51, 125);
            this.lblMaThietBi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaThietBi.Name = "lblMaThietBi";
            this.lblMaThietBi.Size = new System.Drawing.Size(56, 13);
            this.lblMaThietBi.TabIndex = 82;
            this.lblMaThietBi.Text = "Mã thiết bị";
            // 
            // lblQuanLyThietBi
            // 
            this.lblQuanLyThietBi.AutoSize = true;
            this.lblQuanLyThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQuanLyThietBi.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblQuanLyThietBi.Location = new System.Drawing.Point(302, 70);
            this.lblQuanLyThietBi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuanLyThietBi.Name = "lblQuanLyThietBi";
            this.lblQuanLyThietBi.Size = new System.Drawing.Size(215, 31);
            this.lblQuanLyThietBi.TabIndex = 81;
            this.lblQuanLyThietBi.Text = "Quản Lý Thiết Bị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(145, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(587, 46);
            this.label4.TabIndex = 80;
            this.label4.Text = "ENGLISH CENTER DOUBLE D";
            // 
            // bthTimThietBiTheoTen
            // 
            this.bthTimThietBiTheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthTimThietBiTheoTen.Location = new System.Drawing.Point(749, 259);
            this.bthTimThietBiTheoTen.Margin = new System.Windows.Forms.Padding(2);
            this.bthTimThietBiTheoTen.Name = "bthTimThietBiTheoTen";
            this.bthTimThietBiTheoTen.Size = new System.Drawing.Size(115, 32);
            this.bthTimThietBiTheoTen.TabIndex = 99;
            this.bthTimThietBiTheoTen.Text = "Tìm theo tên thiết bị";
            this.bthTimThietBiTheoTen.UseVisualStyleBackColor = true;
            this.bthTimThietBiTheoTen.Click += new System.EventHandler(this.bthTimThietBiTheoTen_Click);
            // 
            // UC_ThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bthTimThietBiTheoTen);
            this.Controls.Add(this.btnTimTB);
            this.Controls.Add(this.btnLuuTB);
            this.Controls.Add(this.btnSuaTB);
            this.Controls.Add(this.btnXoaTB);
            this.Controls.Add(this.btnThemTB);
            this.Controls.Add(this.dgvDanhSachThietBi);
            this.Controls.Add(this.cbbTinhTrang);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.txtTenThietBi);
            this.Controls.Add(this.txtMaThietBi);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.lblTenThietBi);
            this.Controls.Add(this.lblMaThietBi);
            this.Controls.Add(this.lblQuanLyThietBi);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_ThietBi";
            this.Size = new System.Drawing.Size(881, 554);
            this.Load += new System.EventHandler(this.UC_ThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimTB;
        private System.Windows.Forms.Button btnLuuTB;
        private System.Windows.Forms.Button btnSuaTB;
        private System.Windows.Forms.Button btnXoaTB;
        private System.Windows.Forms.Button btnThemTB;
        private System.Windows.Forms.DataGridView dgvDanhSachThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtTenThietBi;
        private System.Windows.Forms.TextBox txtMaThietBi;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lblTenThietBi;
        private System.Windows.Forms.Label lblMaThietBi;
        private System.Windows.Forms.Label lblQuanLyThietBi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bthTimThietBiTheoTen;
    }
}
