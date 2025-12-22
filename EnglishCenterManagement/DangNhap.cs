using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishCenterManagement
{
    public partial class DangNhap : Form
    {
        DanhSachDangNhap DMDN = new DanhSachDangNhap();
        int LanNhap = 0;

        public DangNhap()
        {
            InitializeComponent();
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            DMDN.DocFileDN("TaiKhoanDangNhap.dat");
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DMDN.KiemTraDangNhap(txtTaiKhoan.Text,txtMatKhau.Text))
            {
                FormMain qlhv = new FormMain();
                qlhv.FormClosed += (s, args) => this.Close();
                qlhv.Show();
                this.Hide();
            }
            else
            {
                LanNhap++;
                DialogResult NhapSai = MessageBox.Show
                    (
                    "Sai tài khoản hoặc mật khẩu, bạn còn " + (3 - LanNhap) + " lần nhập. Vui lòng nhập lại! "
                    ,"Sai tài khoản hoặc mật khẩu!"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error
                    );
                if (NhapSai == DialogResult.OK) 
                {
                    txtMatKhau.Text = "";
                }
                if (LanNhap == 3)
                {
                    MessageBox.Show ("Nhập sai 3 lần! Tự động thoát chương trình.","Nhập sai quá nhiều lần",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Close();
                }
                
            }
        }
        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            DangKy dktk = new DangKy();
            this.Hide();
            dktk.ShowDialog();
            DMDN.DocFileDN("TaiKhoanDangNhap.dat");
            this.Show();
        }
    }
}
