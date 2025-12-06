using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagement
{
    internal class DanhSachThuChi
    {
        private List<ThuChi> dsThuChi;
        public DanhSachThuChi()
        {
            this.dsThuChi = new List<ThuChi>();
        }
        public DanhSachThuChi(List<ThuChi> dsThuChi)
        {
            this.dsThuChi = dsThuChi;
        }
        public List<ThuChi> DSThuChi
        {
            get { return this.dsThuChi; }
            set { this.dsThuChi = value; }
        }
        public bool KiemTraMa(string ma)
        {
            foreach(ThuChi tc in DSThuChi)
            {
                if (tc.maThuChi.Equals(ma))
                    return true;
            }
            return false;
        }
        public bool ThemPhieuThuChi(ThuChi tc)
        {
            if (KiemTraMa(tc.maThuChi))
                return false;
            else
            {
                DSThuChi.Add(tc);
                return true;
            }
        }
        public bool XoaPhieuThuChi(int viTri)
        {
            DSThuChi.RemoveAt(viTri);
            return true;
        }
        public bool SuaPhieuThuChi(ThuChi tc,int viTri)
        {
            DSThuChi[viTri] = tc;
            return true;
        }
        public ThuChi TimPhieuThuChi(string ma)
        {
            foreach(ThuChi tc in DSThuChi)
            {
                if (tc.maThuChi.Equals(ma))
                    return tc;
            }
            return null;
        }
        public bool DocFileThuChi(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile,FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, DSThuChi);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool GhiFileThuChi(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                DSThuChi = (List<ThuChi>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
