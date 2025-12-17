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
            this.label1 = new System.Windows.Forms.Label();
            this.lblChonChucNang = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHocVien = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.btnThietBi = new System.Windows.Forms.Button();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChuongTrinhHoc = new System.Windows.Forms.Button();
            this.btnThuChi = new System.Windows.Forms.Button();
            this.btnThoiKhoaBieu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pannelMEnu.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannelMEnu
            // 
            this.pannelMEnu.AutoScroll = true;
            this.pannelMEnu.Controls.Add(this.label2);
            this.pannelMEnu.Controls.Add(this.label1);
            this.pannelMEnu.Controls.Add(this.lblChonChucNang);
            this.pannelMEnu.Controls.Add(this.panel1);
            this.pannelMEnu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pannelMEnu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pannelMEnu.Location = new System.Drawing.Point(61, 0);
            this.pannelMEnu.Margin = new System.Windows.Forms.Padding(2);
            this.pannelMEnu.Name = "pannelMEnu";
            this.pannelMEnu.Size = new System.Drawing.Size(1066, 760);
            this.pannelMEnu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "--------------------------------------";
            // 
            // lblChonChucNang
            // 
            this.lblChonChucNang.AutoSize = true;
            this.lblChonChucNang.BackColor = System.Drawing.Color.Transparent;
            this.lblChonChucNang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChonChucNang.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonChucNang.ForeColor = System.Drawing.Color.DimGray;
            this.lblChonChucNang.Location = new System.Drawing.Point(3, 71);
            this.lblChonChucNang.Name = "lblChonChucNang";
            this.lblChonChucNang.Size = new System.Drawing.Size(533, 47);
            this.lblChonChucNang.TabIndex = 1;
            this.lblChonChucNang.Text = "Chọn trang bạn muốn quản lý :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EnglishCenterManagement.Properties.Resources.z7257614198401_9f47daa8ab828779f1ab0654d6b1fe48;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(583, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 757);
            this.panel1.TabIndex = 0;
            // 
            // btnHocVien
            // 
            this.btnHocVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHocVien.Location = new System.Drawing.Point(0, 50);
            this.btnHocVien.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnGiaoVien.Location = new System.Drawing.Point(0, 94);
            this.btnGiaoVien.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnThietBi.Location = new System.Drawing.Point(0, 143);
            this.btnThietBi.Margin = new System.Windows.Forms.Padding(2);
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
            this.grpChucNang.Controls.Add(this.btnThoat);
            this.grpChucNang.Controls.Add(this.btnChuongTrinhHoc);
            this.grpChucNang.Controls.Add(this.btnThuChi);
            this.grpChucNang.Controls.Add(this.btnThoiKhoaBieu);
            this.grpChucNang.Controls.Add(this.btnGiaoVien);
            this.grpChucNang.Controls.Add(this.btnThietBi);
            this.grpChucNang.Controls.Add(this.btnHocVien);
            this.grpChucNang.Location = new System.Drawing.Point(0, 2);
            this.grpChucNang.Margin = new System.Windows.Forms.Padding(2);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Padding = new System.Windows.Forms.Padding(2);
            this.grpChucNang.Size = new System.Drawing.Size(56, 758);
            this.grpChucNang.TabIndex = 4;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Danh sách trang";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThoat.Location = new System.Drawing.Point(0, 340);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(56, 40);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát!";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChuongTrinhHoc
            // 
            this.btnChuongTrinhHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChuongTrinhHoc.Location = new System.Drawing.Point(1, 289);
            this.btnChuongTrinhHoc.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnThuChi.Location = new System.Drawing.Point(1, 241);
            this.btnThuChi.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnThoiKhoaBieu.Location = new System.Drawing.Point(0, 188);
            this.btnThoiKhoaBieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoiKhoaBieu.Name = "btnThoiKhoaBieu";
            this.btnThoiKhoaBieu.Size = new System.Drawing.Size(56, 49);
            this.btnThoiKhoaBieu.TabIndex = 4;
            this.btnThoiKhoaBieu.Text = "Thời khóa biểu";
            this.btnThoiKhoaBieu.UseVisualStyleBackColor = false;
            this.btnThoiKhoaBieu.Click += new System.EventHandler(this.btnThoiKhoaBieu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chào mừng bạn đến với trang chủ.";
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1127, 760);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.pannelMEnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.pannelMEnu.ResumeLayout(false);
            this.pannelMEnu.PerformLayout();
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
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblChonChucNang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}