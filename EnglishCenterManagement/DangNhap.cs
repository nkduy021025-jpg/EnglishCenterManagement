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
            if (txtTaiKhoan.Text == "adminDuy" && txtMatKhau.Text == "2005")
            {
                QuanLyHocVien qlhv = new QuanLyHocVien();
                qlhv.FormClosed += (s, args) => this.Close();
                qlhv.Show();
                this.Hide();
            }
            else
            {
                LanNhap++;
                DialogResult NhapSai = MessageBox.Show
                    (
                    "Bạn đã nhập sai " + (3 - LanNhap) + " lần. Vui lòng nhập lại! "
                    , "Sai tài khoản hoặc mật khẩu!"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Error
                    );
                if (NhapSai == DialogResult.Yes) 
                {
                    txtMatKhau.Text = "";
                }
                else
                {
                    DialogResult KhongNhap = MessageBox.Show
                        ("Bạn lựa chọn không nhập lại, thoát chương trình?"
                        ,"Cảnh báo"
                        ,MessageBoxButtons.YesNo
                        ,MessageBoxIcon.Warning);
                    if (KhongNhap == DialogResult.Yes)
                    {
                        Close();
                    }
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
