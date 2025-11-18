using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagement
{
    internal class GiaoVien
    {
        private string MaGV;
        private string HoTen;
        private string CCCD;
        private DateTime NgaySinh;
        private int SDT;
        private string Email;
        private int ThamNien;
        private string BangCap;
        private DateTime NgayVaoLam;
        private double Luong;

        public string maGV
        {
            get { return this.MaGV; }
            set { this.MaGV = value; }
        }
        public string hoTen
        {
            get { return this.HoTen; }
            set { this.HoTen = value; }
        }
        public string cccd
        {
            get { return this.CCCD; }
            set { this.CCCD = value; }
        }
        public DateTime ngaySinh
        {
            get { return this.NgaySinh; }
            set { this.NgaySinh = value; }
        }
        public int sdt
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
            get { return this.Luong; }
            set { this.Luong = value; }
        }

        public GiaoVien()
        {
            this.MaGV= "";
            this.HoTen= "";
            this.CCCD= "";
            this.NgaySinh= DateTime.Now;
            this.SDT= 0;
            this.Email= "";
            this.ThamNien= 0;
            this.BangCap= "";
            this.NgayVaoLam= DateTime.Now;
            this.Luong= 0;
        }

        public GiaoVien(string maGV, string hoTen, string cccd, DateTime ngaySinh, int sdt, string email, int thamNien, string bangCap, DateTime ngayVaoLam, double luong)
        {
            this.MaGV = maGV;
            this.HoTen = hoTen;
            this.CCCD = cccd;
            this.NgaySinh = ngaySinh;
            this.SDT = sdt;
            this.Email = email;
            this.ThamNien = thamNien;
            this.BangCap = bangCap;
            this.NgayVaoLam = ngayVaoLam;
            this.Luong = luong;
        }//code thu 

    }
}
