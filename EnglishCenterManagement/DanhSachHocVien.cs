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
    internal class DanhSachHocVien
    {
        private List<HocVien> dsHocVien;
        public DanhSachHocVien()
        {
            this.dsHocVien = new List<HocVien>();
        }
        public DanhSachHocVien(List<HocVien> dsHocVien)
        {
            this.dsHocVien = dsHocVien;
        }
        public List<HocVien> DSHocVien
        {
            get { return this.dsHocVien; }
            set { this.dsHocVien = value; }
        }
        public bool KiemTraHocVien(string ma)
        {
            foreach(HocVien hv in this.dsHocVien)
            {
                if (hv.maHV.Equals(ma))
                    return true;
            }
            return false;
        }
        public bool ThemHocVien(HocVien hv)
        {
            if (KiemTraHocVien(hv.maHV)) return false;
            else
            {
                this.dsHocVien.Add(hv);
                return true;
            }
        }
        public bool XoaHocVien(int viTri)
        {
            this.dsHocVien.RemoveAt(viTri);
            return true;
        }
        public bool SuaHocVien(HocVien hv,int viTri)
        {
            this.dsHocVien[viTri] = hv;
            return true;
        }
        public bool GhiFile(string tenFile)
        {
            try
            {
                FileStream fs=new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf=new BinaryFormatter();
                bf.Serialize(fs, this.dsHocVien);
                fs.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool DocFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                this.dsHocVien=(List<HocVien>) bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public HocVien TimKiemHocVien(string maHV)
        {
            foreach(HocVien hv in this.dsHocVien)
            {
                if (hv.maHV.Equals(maHV))
                    return hv;
            }
            return null;
        }
        public List<HocVien> TimKiemTheoTen(string ten)
        {
            List<HocVien> ketQua = new List<HocVien>();
            foreach (HocVien hv in this.dsHocVien)
            {
                if (hv.TachTen().Equals(ten))
                {
                    ketQua.Add(hv);
                }
            }
            return ketQua;
        }
        public List<HocVien> TimTheoGioiTinh(string gioiTinh)
        {
            List<HocVien> ketQua = new List<HocVien>();

            foreach (HocVien hv in this.dsHocVien)
            {
                if (hv.gioiTinh.Equals(gioiTinh))
                {
                    ketQua.Add(hv);
                }
            }

            return ketQua;
        }
    }
}
