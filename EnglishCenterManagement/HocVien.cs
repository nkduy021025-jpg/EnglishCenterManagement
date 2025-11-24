using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagement
{
    internal class HocVien
    {
        private string MaHV;
        private string HoTen;
        private string CCCD;
        private DateTime NgaySinh;
        private string GioiTinh;
        private string DiaChi;
        private string SoDienThoai;
        private string TrinhDo;
        private string ChuongTrinhHoc;
        private DateTime NgayDangKy;

        public string maHV
        {
            get { return this.MaHV; }
            set { this.MaHV = value; }
        }
        public string hoTen
        {
            get { return this.HoTen; }
            set { this.HoTen = value; }
        }
        public string cccdhv
        {
            get { return this.CCCD; }
            set { this.CCCD = value; }
        }
        public DateTime ngaySinh
        {
            get { return this.NgaySinh; }
            set { this.NgaySinh = value; }
        }
        public string gioiTinh
        {
            get { return this.GioiTinh; }
            set { this.GioiTinh = value; }
        }
        public string diaChi
        {
            get { return this.DiaChi; }
            set { this.DiaChi = value; }
        }
        public string SDT
        {
            get { return this.SoDienThoai; }
            set { this.SoDienThoai = value; }
        }
        public string trinhDo
        {
            get { return this.TrinhDo; }
            set { this.TrinhDo = value; }
        }
        public string chuongTrinhHoc
        {
            get { return this.ChuongTrinhHoc; }
            set { this.ChuongTrinhHoc = value; }
        }
        public DateTime ngayDangKy
        {
            get { return this.NgayDangKy; }
            set { this.NgayDangKy = value; }
        }
        public HocVien() { 
        MaHV = "";
        HoTen = "";
        CCCD = "";
        NgaySinh = DateTime.Now;
        GioiTinh = "";
        DiaChi = "";
        SoDienThoai = "";
        TrinhDo = "";
        ChuongTrinhHoc = "";
        NgayDangKy = DateTime.Now;
        }
        public HocVien(string maHV, string hoTen, string cccdhv, DateTime ngaySinh, string gioiTinh, string diaChi, string sdt, string trinhDo, string chuongTrinhHoc, DateTime ngayDangKy)
        {
            MaHV = maHV;
            HoTen = hoTen;
            CCCD = cccdhv;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDienThoai = sdt;
            TrinhDo = trinhDo;
            ChuongTrinhHoc = chuongTrinhHoc;
            NgayDangKy = ngayDangKy;
        }
    }
}
