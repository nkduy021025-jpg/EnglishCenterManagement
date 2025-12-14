namespace EnglishCenterManagement
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pannelMEnu = new System.Windows.Forms.Panel();
            this.btnHocVien = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.btnThietBi = new System.Windows.Forms.Button();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnChuongTrinhHoc = new System.Windows.Forms.Button();
            this.btnThuChi = new System.Windows.Forms.Button();
            this.btnThoiKhoaBieu = new System.Windows.Forms.Button();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannelMEnu
            // 
            this.pannelMEnu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pannelMEnu.Location = new System.Drawing.Point(61, 0);
            this.pannelMEnu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pannelMEnu.Name = "pannelMEnu";
            this.pannelMEnu.Size = new System.Drawing.Size(824, 507);
            this.pannelMEnu.TabIndex = 0;
            // 
            // btnHocVien
            // 
            this.btnHocVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHocVien.Location = new System.Drawing.Point(1, 38);
            this.btnHocVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHocVien.Name = "btnHocVien";
            this.btnHocVien.Size = new System.Drawing.Size(56, 40);
            this.btnHocVien.TabIndex = 1;
            this.btnHocVien.Text = "Học viên";
            this.btnHocVien.UseVisualStyleBackColor = false;
            this.btnHocVien.Click += new System.EventHandler(this.btnHocVien_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGiaoVien.Location = new System.Drawing.Point(0, 82);
            this.btnGiaoVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(56, 45);
            this.btnGiaoVien.TabIndex = 2;
            this.btnGiaoVien.Text = "Giáo viên";
            this.btnGiaoVien.UseVisualStyleBackColor = false;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnThietBi
            // 
            this.btnThietBi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThietBi.Location = new System.Drawing.Point(0, 131);
            this.btnThietBi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.Size = new System.Drawing.Size(56, 41);
            this.btnThietBi.TabIndex = 3;
            this.btnThietBi.Text = "Thiết bị";
            this.btnThietBi.UseVisualStyleBackColor = false;
            this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
            // 
            // grpChucNang
            // 
            this.grpChucNang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpChucNang.Controls.Add(this.btnChuongTrinhHoc);
            this.grpChucNang.Controls.Add(this.btnThuChi);
            this.grpChucNang.Controls.Add(this.btnThoiKhoaBieu);
            this.grpChucNang.Controls.Add(this.btnGiaoVien);
            this.grpChucNang.Controls.Add(this.btnThietBi);
            this.grpChucNang.Controls.Add(this.btnHocVien);
            this.grpChucNang.Location = new System.Drawing.Point(0, 2);
            this.grpChucNang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpChucNang.Size = new System.Drawing.Size(56, 505);
            this.grpChucNang.TabIndex = 4;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnChuongTrinhHoc
            // 
            this.btnChuongTrinhHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChuongTrinhHoc.Location = new System.Drawing.Point(1, 280);
            this.btnChuongTrinhHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChuongTrinhHoc.Name = "btnChuongTrinhHoc";
            this.btnChuongTrinhHoc.Size = new System.Drawing.Size(56, 47);
            this.btnChuongTrinhHoc.TabIndex = 6;
            this.btnChuongTrinhHoc.Text = "Chương trình học";
            this.btnChuongTrinhHoc.UseVisualStyleBackColor = false;
            this.btnChuongTrinhHoc.Click += new System.EventHandler(this.btnChuongTrinhHoc_Click);
            // 
            // btnThuChi
            // 
            this.btnThuChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThuChi.Location = new System.Drawing.Point(0, 232);
            this.btnThuChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThuChi.Name = "btnThuChi";
            this.btnThuChi.Size = new System.Drawing.Size(56, 44);
            this.btnThuChi.TabIndex = 5;
            this.btnThuChi.Text = "Thu/chi";
            this.btnThuChi.UseVisualStyleBackColor = false;
            this.btnThuChi.Click += new System.EventHandler(this.btnThuChi_Click);
            // 
            // btnThoiKhoaBieu
            // 
            this.btnThoiKhoaBieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThoiKhoaBieu.Location = new System.Drawing.Point(0, 176);
            this.btnThoiKhoaBieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoiKhoaBieu.Name = "btnThoiKhoaBieu";
            this.btnThoiKhoaBieu.Size = new System.Drawing.Size(56, 49);
            this.btnThoiKhoaBieu.TabIndex = 4;
            this.btnThoiKhoaBieu.Text = "Thời khóa biểu";
            this.btnThoiKhoaBieu.UseVisualStyleBackColor = false;
            this.btnThoiKhoaBieu.Click += new System.EventHandler(this.btnThoiKhoaBieu_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 507);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.pannelMEnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Trang chủ";
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pannelMEnu;
        private System.Windows.Forms.Button btnHocVien;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Button btnThietBi;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnThoiKhoaBieu;
        private System.Windows.Forms.Button btnThuChi;
        private System.Windows.Forms.Button btnChuongTrinhHoc;
    }
}