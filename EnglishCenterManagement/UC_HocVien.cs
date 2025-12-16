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
    public partial class UC_HocVien : UserControl
    {
        private DanhSachHocVien danhSachHocVien = new DanhSachHocVien();
        private int viTri = 0;
        public UC_HocVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHV = txtMaHV.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string cccd = txtCCCD.Text;
            string trinhDo = cbbTrinhDo.Text;
            string chuongTrinhHoc = cbbChuongTrinhHoc.Text;
            DateTime ngayDangKy = dtpNgayDangKy.Value;
            string gioiTinh = null;
            if (radNam.Checked == true)
                gioiTinh = "Nam";
            else
                gioiTinh = "Nữ";
            HocVien hv = new HocVien(maHV, hoTen, cccd, ngaySinh, gioiTinh, diaChi, sdt, trinhDo, chuongTrinhHoc, ngayDangKy);
            bool ketQuaThem = danhSachHocVien.ThemHocVien(hv);
            if (ketQuaThem == true)
            {
                MessageBox.Show("Đã thêm 1 học viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach(dgvDanhSachHocVien, danhSachHocVien.DSHocVien);
            }
            else
            {
                MessageBox.Show("Mã học viên này đã tồn tại, vui lòng nhập 1 mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void HienThiDanhSach(DataGridView dgv, List<HocVien> ds)
        {
            dgv.DataSource = ds.ToList();
        }
        private void dgvDanhSachHocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                viTri = e.RowIndex;
                HocVien hv = new HocVien();
                hv = danhSachHocVien.DSHocVien[viTri];
                txtMaHV.Text = hv.maHV;
                txtHoTen.Text = hv.hoTen;
                dtpNgaySinh.Value = hv.ngaySinh;
                txtDiaChi.Text = hv.diaChi;
                txtSDT.Text = hv.SDT.ToString();
                txtCCCD.Text = hv.cccdhv;
                cbbTrinhDo.Text = hv.trinhDo;
                cbbChuongTrinhHoc.Text = hv.chuongTrinhHoc;
                dtpNgayDangKy.Value = hv.ngayDangKy;
                if (gioiTinh.Equals("Nam"))
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
            }
            catch (Exception)
            {

            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaHV.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã học viên cần sửa");
                    return;
                }
                HocVien hv = new HocVien();
                hv.maHV = txtMaHV.Text;
                hv.hoTen = txtHoTen.Text;
                hv.ngaySinh = dtpNgaySinh.Value;
                hv.diaChi = txtDiaChi.Text;
                hv.SDT = txtSDT.Text;
                hv.cccdhv = txtCCCD.Text;
                hv.trinhDo = cbbTrinhDo.Text;
                hv.chuongTrinhHoc = cbbChuongTrinhHoc.Text;
                hv.ngayDangKy = dtpNgayDangKy.Value;
                if (radNam.Checked == true)
                    hv.gioiTinh = "Nam";
                else
                    hv.gioiTinh = "Nữ";
                if (danhSachHocVien.SuaHocVien(hv, viTri) == true)
                {
                    MessageBox.Show("Đã sửa được học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach(dgvDanhSachHocVien, danhSachHocVien.DSHocVien);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không sửa được");
            }
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {

            DialogResult ketQuaChon = MessageBox.Show("Bạn có chắc chắn muốn xóa học viên này không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ketQuaChon == DialogResult.Yes)
            {
                bool ketQuaXoa = danhSachHocVien.XoaHocVien(viTri);
                if (ketQuaXoa == true)
                {
                    MessageBox.Show("Đã xóa học viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach(dgvDanhSachHocVien, danhSachHocVien.DSHocVien);
                }
            }
            else
            {
                MessageBox.Show("Không xóa!", "Lựa chọn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<HocVien> ketqua = new List<HocVien>();
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text) || string.IsNullOrWhiteSpace(cbbTimKiem.Text))
            {
                MessageBox.Show("Vui lòng chọn chức năng hoặc nhập đầy đủ vào thanh tìm kiếm!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (txtTimKiem.Text == "Tìm theo tên")
            {
                ketqua = danhSachHocVien.TimKiemTheoTen(txtTimKiem.Text);
                HienThiDanhSach(dgvDanhSachHocVien, ketqua);
            }
            else if (txtTimKiem.Text =="Tìm theo mã")
            {
                ketqua = danhSachHocVien.TimKiemHocVien(txtTimKiem.Text);
                HienThiDanhSach(dgvDanhSachHocVien, ketqua);
            }
            else if( txtTimKiem.Text =="Tìm theo giới tính")
            {
                ketqua = danhSachHocVien.TimTheoGioiTinh(txtTimKiem.Text);
                HienThiDanhSach (dgvDanhSachHocVien, ketqua);
            }
        }
        private void btnLuuHV_Click(object sender, EventArgs e)
        {
            if(danhSachHocVien.GhiFile("DanhSachHocVien.dat"))
            {
                MessageBox.Show("Đã lưu danh sách học viên vào file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnTimTheoTen_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtHoTen.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập tên học viên cần tìm từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    List<HocVien> ketqua;
        //    ketqua = danhSachHocVien.TimKiemTheoTen(txtHoTen.Text);
        //    HienThiDanhSach(dgvDanhSachHocVien, ketqua);
        //}

        //private void btnTimTheoGioiTinh_Click(object sender, EventArgs e)
        //{
        //    string gioiTinh = "";

        //    if (radNam.Checked == true)
        //        gioiTinh = "Nam";
        //    else if (radNu.Checked == true)
        //        gioiTinh = "Nữ";
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn giới tính cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    List<HocVien> ketQua = danhSachHocVien.TimTheoGioiTinh(gioiTinh);

        //    HienThiDanhSach(dgvDanhSachHocVien, ketQua);
        //}

        private void UC_HocVien_Load(object sender, EventArgs e)
        {
            bool kiemtradoc = danhSachHocVien.DocFile("DanhSachHocVien.dat");
            if (kiemtradoc) 
            {
                HienThiDanhSach(dgvDanhSachHocVien, danhSachHocVien.DSHocVien);
            }
            else
            {
                MessageBox.Show("Lỗi không thể xem danh sách học viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            HienThiDanhSach(dgvDanhSachHocVien, danhSachHocVien.DSHocVien);
        }
    }
}
