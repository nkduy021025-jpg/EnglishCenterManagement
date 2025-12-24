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
    public partial class DangKy : Form
    {
        DanhSachDangNhap DMDN = new DanhSachDangNhap();
        private string MaDangNhap = "123";
        private void DangKy_Load(object sender, EventArgs e)
        {
            DMDN.DocFileDN("TaiKhoanDangNhap.dat");
        }
        public DangKy()
        {
            InitializeComponent();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            if (matkhau.Equals(txtNhapLai.Text)== false)
            {
                MessageBox.Show("Mật khẩu nhập lại không giống. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((txtMaTaoTK.Text).Equals(MaDangNhap)==false)
            {
                MessageBox.Show("Mã đăng nhập sai. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TaiKhoanDangNhap TKDN = new TaiKhoanDangNhap(taikhoan, matkhau);
            bool kiemtrathem = DMDN.ThemTaiKhoan(TKDN);
            if (kiemtrathem) 
            {
                MessageBox.Show("Đã tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DMDN.GhiFileDN("TaiKhoanDangNhap.dat");
            }
            else
            {
                MessageBox.Show("Tài khoản này đã đăng ký rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
