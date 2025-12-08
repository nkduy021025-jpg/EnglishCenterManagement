using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagement
{
    [Serializable]
    internal class ThietBi
    {
        private string MaTB;
        private string TenTB;
        private string TinhTrang;
        private DateTime NgayNhap;
        private double GiaTien;
        public string maTB
        {
            get { return this.MaTB; }
            set { this.MaTB = value; }
        }
        public string tenTB
        {
            get { return this.TenTB; }
            set { this.TenTB = value; }
        }
        public string tinhTrang
        {
            get { return this.TinhTrang; }
            set { this.TinhTrang = value; }
        }
        public DateTime ngayNhap
        {
            get { return this.NgayNhap; }
            set { this.NgayNhap = value; }
        }
        public double giaTien
        {
            get { return this.GiaTien; }
            set { this.GiaTien = value; }
        }
        public ThietBi()
        {
            this.MaTB = null;
            this.TenTB = null;
            this.TinhTrang = null;
            this.NgayNhap= DateTime.Now;
            this.GiaTien = 0;
        }
        public ThietBi(string maTB, string tenTB, string tinhTrang, DateTime ngayNhap, double giaTien)
        {
            this.MaTB = maTB;
            this.TenTB = tenTB;
            this.TinhTrang = tinhTrang;
            this.NgayNhap = ngayNhap;
            this.GiaTien = giaTien;
        }
    }
}
