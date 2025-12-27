using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishCenterManagement
{
    public partial class UC_ThuChi : UserControl
    {
        private DanhSachThuChi dsThuChi = new DanhSachThuChi();
        private DanhSachChuongTrinhHoc dsCT = new DanhSachChuongTrinhHoc();
        int viTri = -1;
        public UC_ThuChi()
        {
            InitializeComponent();
        }

        private void btnThemPhieuThuChi_Click(object sender, EventArgs e)
        {
            string maThuChi = txtMaPhieu.Text;
            string luachon = cbbLuaChonThuChi.Text;
            DateTime ngay = dtpNgayThuChi.Value;
            double soTien = double.Parse(txtSoTienThuChi.Text);
            string lyDo = cbbLyDo.Text;
            string noiDung = txtNoiDung.Text;
            string maChuongTrinh = cbbMaCT.Text;
            ThuChi tc = new ThuChi(maThuChi, luachon, ngay, soTien, lyDo, noiDung, maChuongTrinh);
            bool ketQua = dsThuChi.ThemPhieuThuChi(tc);
            if (ketQua == true)
            {
                MessageBox.Show("Đã thêm 1 phiếu thu chi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi(dgvDanhSachThuChi, dsThuChi.DSThuChi);
            }
            else
            {
                MessageBox.Show("Mã phiếu đã tồn tại!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }
        private void HienThi(DataGridView dgv, List<ThuChi> ds)
        {
            dgv.DataSource = ds.ToList();
        }

        private void dgvDanhSachThuChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            ThuChi tc = new ThuChi();
            tc = dsThuChi.DSThuChi[viTri];
            txtMaPhieu.Text = tc.maThuChi;
            cbbLuaChonThuChi.Text = tc.luaChonThuChi;
            dtpNgayThuChi.Value = tc.ngayThuChi;
            txtSoTienThuChi.Text = tc.soTien.ToString();
            cbbLyDo.Text = tc.lyDo;
            txtNoiDung.Text = tc.noiDung;
            txtMaKhoaHoc.Text = tc.MaChuongTrinh;
            cbbMaCT.Text = tc.MaChuongTrinh;
        }

        private void btnXoaPhieuThuChi_Click(object sender, EventArgs e)
        {
            DialogResult ketQuaChon = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu thu chi này không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ketQuaChon == DialogResult.Yes)
            {
                bool ketQuaXoa = dsThuChi.XoaPhieuThuChi(viTri);
                if (ketQuaXoa == true)
                {
                    MessageBox.Show("Đã xóa thành công phiếu thu chi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi(dgvDanhSachThuChi, dsThuChi.DSThuChi);
                }
            }
            else
            {
                MessageBox.Show("Không xóa!", "Lựa chọn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaPhieuThuChi_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
                {
                    MessageBox.Show("Vui lòng chọn phiếu thu chi cần sửa");
                    return;
                }
                ThuChi tc = new ThuChi();
                tc.maThuChi = txtMaPhieu.Text;
                tc.luaChonThuChi = cbbLuaChonThuChi.Text;
                tc.ngayThuChi = dtpNgayThuChi.Value;
                tc.soTien = double.Parse(txtSoTienThuChi.Text);
                tc.lyDo = cbbLyDo.Text;
                tc.noiDung = txtNoiDung.Text;
                tc.MaChuongTrinh = cbbMaCT.Text;

                if (dsThuChi.SuaPhieuThuChi(tc, viTri) == true)
                {
                    MessageBox.Show("Đã sửa được phiếu thu chi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi(dgvDanhSachThuChi, dsThuChi.DSThuChi);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không sửa được");
            }
        }
        private void btnLuuPhieuThuChi_Click(object sender, EventArgs e)
        {
            if (dsThuChi.GhiFileThuChi("DanhSachThuChi.dat"))
            {
                MessageBox.Show("Đã lưu danh sách phiếu thu chi vào file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTimPhieuThuChi_Click(object sender, EventArgs e)
        {
            List<ThuChi> KetQua = new List<ThuChi>();
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text) || string.IsNullOrWhiteSpace(cbbLuaChonTimKiem.Text))
            {
                MessageBox.Show("Vui lòng chọn chức năng hoặc nhập đầy đủ vào thanh tìm kiếm!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (cbbLuaChonTimKiem.Text == "Tìm theo mã phiếu")
            {
                KetQua = dsThuChi.TimKiemTheoMa(txtTimKiem.Text);
                HienThi(dgvDanhSachThuChi, KetQua);
            }
            else if (cbbLuaChonTimKiem.Text == "Tìm theo số tiền")
            {
                KetQua = dsThuChi.TimKiemTheoSoTien(float.Parse(txtTimKiem.Text));
                HienThi(dgvDanhSachThuChi, KetQua);
            }
            else
            {
                KetQua = dsThuChi.TimTheoThoiGian(DateTime.ParseExact(txtTimKiem.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                HienThi(dgvDanhSachThuChi, KetQua);
            }
        }

        private void UC_ThuChi_Load(object sender, EventArgs e)
        {
            bool kiemtradoc = dsThuChi.DocFileThuChi("DanhSachThuChi.dat");
            if (kiemtradoc)
            {
                HienThi(dgvDanhSachThuChi, dsThuChi.DSThuChi);
            }
            else
            {
                MessageBox.Show("Lỗi không thể xem danh sách thu chi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool kiemtramaCT = dsCT.docFileCT("DanhSachChuongTrinh.dat");
            if (kiemtramaCT)
            {
                foreach (ChuongTrinhHoc ct in dsCT.CTrinhHoc)
                {
                    cbbMaCT.Items.Add(ct.MaChuongTrinh);
                }
            }
        }

        private void btnTinhDoanhThu_Click(object sender, EventArgs e)
        {
            double tong = dsThuChi.TongThuChiThang(cbbThuChiTheoThang.Text, int.Parse(txtThangThuChi.Text));
            if (cbbThuChiTheoThang.Text.Equals("Thu"))
            {
                MessageBox.Show( "Số tiền đã thu trong tháng: " +txtThangThuChi.Text+" là " + tong.ToString(),"Tính thu/chi theo tháng",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Số tiền đã chi trong tháng: " + txtThangThuChi.Text + " là " + tong.ToString(), "Tính thu/chi theo tháng", MessageBoxButtons.OK);
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            HienThi(dgvDanhSachThuChi, dsThuChi.DSThuChi);
        }


        private void btnTinhTienTheoKhoa_Click_1(object sender, EventArgs e)
        {
            double tong = 0;
            tong = dsThuChi.TongTienTheoKhoa(txtMaKhoaHoc.Text);
            MessageBox.Show("Học phí đã thu từ học viên từ khóa này là: " + tong, "Tính tiền theo khóa ", MessageBoxButtons.OK);
        }
     
        private void btnBieuDoThuChiTheoThang_Click(object sender, EventArgs e)
        {
            BieuDoThuChi bdtc = new BieuDoThuChi();
            bdtc.ShowDialog();
           
        }
    }
}
