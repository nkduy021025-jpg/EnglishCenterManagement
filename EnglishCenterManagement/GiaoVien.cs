using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagement
{
    [Serializable]
    internal class GiaoVien
    {
        private string MaGV;
        private string HoTen;
        private string CCCD;
        private DateTime NgaySinh;
        private string GioiTinhGV;
        private string SDT;
        private string DiaChi;
        private string Email;
        private int ThamNien;
        private string BangCap;
        private DateTime NgayVaoLam;

        public string maGV
        {
            get { return this.MaGV; }
            set { this.MaGV = value; }
        }
        public string hoTenGV
        {
            get { return this.HoTen; }
            set { this.HoTen = value; }
        }
        public string gioiTinh
        {
            get { return this.GioiTinhGV; }
            set { this.GioiTinhGV = value; }
        }
        public string cccdgv
        {
            get { return this.CCCD; }
            set { this.CCCD = value; }
        }
        public DateTime ngaySinhGV
        {
            get { return this.NgaySinh; }
            set { this.NgaySinh = value; }
        }
        public string diaChiGV
        {
            get { return this.DiaChi; }
            set { this.DiaChi = value; }
        }
        public string sdtGV
        {
            get { return this.SDT; }
            set { this.SDT = value; }
        }
        public string email
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
        public int thamNien
        {
            get { return this.ThamNien; }
            set { this.ThamNien = value; }
        }
        public string bangCap
        {
            get { return this.BangCap; }
            set { this.BangCap = value; }
        }
        public DateTime ngayVaoLam
        {
            get { return this.NgayVaoLam; }
            set { this.NgayVaoLam = value; }
        }
        public double luong
        {
            get { return TinhLuong(); }
        }
        public double TinhLuong()
        {
            double luong = 0;
            if (thamNien <= 5)
            {
                luong = thamNien * 2000000;
            }
            else if (thamNien > 5 && thamNien <= 10)
            {
                luong = thamNien * 3000000;
            }
            else if (thamNien > 10)
            {
                luong = thamNien * 5000000;
            }
            return luong;
        }

        public GiaoVien()
        {
            this.MaGV= "";
            this.HoTen= "";
            this.CCCD= "";
            this.NgaySinh= DateTime.Now;
            this.GioiTinhGV = "";
            this.SDT= "";
            this.Email= "";
            this.DiaChi = "";
            this.ThamNien= 0;
            this.BangCap= "";
            this.NgayVaoLam= DateTime.Now;
        }

        public GiaoVien(string maGV, string hoTenGV, string cccdgv, DateTime ngaySinh,string gioiTinh,string diaChi, string sdt, string email, int thamNien, string bangCap, DateTime ngayVaoLam)
        {
            this.MaGV = maGV;
            this.HoTen = hoTenGV;
            this.CCCD = cccdgv;
            this.NgaySinh = ngaySinh;
            this.GioiTinhGV = gioiTinh;
            this.DiaChi = diaChi;
            this.SDT = sdt;
            this.Email = email;
            this.ThamNien = thamNien;
            this.BangCap = bangCap;
            this.NgayVaoLam = ngayVaoLam;
        }
        public string TachTen()
        {
            string[] parts = hoTenGV.Trim().Split(' ');
            return parts[parts.Length - 1];
        }
    }
}
