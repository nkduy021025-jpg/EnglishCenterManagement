using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagement
{
    [Serializable]
    internal class DanhSachChuongTrinhHoc
    {
        private List<ChuongTrinhHoc> ctrinhHoc;
        public DanhSachChuongTrinhHoc () 
        {
            ctrinhHoc = new List<ChuongTrinhHoc> (); 
        }
        public DanhSachChuongTrinhHoc(List<ChuongTrinhHoc> ctrinhHoc)
        {
            this.ctrinhHoc = ctrinhHoc;       
        }
        public List<ChuongTrinhHoc> CTrinhHoc
        {
            get { return ctrinhHoc; }
            set { this.ctrinhHoc = value; }
        }
        public bool KiemTraMa(string ma)
        {
            foreach (ChuongTrinhHoc ct in ctrinhHoc)
            {
                if (ct.MaChuongTrinh.Equals(ma))
                {
                    return false;
                }
            }return true;
        }
        public bool Them (ChuongTrinhHoc ct)
        {
            if (KiemTraMa(ct.MaChuongTrinh))
            {
                ctrinhHoc.Add(ct);
                return true;
            }return false;
        }
        public bool Xoa (int vitri)
        {
            ctrinhHoc.RemoveAt(vitri);
            return true;
        }
        public bool Sua (int vitri,ChuongTrinhHoc ct)
        {
            ctrinhHoc[vitri] = ct;
            return true;
        }
        public List<ChuongTrinhHoc> TimKiemTheoMa (string ma)
        {
            List <ChuongTrinhHoc> chuongtrinh = new List<ChuongTrinhHoc> ();
            foreach (ChuongTrinhHoc timkiem in ctrinhHoc)
            {
                if (timkiem.MaChuongTrinh.Equals(ma))
                {
                    chuongtrinh.Add(timkiem);
                }
            }return chuongtrinh;
        }
        public List<ChuongTrinhHoc> TimKiemTheoTenCT(string ten)
        {
            List<ChuongTrinhHoc> timkiem = new List<ChuongTrinhHoc>();
            foreach (ChuongTrinhHoc cth in ctrinhHoc)
            {
                if (cth.TenChuongTrinh.Equals(ten)) 
                {
                    timkiem.Add(cth);
                }
            }return timkiem;
        }
        public List<ChuongTrinhHoc> TimKiemTheoHocPhi(float HocPhi)
        {
            List<ChuongTrinhHoc> timkiem = new List<ChuongTrinhHoc>();
            foreach (ChuongTrinhHoc cth in ctrinhHoc)
            {
                if (cth.HocPhi.Equals(HocPhi))
                {
                    timkiem.Add(cth );
                }
            }return timkiem;
        }
        public List<ChuongTrinhHoc> TimKiemTheoDoiTuong (string DoiTuong)
        {
            List<ChuongTrinhHoc> timkiem = new List<ChuongTrinhHoc> ();
            foreach (ChuongTrinhHoc cth in ctrinhHoc)
            {
                if (cth.DoiTuongHoc.Equals(DoiTuong))
                {
                    timkiem.Add(cth);
                }
            }return timkiem;
        }

        public bool ghiFileCT(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this.ctrinhHoc);
                fs.Close();
                return true;
            }
            catch
            {

                return false;
            }
        }
            public bool docFileCT (string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                ctrinhHoc = (List<ChuongTrinhHoc>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch 
            {

                return false;
            }
        }
    }
}
