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
            this.btnDocFileTB = new System.Windows.Forms.Button();
            this.btnTimTB = new System.Windows.Forms.Button();
            this.btnLuuTB = new System.Windows.Forms.Button();
            this.btnSuaTB = new System.Windows.Forms.Button();
            this.btnXoaTB = new System.Windows.Forms.Button();
            this.btnThemTB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDocFileTB
            // 
            this.btnDocFileTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFileTB.Location = new System.Drawing.Point(874, 502);
            this.btnDocFileTB.Name = "btnDocFileTB";
            this.btnDocFileTB.Size = new System.Drawing.Size(94, 35);
            this.btnDocFileTB.TabIndex = 98;
            this.btnDocFileTB.Text = "Đọc File";
            this.btnDocFileTB.UseVisualStyleBackColor = true;
            // 
            // btnTimTB
            // 
            this.btnTimTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTB.Location = new System.Drawing.Point(874, 457);
            this.btnTimTB.Name = "btnTimTB";
            this.btnTimTB.Size = new System.Drawing.Size(94, 39);
            this.btnTimTB.TabIndex = 97;
            this.btnTimTB.Text = "Tìm kiếm";
            this.btnTimTB.UseVisualStyleBackColor = true;
            // 
            // btnLuuTB
            // 
            this.btnLuuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTB.Location = new System.Drawing.Point(874, 417);
            this.btnLuuTB.Name = "btnLuuTB";
            this.btnLuuTB.Size = new System.Drawing.Size(94, 39);
            this.btnLuuTB.TabIndex = 96;
            this.btnLuuTB.Text = "Lưu";
            this.btnLuuTB.UseVisualStyleBackColor = true;
            // 
            // btnSuaTB
            // 
            this.btnSuaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTB.Location = new System.Drawing.Point(874, 368);
            this.btnSuaTB.Name = "btnSuaTB";
            this.btnSuaTB.Size = new System.Drawing.Size(94, 39);
            this.btnSuaTB.TabIndex = 95;
            this.btnSuaTB.Text = "Sửa";
            this.btnSuaTB.UseVisualStyleBackColor = true;
            // 
            // btnXoaTB
            // 
            this.btnXoaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTB.Location = new System.Drawing.Point(874, 319);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(94, 39);
            this.btnXoaTB.TabIndex = 94;
            this.btnXoaTB.Text = "Xóa";
            this.btnXoaTB.UseVisualStyleBackColor = true;
            // 
            // btnThemTB
            // 
            this.btnThemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTB.Location = new System.Drawing.Point(874, 270);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(94, 39);
            this.btnThemTB.TabIndex = 93;
            this.btnThemTB.Text = "Thêm";
            this.btnThemTB.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThietBi,
            this.TenThietBi,
            this.GiaTien,
            this.NgayNhap,
            this.TinhTrang});
            this.dataGridView1.Location = new System.Drawing.Point(71, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(689, 320);
            this.dataGridView1.TabIndex = 92;
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
            this.cbbTinhTrang.Location = new System.Drawing.Point(671, 200);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(232, 24);
            this.cbbTinhTrang.TabIndex = 91;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(671, 149);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(232, 22);
            this.dtpNgayNhap.TabIndex = 90;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(176, 242);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(232, 22);
            this.txtGiaTien.TabIndex = 89;
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Location = new System.Drawing.Point(176, 194);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Size = new System.Drawing.Size(232, 22);
            this.txtTenThietBi.TabIndex = 88;
            // 
            // txtMaThietBi
            // 
            this.txtMaThietBi.Location = new System.Drawing.Point(176, 148);
            this.txtMaThietBi.Name = "txtMaThietBi";
            this.txtMaThietBi.Size = new System.Drawing.Size(232, 22);
            this.txtMaThietBi.TabIndex = 87;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(531, 200);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(66, 16);
            this.lblTinhTrang.TabIndex = 86;
            this.lblTinhTrang.Text = "Tình trạng";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(531, 154);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(73, 16);
            this.lblNgayNhap.TabIndex = 85;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Location = new System.Drawing.Point(68, 242);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(52, 16);
            this.lblGiaTien.TabIndex = 84;
            this.lblGiaTien.Text = "Giá tiền";
            // 
            // lblTenThietBi
            // 
            this.lblTenThietBi.AutoSize = true;
            this.lblTenThietBi.Location = new System.Drawing.Point(68, 200);
            this.lblTenThietBi.Name = "lblTenThietBi";
            this.lblTenThietBi.Size = new System.Drawing.Size(72, 16);
            this.lblTenThietBi.TabIndex = 83;
            this.lblTenThietBi.Text = "Tên thiết bị";
            // 
            // lblMaThietBi
            // 
            this.lblMaThietBi.AutoSize = true;
            this.lblMaThietBi.Location = new System.Drawing.Point(68, 154);
            this.lblMaThietBi.Name = "lblMaThietBi";
            this.lblMaThietBi.Size = new System.Drawing.Size(67, 16);
            this.lblMaThietBi.TabIndex = 82;
            this.lblMaThietBi.Text = "Mã thiết bị";
            // 
            // lblQuanLyThietBi
            // 
            this.lblQuanLyThietBi.AutoSize = true;
            this.lblQuanLyThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQuanLyThietBi.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblQuanLyThietBi.Location = new System.Drawing.Point(403, 86);
            this.lblQuanLyThietBi.Name = "lblQuanLyThietBi";
            this.lblQuanLyThietBi.Size = new System.Drawing.Size(270, 39);
            this.lblQuanLyThietBi.TabIndex = 81;
            this.lblQuanLyThietBi.Text = "Quản Lý Thiết Bị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(193, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(729, 58);
            this.label4.TabIndex = 80;
            this.label4.Text = "ENGLISH CENTER DOUBLE D";
            // 
            // UC_ThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDocFileTB);
            this.Controls.Add(this.btnTimTB);
            this.Controls.Add(this.btnLuuTB);
            this.Controls.Add(this.btnSuaTB);
            this.Controls.Add(this.btnXoaTB);
            this.Controls.Add(this.btnThemTB);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "UC_ThietBi";
            this.Size = new System.Drawing.Size(1065, 682);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDocFileTB;
        private System.Windows.Forms.Button btnTimTB;
        private System.Windows.Forms.Button btnLuuTB;
        private System.Windows.Forms.Button btnSuaTB;
        private System.Windows.Forms.Button btnXoaTB;
        private System.Windows.Forms.Button btnThemTB;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}
