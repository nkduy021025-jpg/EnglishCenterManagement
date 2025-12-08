using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagement
{
    [Serializable]
    internal class ChuongTrinhHoc
    {
        private string maChuongTrinh;
        private string tenChuongTrinh;
        private string thoiGianHoc;
        private string doiTuongHoc;
        private float hocPhi;
        private string moTa;
        private string loTrinhHoc;

        public ChuongTrinhHoc()
        {
            this.maChuongTrinh = "";
            this.tenChuongTrinh = "";
            this.thoiGianHoc = "";
            this.doiTuongHoc = "";
            this.hocPhi = 0.0f;
            this.moTa = string.Empty;
        }
        public ChuongTrinhHoc(string maChuongTrinh, string tenChuongTrinh, string thoiGianHoc, string doiTuongHoc, float hocPhi, string moTa, string loTrinhHoc)
        {
            this.maChuongTrinh = maChuongTrinh;
            this.tenChuongTrinh = tenChuongTrinh;
            this.thoiGianHoc = thoiGianHoc;
            this.doiTuongHoc = doiTuongHoc;
            this.hocPhi = hocPhi;
            this.moTa = moTa;
            this.loTrinhHoc = loTrinhHoc;
        }
        public string MaChuongTrinh
        {
            get { return this.maChuongTrinh; }
            set { this.maChuongTrinh = value; }
        }
        public string TenChuongTrinh
        {
            get { return this.tenChuongTrinh; }
            set { this.tenChuongTrinh = value; }
        }
        public string DoiTuongHoc
        {
            get { return this.doiTuongHoc; }
            set { this.doiTuongHoc = value; }
        } 
        public string ThoiGianHoc
        {
            get { return this.thoiGianHoc ; }
            set { this.thoiGianHoc = value;}
        }
        public float HocPhi
        {
            get { return this.hocPhi; }
            set { this.hocPhi = value; }
        }
        public string MoTa
        {
            get { return this.moTa; }
            set { this.moTa = value; }
        }
        public string LoTrinhHoc
        {
            get { return this.loTrinhHoc; }
            set { this.loTrinhHoc = value; }
        }
    }
}
