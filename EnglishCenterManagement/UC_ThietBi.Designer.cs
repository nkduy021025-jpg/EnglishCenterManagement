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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimTB = new System.Windows.Forms.Button();
            this.btnLuuTB = new System.Windows.Forms.Button();
            this.btnSuaTB = new System.Windows.Forms.Button();
            this.btnXoaTB = new System.Windows.Forms.Button();
            this.btnThemTB = new System.Windows.Forms.Button();
            this.dgvDanhSachThietBi = new System.Windows.Forms.DataGridView();
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
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThietBi)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimTB
            // 
            this.btnTimTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTB.Location = new System.Drawing.Point(11, 161);
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
            this.btnLuuTB.Location = new System.Drawing.Point(11, 126);
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
            this.btnSuaTB.Location = new System.Drawing.Point(11, 91);
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
            this.btnXoaTB.Location = new System.Drawing.Point(11, 56);
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
            this.btnThemTB.Location = new System.Drawing.Point(11, 19);
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
            this.dgvDanhSachThietBi.Location = new System.Drawing.Point(19, 331);
            this.dgvDanhSachThietBi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSachThietBi.Name = "dgvDanhSachThietBi";
            this.dgvDanhSachThietBi.RowHeadersWidth = 51;
            this.dgvDanhSachThietBi.RowTemplate.Height = 24;
            this.dgvDanhSachThietBi.Size = new System.Drawing.Size(743, 136);
            this.dgvDanhSachThietBi.TabIndex = 92;
            this.dgvDanhSachThietBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachThietBi_CellClick);
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "Mới",
            "Đã qua sử dụng",
            "Hỏng",
            "Khác..."});
            this.cbbTinhTrang.Location = new System.Drawing.Point(427, 159);
            this.cbbTinhTrang.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(175, 21);
            this.cbbTinhTrang.TabIndex = 91;
            this.cbbTinhTrang.Text = "Mới";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(427, 119);
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
            this.txtGiaTien.Text = "20000000";
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Location = new System.Drawing.Point(132, 158);
            this.txtTenThietBi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Size = new System.Drawing.Size(175, 20);
            this.txtTenThietBi.TabIndex = 88;
            this.txtTenThietBi.Text = "Máy chiếu";
            // 
            // txtMaThietBi
            // 
            this.txtMaThietBi.Location = new System.Drawing.Point(132, 120);
            this.txtMaThietBi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaThietBi.Name = "txtMaThietBi";
            this.txtMaThietBi.Size = new System.Drawing.Size(175, 20);
            this.txtMaThietBi.TabIndex = 87;
            this.txtMaThietBi.Text = "TB00";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(322, 159);
            this.lblTinhTrang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(55, 13);
            this.lblTinhTrang.TabIndex = 86;
            this.lblTinhTrang.Text = "Tình trạng";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(322, 123);
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
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.txtTimKiem);
            this.grpChucNang.Controls.Add(this.cbbTimKiem);
            this.grpChucNang.Controls.Add(this.btnTimTB);
            this.grpChucNang.Controls.Add(this.btnLuuTB);
            this.grpChucNang.Controls.Add(this.btnSuaTB);
            this.grpChucNang.Controls.Add(this.btnXoaTB);
            this.grpChucNang.Controls.Add(this.btnThemTB);
            this.grpChucNang.Location = new System.Drawing.Point(605, 88);
            this.grpChucNang.Margin = new System.Windows.Forms.Padding(2);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Padding = new System.Windows.Forms.Padding(2);
            this.grpChucNang.Size = new System.Drawing.Size(157, 234);
            this.grpChucNang.TabIndex = 98;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(11, 197);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(130, 20);
            this.txtTimKiem.TabIndex = 99;
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Tìm theo mã",
            "Tìm theo tên",
            "Tìm theo tình trạng"});
            this.cbbTimKiem.Location = new System.Drawing.Point(86, 171);
            this.cbbTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(62, 21);
            this.cbbTimKiem.TabIndex = 98;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(19, 297);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(67, 25);
            this.btnLoad.TabIndex = 182;
            this.btnLoad.Text = "Làm mới ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 16);
            this.label1.TabIndex = 184;
            this.label1.Text = "---------------------------------------------------------------------------\r\n";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EnglishCenterManagement.Properties.Resources.z7257614198401_9f47daa8ab828779f1ab0654d6b1fe48;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(11, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 72);
            this.panel1.TabIndex = 185;
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
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.NgayNhap.DefaultCellStyle = dataGridViewCellStyle1;
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
            // UC_ThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grpChucNang);
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
            this.Size = new System.Drawing.Size(874, 552);
            this.Load += new System.EventHandler(this.UC_ThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThietBi)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.grpChucNang.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}
