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
    [Serializable]
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

        private void dgvChuongTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri =e.RowIndex;
            ChuongTrinhHoc ct = new ChuongTrinhHoc ();
            ct = dsct.CTrinhHoc[vitri];
            txtMaChuongTrinhHoc.Text = ct.MaChuongTrinh;
            txtTenChuongTrinhHoc.Text = ct.TenChuongTrinh;
            cbbThoiGianHoc.Text = ct.ThoiGianHoc;
            cbbLoTrinh.Text = ct.LoTrinhHoc;
            cbbDoiTuongHoc.Text = ct.DoiTuongHoc;
            txtHocPhi.Text = ct.HocPhi.ToString();
            txtMoTaCTH.Text = ct.MoTa;
        }
        private void btnXoaChuongTrinh_Click(object sender, EventArgs e)
        {
            if (vitri < 0 || vitri > dsct.CTrinhHoc.Count)
            {
                MessageBox.Show ("Vui lòng chọn chương trình bạn muốn xóa!", "Thông báo" , MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            DialogResult ketqua = MessageBox.Show ("Bạn chắc chắn muốn xóa chương trình học này không", "Cảnh báo" , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ketqua == DialogResult.Yes)
            {
                bool kiemtra = dsct.Xoa(vitri);
                HienThi(dgvChuongTrinh, dsct.CTrinhHoc);
            }
            else
            {
                MessageBox.Show("Bạn lựa chọn không xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSuaChuongTrinh_Click(object sender, EventArgs e)
        {
            if (vitri < 0 || vitri > dsct.CTrinhHoc.Count)
            {
                MessageBox.Show ("Vui lòng chọn chương trình bạn muốn sửa!" , "Thông báo" , MessageBoxButtons .OK, MessageBoxIcon.Error);
                return;
            }
            string maChuongTrinh = txtMaChuongTrinhHoc.Text;
            string tenChuongTrinh = txtTenChuongTrinhHoc.Text;
            string thoiGianHoc = cbbThoiGianHoc.Text;
            string loTrinh = cbbLoTrinh.Text;
            string doiTuong = cbbDoiTuongHoc.Text;
            float hocPhi = float.Parse(txtHocPhi.Text);
            string mota = txtMoTaCTH.Text;  
            ChuongTrinhHoc ct = new ChuongTrinhHoc(maChuongTrinh,tenChuongTrinh,thoiGianHoc,loTrinh,hocPhi,doiTuong,mota);
            bool kiemTraSua = dsct.Sua(vitri,ct);
            if (kiemTraSua)
            {
                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi(dgvChuongTrinh, dsct.CTrinhHoc);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuChuongTrinh_Click(object sender, EventArgs e)
        {
            if (dsct.ghiFileCT("DanhSachChuongTrinh.dat"))
            {
                MessageBox.Show ("Đã lưu thành công!","Thành công",MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Lưu không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UC_ChuongTrinhHoc_Load(object sender, EventArgs e)
        {
            bool kiemtradoc = dsct.docFileCT("DanhSachChuongTrinh.dat");
            if (kiemtradoc)
            {
                HienThi(dgvChuongTrinh,dsct.CTrinhHoc);
            }
            else
            {
                MessageBox.Show("Lỗi không thể xem danh sách chương trình học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<ChuongTrinhHoc> ketqua = new List<ChuongTrinhHoc> ();
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text)  || string.IsNullOrWhiteSpace(cbbTimKiem.Text)  )
            {
                MessageBox.Show("Vui lòng chọn chức năng hoặc nhập đầy đủ vào thanh tìm kiếm!" ,"Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (cbbTimKiem.Text =="Theo mã chương trình")
            {
                ketqua = dsct.TimKiemTheoMa(txtTimKiem.Text);
                HienThi(dgvChuongTrinh,ketqua);
            }
            else if ((cbbTimKiem.Text == "Theo tên chương trình"))
            {
                ketqua = dsct.TimKiemTheoTenCT(txtTimKiem.Text);
                HienThi(dgvChuongTrinh, ketqua);
            }
            else if ((cbbTimKiem.Text == "Theo học phí"))
            {
                ketqua = dsct.TimKiemTheoHocPhi(float.Parse(txtTimKiem.Text));
                HienThi(dgvChuongTrinh, ketqua);
            }
            else
            {
                ketqua = dsct.TimKiemTheoDoiTuong(txtTimKiem.Text);
                HienThi(dgvChuongTrinh, ketqua);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            HienThi(dgvChuongTrinh, dsct.CTrinhHoc);
        }

      
    }
}
