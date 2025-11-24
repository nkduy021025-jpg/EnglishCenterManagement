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
        int LanNhap = 0;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Dung" && txtMatKhau.Text == "1")
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
                    "Bạn còn " + (3 - LanNhap) + " lần nhập. Vui lòng nhập lại! "
                    , "Sai tài khoản hoặc mật khẩu!"
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

      
    }
}
