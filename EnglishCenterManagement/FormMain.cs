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
    public partial class FormMain : Form
    {
        private DanhSachHocVien danhSachHocVien=new DanhSachHocVien();
        private int viTri = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        
        private void AddUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill; 
            pannelMEnu.Controls.Clear(); 
            pannelMEnu.Controls.Add(uc); 
            uc.BringToFront();
        }

        private void btnHocVien_Click(object sender, EventArgs e)
        {
            UC_HocVien ucHV = new UC_HocVien();
            AddUserControl(ucHV);

        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            UC_GiaoVien ucGV = new UC_GiaoVien();
            AddUserControl(ucGV);
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            UC_ThietBi ucTB = new UC_ThietBi();
            AddUserControl(ucTB);
        }

        private void btnThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            UC_ThoiKhoaBieu uctkb = new  UC_ThoiKhoaBieu();
            AddUserControl(uctkb);
        }

        private void btnThuChi_Click(object sender, EventArgs e)
        {
            UC_ThuChi ucTC = new UC_ThuChi();
            AddUserControl(ucTC);
        }

        private void btnChuongTrinhHoc_Click(object sender, EventArgs e)
        {
            UC_ChuongTrinhHoc ucCTH = new UC_ChuongTrinhHoc();
            AddUserControl(ucCTH);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

      
    }
}
