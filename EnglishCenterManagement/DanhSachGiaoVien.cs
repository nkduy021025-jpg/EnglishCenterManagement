using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagement
{
    internal class DanhSachGiaoVien
    {
        private List<GiaoVien> dsGiaoVien;
        public DanhSachGiaoVien()
        {
            this.dsGiaoVien=new List<GiaoVien>();
        }
        public DanhSachGiaoVien(List<GiaoVien> dsGiaoVien)
        {
            this.dsGiaoVien = dsGiaoVien;
        }
        public List<GiaoVien> DSGiaoVien
        {
            get { return this.dsGiaoVien; }
            set { this.dsGiaoVien = value; }
        }
        public bool KiemTraMa(string ma)
        {
            foreach(GiaoVien gv in this.dsGiaoVien)
            {
                if (gv.maGV.Equals(ma))
                    return true;
            }
            return false;
        }
        public bool ThemGiaoVien(GiaoVien gv)
        {
            if (KiemTraMa(gv.maGV)) return false;
            else
            {
                this.dsGiaoVien.Add(gv);
                return true;
            }
        }
        public bool XoaGiaoVien(int viTri)
        {
            if(viTri<0 || viTri>this.dsGiaoVien.Count)
                return false;
            this.dsGiaoVien.RemoveAt(viTri);
            return true;
        }
        public bool SuaGiaoVien(GiaoVien gv,int viTri)
        {
            if (viTri < 0 || viTri > this.dsGiaoVien.Count)
                return false;
            this.dsGiaoVien[viTri] = gv;
            return true;
        }
        public bool GhiFileGV(string tenFile)
        {
            try
            {
                FileStream fs=new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf=new BinaryFormatter();
                bf.Serialize(fs, this.dsGiaoVien);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DocFileGV(string tenFile)
        {
            try
            {
                FileStream fs=new FileStream(tenFile, FileMode.Open);
                BinaryFormatter bf=new BinaryFormatter();
                dsGiaoVien=(List<GiaoVien>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public GiaoVien TimKiemGV(string ma)
        {
            foreach(GiaoVien gv in this.dsGiaoVien)
            {
                if (gv.maGV.Equals(ma))
                    return gv;
            }
            return null;
        }
    }
}
