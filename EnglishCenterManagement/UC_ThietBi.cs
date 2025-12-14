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
    public partial class UC_ThietBi : UserControl
    {
        private DanhSachThietBi dsThietBi = new DanhSachThietBi();
        private int viTri = -1;
        public UC_ThietBi()
        {
            InitializeComponent();
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            string maTB = txtMaThietBi.Text;
            string tenTB = txtTenThietBi.Text;
            string tinhTrang = cbbTinhTrang.Text;
            DateTime ngayNhap = dtpNgayNhap.Value;
            double giaTien = double.Parse(txtGiaTien.Text);
            ThietBi tb = new ThietBi(maTB, tenTB, tinhTrang, ngayNhap, giaTien);
            bool ketQuaThem = dsThietBi.ThemThietBi(tb);
            if (ketQuaThem)
            {
                MessageBox.Show("Thêm thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi(dgvDanhSachThietBi, dsThietBi.DSThietBi);
            }
            else
            {
                MessageBox.Show("Mã thiết bị đã tồn tại. Vui lòng sử dụng mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void HienThi(DataGridView dgv, List<ThietBi> ds)
        {
            dgv.DataSource = ds.ToList();
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                if (viTri >= 0 && viTri < dsThietBi.DSThietBi.Count)
                {
                    dsThietBi.XoaThietBi(viTri);
                    MessageBox.Show("Xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi(dgvDanhSachThietBi, dsThietBi.DSThietBi);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thiết bị để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvDanhSachThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri= e.RowIndex;
            ThietBi tb = new ThietBi();
            txtMaThietBi.Text = tb.maTB;
            txtTenThietBi.Text = tb.tenTB;
            cbbTinhTrang.Text = tb.tinhTrang;
            dtpNgayNhap.Value = tb.ngayNhap;
            txtGiaTien.Text = tb.giaTien.ToString();
        }

        private void btnSuaTB_Click(object sender, EventArgs e)
        {
            try {
                if (viTri < 0 || viTri > dsThietBi.DSThietBi.Count)
                {
                    MessageBox.Show("Vui lòng chọn thiết bị để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maTB = txtMaThietBi.Text;
                string tenTB = txtTenThietBi.Text;
                string tinhTrang = cbbTinhTrang.Text;
                DateTime ngayNhap = dtpNgayNhap.Value;
                double giaTien = double.Parse(txtGiaTien.Text);
                ThietBi tb = new ThietBi(maTB, tenTB, tinhTrang, ngayNhap, giaTien);
                bool ketQuaSua = dsThietBi.SuaThietBi(tb, viTri);
                if (ketQuaSua)
                {
                    MessageBox.Show("Sửa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi(dgvDanhSachThietBi, dsThietBi.DSThietBi);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Sửa thiết bị thất bại!");
            }
         }

        private void btnLuuTB_Click(object sender, EventArgs e)
        {
          if( dsThietBi.GhiFile("DanhSachThietBi.dat"))
            {
                MessageBox.Show("Lưu file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
                MessageBox.Show("Lưu file thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }

        private void btnDocFileTB_Click(object sender, EventArgs e)
        {
            if(dsThietBi.DocFile("DanhSachThietBi.dat"))
            {
                MessageBox.Show("Đọc file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi(dgvDanhSachThietBi, dsThietBi.DSThietBi);
            }
            else
            {
                MessageBox.Show("Đọc file thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimTB_Click(object sender, EventArgs e)
        {
            ThietBi ketQua;
            ketQua = dsThietBi.TimKiemThietBi(txtMaThietBi.Text);
            List<ThietBi> dsKetQua = new List<ThietBi>();
            dsKetQua.Add(ketQua);
            HienThi(dgvDanhSachThietBi, dsKetQua);
        }

        private void bthTimThietBiTheoTen_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty( txtTenThietBi.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<ThietBi> dsKetQua = dsThietBi.TimTheoTenTB(txtTenThietBi.Text);
            HienThi(dgvDanhSachThietBi, dsKetQua);
        }
    }
}
