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
    public partial class UC_GiaoVien : UserControl
    {
        private DanhSachGiaoVien dsGiaoVien = new DanhSachGiaoVien();
        private int viTri = -1;
        public UC_GiaoVien()
        {
            InitializeComponent();
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtMaGV.Text))
                {
                    MessageBox.Show("Vui lòng chọn giáo viên cần sửa từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                GiaoVien gv = new GiaoVien();
                gv.maGV = txtMaGV.Text;
                gv.hoTenGV = txtHoTenGV.Text;
                gv.cccdgv = txtCCCDGV.Text;
                gv.ngaySinhGV = dtpNgaySinhGV.Value;
                if (radNamGV.Checked == true)
                    gv.gioiTinh = "Nam";
                else if (radNuGV.Checked == true)
                    gv.gioiTinh = "Nữ";
                gv.sdtGV = txtSDTGV.Text;
                gv.email = txtEmail.Text;
                gv.thamNien = int.Parse(cbbThamNien.Text);
                gv.bangCap = cbbBangCap.Text;
                gv.ngayVaoLam = dtpNgayVaoLam.Value;
                if (dsGiaoVien.SuaGiaoVien(gv, viTri) == true)
                {
                    MessageBox.Show("Đã sửa được giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi(dgvDanhSachGiaoVien, dsGiaoVien.DSGiaoVien);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            string maGV=txtMaGV.Text;
            string hoTen =txtHoTenGV.Text;
            string CCCD=txtCCCDGV.Text;
            DateTime ngaySinh = dtpNgaySinhGV.Value;
            string gioiTinh="";
            if (radNamGV.Checked == true)
                gioiTinh = "Nam";
            else if (radNuGV.Checked == true)
                gioiTinh = "Nữ";
                string SDT = txtSDTGV.Text;
            string diaChi=txtDiaChiGV.Text;
            string email=txtEmail.Text;
            int thamNien=int.Parse(cbbThamNien.Text);
            string bangCap=cbbBangCap.Text;
            DateTime ngayVaoLam=dtpNgayVaoLam.Value;
            
            GiaoVien gv=new GiaoVien(maGV,hoTen,CCCD,ngaySinh,gioiTinh,diaChi,SDT,email,thamNien,bangCap,ngayVaoLam);
            bool ketQuaThem = dsGiaoVien.ThemGiaoVien(gv);
            if (ketQuaThem == true)
            {
                MessageBox.Show("Đã thêm 1 giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi(dgvDanhSachGiaoVien, dsGiaoVien.DSGiaoVien);
            }
            else
            {
                MessageBox.Show("Mã giáo viên này đã tồn tại, vui lòng nhập 1 mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void HienThi(DataGridView dgv, List<GiaoVien> ds)
        {
            dgv.DataSource = ds.ToList();
        }

        private void dgvDanhSachGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri= e.RowIndex;
            GiaoVien gv = new GiaoVien();
            gv = dsGiaoVien.DSGiaoVien[viTri];
            txtMaGV.Text = gv.maGV;
            txtHoTenGV.Text = gv.hoTenGV;
            txtCCCDGV.Text = gv.cccdgv;
            dtpNgaySinhGV.Value = gv.ngaySinhGV;
            string gioiTinh = gv.gioiTinh;
            if(gioiTinh.Equals("Nam"))
            {
                radNamGV.Checked = true;
            }
            else if(gioiTinh.Equals("Nữ"))
            {
                radNuGV.Checked = true;
            }
            txtDiaChiGV.Text = gv.diaChiGV;
            txtSDTGV.Text = gv.sdtGV;
            txtEmail.Text = gv.email;
            cbbThamNien.Text = gv.thamNien.ToString();
            cbbBangCap.Text = gv.bangCap;
            dtpNgayVaoLam.Value = gv.ngayVaoLam;

        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show(" Bạn có chắc chắn muốn xóa giáo viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                bool ketQuaXoa = dsGiaoVien.XoaGiaoVien(viTri);
                if (ketQuaXoa == true)
                {
                    MessageBox.Show("Đã xóa giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi(dgvDanhSachGiaoVien, dsGiaoVien.DSGiaoVien);
                }
            }
            else
            {
                MessageBox.Show("Không xóa!", "Lựa chọn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnLuuGV_Click(object sender, EventArgs e)
        {
            if (dsGiaoVien.GhiFileGV("DanhSachGiaoVien.dat") == true)
            {
                MessageBox.Show("Đã lưu file giáo viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi không lưu được file giáo viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTimGV_Click(object sender, EventArgs e)
        {
            List<GiaoVien> ketqua = new List<GiaoVien>();
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text) || string.IsNullOrWhiteSpace(cbbTimKiem.Text))
            {
                MessageBox.Show("Vui lòng chọn chức năng hoặc nhập đầy đủ vào thanh tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbTimKiem.Text == "Tìm theo mã")
            {
                ketqua = dsGiaoVien.TimKiemGV(txtTimKiem.Text);
                HienThi(dgvDanhSachGiaoVien, ketqua);
            }
            else if (cbbTimKiem.Text == "Tìm theo tên")
            {
                ketqua = dsGiaoVien.TimKiemTheoTen(txtTimKiem.Text);
                HienThi(dgvDanhSachGiaoVien, ketqua);
            }
            else if (cbbTimKiem.Text == "Tìm theo thâm niên")
            {
                ketqua = dsGiaoVien.TimTheoThamNien(int.Parse(txtTimKiem.Text));
                HienThi(dgvDanhSachGiaoVien, ketqua);
            }
            else
            {
                ketqua = dsGiaoVien.TimTheoGioiTinh(radNamGV.Text);
                HienThi(dgvDanhSachGiaoVien, ketqua);
            }
        }
        //private void btnTimTheoTen_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtHoTenGV.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập tên giáo viên cần tìm từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    List<GiaoVien> ketqua;
        //    ketqua=dsGiaoVien.TimKiemTheoTen(txtHoTenGV.Text);
        //    HienThi(dgvDanhSachGiaoVien, ketqua);
        //}

        //private void btnTimTheoThamNien_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(cbbThamNien.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập thâm niên giáo viên cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    List<GiaoVien> ketQua;
        //    ketQua = dsGiaoVien.TimTheoThamNien(int.Parse(cbbThamNien.Text));
        //    HienThi(dgvDanhSachGiaoVien,ketQua);
        //}

        //private void btnTimTheoGioiTinh_Click(object sender, EventArgs e)
        //{
        //    string gioiTinh = "";

        //    if (radNamGV.Checked == true)
        //        gioiTinh = "Nam";
        //    else if (radNuGV.Checked == true)
        //        gioiTinh = "Nữ";
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn giới tính cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    List<GiaoVien> ketQua = dsGiaoVien.TimTheoGioiTinh(gioiTinh);

        //    HienThi(dgvDanhSachGiaoVien, ketQua);
        //}

        private void UC_GiaoVien_Load(object sender, EventArgs e)
        {
            bool kiemtradoc = dsGiaoVien.DocFileGV("DanhSachGiaoVien.dat");
            if (kiemtradoc)
            {
                HienThi(dgvDanhSachGiaoVien, dsGiaoVien.DSGiaoVien);
            }
            else
            {
                MessageBox.Show("Lỗi không thể xem danh sách giáo viên!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            HienThi(dgvDanhSachGiaoVien, dsGiaoVien.DSGiaoVien);
        }
    }
}
