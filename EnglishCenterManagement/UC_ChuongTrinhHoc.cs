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
    public partial class UC_ChuongTrinhHoc : UserControl
    {
        DanhSachChuongTrinhHoc dsct = new DanhSachChuongTrinhHoc();
        int vitri = -1;
        public UC_ChuongTrinhHoc()
        {
            InitializeComponent();
        }
        private void HienThi (DataGridView dgv , List<ChuongTrinhHoc> ct)
        {
            dgv.DataSource = ct.ToList();            
        }
        private void btnThemChuongTrinh_Click(object sender, EventArgs e)
        {
            string maCT = txtMaChuongTrinhHoc.Text;
            string tenCT = txtTenChuongTrinhHoc.Text;
            string thoiGian = cbbThoiGianHoc.Text;
            string doiTuongHoc = cbbDoiTuongHoc.Text;
            float hocphi = float.Parse(txtHocPhi.Text);
            string mota = txtMoTaCTH.Text;
            string loTrinhHoc = cbbLoTrinh.Text;
            ChuongTrinhHoc ct = new ChuongTrinhHoc(maCT,tenCT,thoiGian,doiTuongHoc,hocphi,mota,loTrinhHoc);
            bool KiemTraThem = dsct.Them(ct);
            if (KiemTraThem)
            {
                MessageBox.Show("Đã thêm 1 chương trình học mới!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi(dgvChuongTrinh, dsct.CTrinhHoc);
            }
            else
            {
                MessageBox.Show("Thêm 1 chương trình học không thành công!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnXoaChuongTrinh_Click(object sender, EventArgs e)
        {

        }
    }
}
