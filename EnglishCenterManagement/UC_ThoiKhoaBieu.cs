using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishCenterManagement
{
    public partial class UC_ThoiKhoaBieu : UserControl
    {
        int vitri = -1;
        DanhSachThoiKhoaBieu DMTKB = new DanhSachThoiKhoaBieu();
        DanhSachChuongTrinhHoc dsct = new DanhSachChuongTrinhHoc();
        public UC_ThoiKhoaBieu()
        {
            InitializeComponent();
        }
        private void HienThi (DataGridView dgv , List<ThoiKhoaBieu> thoiKhoaBieu)
        {
            dgv.DataSource = thoiKhoaBieu.ToList();
        }
        private void btnThemTKB_Click(object sender, EventArgs e)
        {
            string maThoiKhoaBieu = txtMaTKB.Text;
            DateTime ngayBatDauHoc = dtpTGBDH.Value;
            DateTime ngayKetThuc = dtpTGKT.Value;       
            string maCTH = cbbMaCTHoc.Text;
            string ngayhoc = cbbNgayHoc.Text; 
            string caHoc = cbbCaHoc.Text;
            string phongHoc = cbbPhongHoc.Text;
            ThoiKhoaBieu tkb = new ThoiKhoaBieu(maThoiKhoaBieu, ngayBatDauHoc, ngayKetThuc, maCTH, ngayhoc, caHoc, phongHoc);
            bool kiemtrathem = DMTKB.ThemTKB(tkb);
            if (kiemtrathem)
            { 
                MessageBox.Show ("Đã thêm một thời khóa biểu thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi(dgvTKB, DMTKB.DSTKB);
            }
            else
            {
                MessageBox.Show("Thêm một thời khóa biểu không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvTKB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            ThoiKhoaBieu tkb = new ThoiKhoaBieu();
            tkb = DMTKB.DSTKB[vitri];
            txtMaTKB.Text = tkb.MaThoiKhoaBieu;
            dtpTGBDH.Value = tkb.NgayBatDauHoc;
            dtpTGKT.Value = tkb.NgayKetThuc;
            cbbMaCTHoc.Text = tkb.MaChuongTrinhHoc;
            cbbNgayHoc.Text = tkb.NgayHoc.ToString();
            cbbCaHoc.Text = tkb.CaHoc.ToString();
            cbbPhongHoc.Text = tkb.PhongHoc.ToString();
        }
        private void btnXoaTKB_Click(object sender, EventArgs e)
        {
            if (vitri < 0 || vitri > DMTKB.DSTKB.Count)
            {
                MessageBox.Show("Vui lòng chọn thời khóa biểu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            DialogResult ketqua = MessageBox.Show("Bạn có chắc muốn xóa thời khóa biểu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ketqua == DialogResult.Yes)
            {
                DMTKB.XoaTKB(vitri);    
            }
            else
            {
                  return;
            }
        }
        private void UC_ThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            bool ketquadocTKB = DMTKB.DocFile("DanhSachThoiKhoaBieu.dat");
            if (ketquadocTKB)
            {
                HienThi(dgvTKB, DMTKB.DSTKB);
            }
            else
            {
                MessageBox.Show("Lỗi không thể xem danh sách thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool ketquadocCT = dsct.docFileCT("DanhSachChuongTrinh.dat");
            if (ketquadocCT == true)
            {
                foreach (ChuongTrinhHoc ct in dsct.CTrinhHoc)
                {
                    cbbMaCTHoc.Items.Add(ct.MaChuongTrinh);
                }
            }
        }

        private void btnSuaTKB_Click(object sender, EventArgs e)
        {
            if (vitri < 0 || vitri > DMTKB.DSTKB.Count)
            {
                MessageBox.Show("Vui lòng chọn thời khóa biểu bạn muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string maTKB = txtMaTKB.Text;
            DateTime ngayBatDauHoc = dtpTGBDH.Value;
            DateTime ngayKetThuc = dtpTGKT.Value;
            string maCTH = cbbMaCTHoc.Text;
            string ngayHoc = cbbNgayHoc.Text;
            string cahoc = cbbCaHoc.Text;
            string phonghoc = cbbPhongHoc.Text;
            ThoiKhoaBieu tkb = new ThoiKhoaBieu(maTKB,ngayBatDauHoc,ngayKetThuc,maCTH,ngayHoc,cahoc,phonghoc);
            bool kiemtrathem = DMTKB.SuaTKB(vitri, tkb);
            if (kiemtrathem)
            {
                MessageBox.Show("Đã sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi(dgvTKB, DMTKB.DSTKB);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuTKB_Click(object sender, EventArgs e)
        {
            bool kiemtraluu = DMTKB.GhiFile("DanhSachThoiKhoaBieu.dat");
            if (kiemtraluu)
            {
                MessageBox.Show("Đã lưu thời khóa biểu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Lưu thời khóa biểu không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }
        //Chuc nang doc , neu can xai nut
        //private void btnDocTKB_Click(object sender, EventArgs e)
        //{
        //    bool kiemtradoc = DMTKB.DocFile("DanhSachThoiKhoaBieu.dat");
        //    if (kiemtradoc)
        //    {
        //        MessageBox.Show("Đã đọc thời khóa biểu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        HienThi(dgvTKB, DMTKB.DSTKB);
        //    }
        //    else 
        //    {
        //        MessageBox.Show("Đọc thời khóa biểu không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnTimTKB_Click(object sender, EventArgs e)
        {
            List<ThoiKhoaBieu> ketqua = new List<ThoiKhoaBieu>();
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text) || string.IsNullOrWhiteSpace(cbbChonTimKiemTKB.Text))
            {
                MessageBox.Show("Vui lòng chọn chức năng hoặc nhập đầy đủ vào thanh tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbChonTimKiemTKB.Text == "Theo mã thời khóa biểu")
            {
                ketqua = DMTKB.KiemTheoMa(txtTimKiem.Text);
                HienThi(dgvTKB, ketqua);
            }
            else if (cbbChonTimKiemTKB.Text == "Theo mã chương trình học")
            {
                ketqua = DMTKB.KiemTheoMaCT(txtTimKiem.Text);
                HienThi(dgvTKB, ketqua);
            }
            else if (cbbChonTimKiemTKB.Text == "Theo phòng học")
            {
                ketqua = DMTKB.KiemTheoPhongHoc(txtTimKiem.Text);
                HienThi(dgvTKB, ketqua);
            }
            else
            {
                ketqua = DMTKB.KiemTheoCaHoc(txtTimKiem.Text);
                HienThi(dgvTKB, ketqua);

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            HienThi(dgvTKB, DMTKB.DSTKB);
        }
    }
}
