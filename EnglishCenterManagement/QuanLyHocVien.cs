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
    public partial class QuanLyHocVien : Form
    {
        private DanhSachHocVien DanhSachHocVien=new DanhSachHocVien();
        private int viTri = 0;
        public QuanLyHocVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHV=txtMaHV.Text;
            string hoTen=txtHoTen.Text;
            DateTime ngaySinh=dtpNgaySinh.Value;
            string diaChi=txtDiaChi.Text;
            int sdt = int .Parse(txtSDT.Text);
            string cccd =txtCCCD.Text;
            string trinhDo=cbbTrinhDo.Text;
            string chuongTrinhHoc=cbbChuongTrinhHoc.Text;
            DateTime ngayDangKy=dtpNgayDangKy.Value;
            string gioiTinh = null;
            if(radNam.Checked==true)
                gioiTinh="Nam";
            else 
                gioiTinh="Nữ";
            HocVien hv=new HocVien(maHV,hoTen,cccd,ngaySinh,gioiTinh,diaChi,sdt,trinhDo,chuongTrinhHoc,ngayDangKy);
            bool ketQuaThem= DanhSachHocVien.ThemHocVien(hv);
            if (ketQuaThem == true)
            {
                MessageBox.Show("Đã thêm 1 học viên.","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach(dgvDanhSachHocVien, DanhSachHocVien.DSHocVien);
            }
            else
            {
                MessageBox.Show("Mã học viên này đã tồn tại, vui lòng nhập 1 mã khác!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void HienThiDanhSach(DataGridView dgv,List<HocVien> ds)
        {
            dgv.DataSource = ds.ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           DialogResult ketQuaChon=MessageBox.Show("Bạn có chắc chắn muốn xóa học viên này không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            bool ketQuaXoa=DanhSachHocVien.XoaHocVien(viTri);
            if (ketQuaXoa == true)
            {
                MessageBox.Show("Đã xóa học viên.","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSach(dgvDanhSachHocVien, DanhSachHocVien.DSHocVien);
            }
            
        }

        private void dgvDanhSachHocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                viTri = e.RowIndex;
                HocVien hv = new HocVien();
                hv = DanhSachHocVien.DSHocVien[viTri];
                txtMaHV.Text = hv.maHV;
                txtHoTen.Text = hv.hoTen;
                dtpNgaySinh.Value = hv.ngaySinh;
                txtDiaChi.Text = hv.diaChi;
                txtSDT.Text = hv.SDT.ToString();
                txtCCCD.Text = hv.cccd;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(DanhSachHocVien.GhiFile("DanhSachHocVien.dat")==true)
            {
                MessageBox.Show("Đã lưu danh sách học viên vào file.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu file không thành công.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
