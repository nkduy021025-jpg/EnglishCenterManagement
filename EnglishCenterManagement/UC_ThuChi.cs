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
    public partial class UC_ThuChi : UserControl
    {
        private DanhSachThuChi dsThuChi=new DanhSachThuChi();
        int viTri = -1;
        public UC_ThuChi()
        {
            InitializeComponent();
        }

        private void btnThemPhieuThuChi_Click(object sender, EventArgs e)
        {
            string maThuChi = txtMaPhieu.Text;
            string luachon=cbbLuaChonThuChi.Text;
            DateTime ngay = dtpNgayThuChi.Value;
            double soTien = double.Parse(txtSoTienThuChi.Text);
            string lyDo = cbbLyDo.Text;
            string noiDung = txtNoiDung.Text;
            ThuChi tc = new ThuChi(maThuChi, luachon, ngay, soTien, lyDo, noiDung);
            bool ketQua = dsThuChi.ThemPhieuThuChi(tc);
            if (ketQua == true)
            {
                MessageBox.Show("Đã thêm 1 phiếu thu chi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi(dgvDanhSachThuChi, dsThuChi.DSThuChi);
            }
            else
            {
                MessageBox.Show("Mã phiếu thu chi này đã tồn tại, vui lòng nhập 1 mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void HienThi(DataGridView dgv,List<ThuChi> ds)
        {
            dgv.DataSource = ds.ToList();
        }

        private void dgvDanhSachThuChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            ThuChi tc = new ThuChi();
            txtMaPhieu.Text = tc.maThuChi;
            cbbLuaChonThuChi.Text = tc.luaChonThuChi;
            dtpNgayThuChi.Value = tc.ngayThuChi;
            txtSoTienThuChi.Text = tc.soTien.ToString();
            cbbLyDo.Text = tc.lyDo;
            txtNoiDung.Text = tc.noiDung;
        }

        private void btnXoaPhieuThuChi_Click(object sender, EventArgs e)
        {
            DialogResult ketQuaChon = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu thu chi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketQuaChon == DialogResult.Yes)
            {
                bool ketQuaXoa = dsThuChi.XoaPhieuThuChi(viTri);
                if (ketQuaXoa == true)
                {
                    MessageBox.Show("Đã xóa học phiếu thu chi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Vui lòng nhập mã phiếu thu chi cần sửa");
                    return;
                }
                ThuChi tc=new ThuChi();
                tc.maThuChi= txtMaPhieu.Text;
                tc.luaChonThuChi= cbbLuaChonThuChi.Text;
                tc.ngayThuChi= dtpNgayThuChi.Value;
                tc.soTien= double.Parse( txtSoTienThuChi.Text);
                tc.lyDo= cbbLyDo.Text;
                tc.noiDung= txtNoiDung.Text;

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
            ThuChi ketQua;
            ketQua = dsThuChi.TimPhieuThuChi(txtMaPhieu.Text);
            List<ThuChi> dsKetQua = new List<ThuChi>();
            dsKetQua.Add(ketQua);
            HienThi(dgvDanhSachThuChi, dsKetQua);
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
        }
    }
}
