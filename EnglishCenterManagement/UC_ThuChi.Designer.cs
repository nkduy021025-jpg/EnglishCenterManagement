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
            this.cbbCaHoc = new System.Windows.Forms.ComboBox();
            this.dtpNgayThuChi = new System.Windows.Forms.DateTimePicker();
            this.btnDocFileTB = new System.Windows.Forms.Button();
            this.btnTimTB = new System.Windows.Forms.Button();
            this.btnLuuTB = new System.Windows.Forms.Button();
            this.btnSuaTB = new System.Windows.Forms.Button();
            this.btnXoaTB = new System.Windows.Forms.Button();
            this.btnThemTB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblMucDich = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblNgayThuChi = new System.Windows.Forms.Label();
            this.lblLuaChonThuChi = new System.Windows.Forms.Label();
            this.lblMaThietBi = new System.Windows.Forms.Label();
            this.lblThoiKhoaBieu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbThuChi = new System.Windows.Forms.ComboBox();
            this.txtSoTienThuChi = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(402, 232);
            this.lblNoiDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(87, 13);
            this.lblNoiDung.TabIndex = 143;
            this.lblNoiDung.Text = "Nội dung thu/chi";
            // 
            // cbbCaHoc
            // 
            this.cbbCaHoc.FormattingEnabled = true;
            this.cbbCaHoc.Items.AddRange(new object[] {
            "Thu học phí học viên",
            "Thu mua/bán cơ sở vật chất",
            "Bảo trì cơ sở vật chất",
            "Hoàn học phí cho học viên",
            "Lương cho nhân viên",
            "Khác"});
            this.cbbCaHoc.Location = new System.Drawing.Point(508, 187);
            this.cbbCaHoc.Name = "cbbCaHoc";
            this.cbbCaHoc.Size = new System.Drawing.Size(175, 21);
            this.cbbCaHoc.TabIndex = 142;
            // 
            // dtpNgayThuChi
            // 
            this.dtpNgayThuChi.Location = new System.Drawing.Point(157, 225);
            this.dtpNgayThuChi.Name = "dtpNgayThuChi";
            this.dtpNgayThuChi.Size = new System.Drawing.Size(174, 20);
            this.dtpNgayThuChi.TabIndex = 140;
            // 
            // btnDocFileTB
            // 
            this.btnDocFileTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFileTB.Location = new System.Drawing.Point(732, 324);
            this.btnDocFileTB.Margin = new System.Windows.Forms.Padding(2);
            this.btnDocFileTB.Name = "btnDocFileTB";
            this.btnDocFileTB.Size = new System.Drawing.Size(70, 26);
            this.btnDocFileTB.TabIndex = 138;
            this.btnDocFileTB.Text = "Đọc File";
            this.btnDocFileTB.UseVisualStyleBackColor = true;
            // 
            // btnTimTB
            // 
            this.btnTimTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTB.Location = new System.Drawing.Point(732, 287);
            this.btnTimTB.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimTB.Name = "btnTimTB";
            this.btnTimTB.Size = new System.Drawing.Size(70, 30);
            this.btnTimTB.TabIndex = 137;
            this.btnTimTB.Text = "Tìm kiếm";
            this.btnTimTB.UseVisualStyleBackColor = true;
            // 
            // btnLuuTB
            // 
            this.btnLuuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTB.Location = new System.Drawing.Point(732, 253);
            this.btnLuuTB.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuTB.Name = "btnLuuTB";
            this.btnLuuTB.Size = new System.Drawing.Size(70, 30);
            this.btnLuuTB.TabIndex = 136;
            this.btnLuuTB.Text = "Lưu";
            this.btnLuuTB.UseVisualStyleBackColor = true;
            // 
            // btnSuaTB
            // 
            this.btnSuaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTB.Location = new System.Drawing.Point(732, 215);
            this.btnSuaTB.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaTB.Name = "btnSuaTB";
            this.btnSuaTB.Size = new System.Drawing.Size(70, 30);
            this.btnSuaTB.TabIndex = 135;
            this.btnSuaTB.Text = "Sửa";
            this.btnSuaTB.UseVisualStyleBackColor = true;
            // 
            // btnXoaTB
            // 
            this.btnXoaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTB.Location = new System.Drawing.Point(732, 175);
            this.btnXoaTB.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(70, 30);
            this.btnXoaTB.TabIndex = 134;
            this.btnXoaTB.Text = "Xóa";
            this.btnXoaTB.UseVisualStyleBackColor = true;
            // 
            // btnThemTB
            // 
            this.btnThemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTB.Location = new System.Drawing.Point(732, 135);
            this.btnThemTB.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(70, 30);
            this.btnThemTB.TabIndex = 133;
            this.btnThemTB.Text = "Thêm";
            this.btnThemTB.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 281);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 260);
            this.dataGridView1.TabIndex = 132;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(157, 150);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(175, 20);
            this.txtMaPhieu.TabIndex = 131;
            // 
            // lblMucDich
            // 
            this.lblMucDich.AutoSize = true;
            this.lblMucDich.Location = new System.Drawing.Point(402, 195);
            this.lblMucDich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMucDich.Name = "lblMucDich";
            this.lblMucDich.Size = new System.Drawing.Size(70, 13);
            this.lblMucDich.TabIndex = 130;
            this.lblMucDich.Text = "Lý do thu/chi";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(402, 155);
            this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(40, 13);
            this.lblNgayNhap.TabIndex = 129;
            this.lblNgayNhap.Text = "Số tiền";
            // 
            // lblNgayThuChi
            // 
            this.lblNgayThuChi.AutoSize = true;
            this.lblNgayThuChi.Location = new System.Drawing.Point(37, 231);
            this.lblNgayThuChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayThuChi.Name = "lblNgayThuChi";
            this.lblNgayThuChi.Size = new System.Drawing.Size(51, 13);
            this.lblNgayThuChi.TabIndex = 128;
            this.lblNgayThuChi.Text = "Thời gian";
            // 
            // lblLuaChonThuChi
            // 
            this.lblLuaChonThuChi.AutoSize = true;
            this.lblLuaChonThuChi.Location = new System.Drawing.Point(37, 195);
            this.lblLuaChonThuChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLuaChonThuChi.Name = "lblLuaChonThuChi";
            this.lblLuaChonThuChi.Size = new System.Drawing.Size(89, 13);
            this.lblLuaChonThuChi.TabIndex = 127;
            this.lblLuaChonThuChi.Text = "Lựa chọn thu/chi";
            // 
            // lblMaThietBi
            // 
            this.lblMaThietBi.AutoSize = true;
            this.lblMaThietBi.Location = new System.Drawing.Point(37, 155);
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
            this.lblThoiKhoaBieu.Location = new System.Drawing.Point(306, 98);
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
            this.label4.Location = new System.Drawing.Point(149, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(587, 46);
            this.label4.TabIndex = 124;
            this.label4.Text = "ENGLISH CENTER DOUBLE D";
            // 
            // cbbThuChi
            // 
            this.cbbThuChi.FormattingEnabled = true;
            this.cbbThuChi.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cbbThuChi.Location = new System.Drawing.Point(157, 187);
            this.cbbThuChi.Name = "cbbThuChi";
            this.cbbThuChi.Size = new System.Drawing.Size(175, 21);
            this.cbbThuChi.TabIndex = 145;
            // 
            // txtSoTienThuChi
            // 
            this.txtSoTienThuChi.Location = new System.Drawing.Point(508, 145);
            this.txtSoTienThuChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoTienThuChi.Name = "txtSoTienThuChi";
            this.txtSoTienThuChi.Size = new System.Drawing.Size(175, 20);
            this.txtSoTienThuChi.TabIndex = 146;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(508, 228);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(175, 20);
            this.txtNoiDung.TabIndex = 147;
            // 
            // UC_ThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtSoTienThuChi);
            this.Controls.Add(this.cbbThuChi);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.cbbCaHoc);
            this.Controls.Add(this.dtpNgayThuChi);
            this.Controls.Add(this.btnDocFileTB);
            this.Controls.Add(this.btnTimTB);
            this.Controls.Add(this.btnLuuTB);
            this.Controls.Add(this.btnSuaTB);
            this.Controls.Add(this.btnXoaTB);
            this.Controls.Add(this.btnThemTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.lblMucDich);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.lblNgayThuChi);
            this.Controls.Add(this.lblLuaChonThuChi);
            this.Controls.Add(this.lblMaThietBi);
            this.Controls.Add(this.lblThoiKhoaBieu);
            this.Controls.Add(this.label4);
            this.Name = "UC_ThuChi";
            this.Size = new System.Drawing.Size(839, 584);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.ComboBox cbbCaHoc;
        private System.Windows.Forms.DateTimePicker dtpNgayThuChi;
        private System.Windows.Forms.Button btnDocFileTB;
        private System.Windows.Forms.Button btnTimTB;
        private System.Windows.Forms.Button btnLuuTB;
        private System.Windows.Forms.Button btnSuaTB;
        private System.Windows.Forms.Button btnXoaTB;
        private System.Windows.Forms.Button btnThemTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblMucDich;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblNgayThuChi;
        private System.Windows.Forms.Label lblLuaChonThuChi;
        private System.Windows.Forms.Label lblMaThietBi;
        private System.Windows.Forms.Label lblThoiKhoaBieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbThuChi;
        private System.Windows.Forms.TextBox txtSoTienThuChi;
        private System.Windows.Forms.TextBox txtNoiDung;
    }
}
