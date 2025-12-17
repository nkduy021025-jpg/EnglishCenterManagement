using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishCenterManagement
{
    [Serializable]
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
        public List<ThuChi> TimKiemTheoMa(string ma)
        {
            List<ThuChi> TimKiem = new List<ThuChi>();          
            foreach(ThuChi tc in DSThuChi)
            {
                if (tc.maThuChi.Equals(ma))
                    TimKiem.Add(tc);
                    
            }
            return TimKiem;
        }
        public List<ThuChi> TimKiemTheoSoTien (float sotien)
        {
            List<ThuChi> TimKiem = new List<ThuChi> ();     
            foreach (ThuChi tc in dsThuChi)
            {
                if (tc.soTien.Equals(sotien))
                {
                    TimKiem.Add(tc);
                }
            }return TimKiem;
        }
        public List<ThuChi> TimTheoThoiGian (DateTime thoigian)
        {
            List<ThuChi> TimKiem = new List<ThuChi>();
            foreach (ThuChi thuChi in dsThuChi)
            {
                if (thuChi.ngayThuChi.Date.Equals(thoigian.Date))
                {
                    TimKiem.Add(thuChi);
                }
            }return TimKiem;
        }
        public bool DocFileThuChi(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile,FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                DSThuChi = (List<ThuChi>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public double TongThuChiThang (string thuchi ,int thang)
        {
            double tong=0;
            foreach (ThuChi tc in dsThuChi) 
            {
                if ( tc.luaChonThuChi.Equals(thuchi) && tc.ngayThuChi.Month.Equals(thang))
                {
                    tong += tc.soTien;
                }
            }return tong;
        }
        public bool GhiFileThuChi(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                
                bf.Serialize(fs, DSThuChi);
                fs.Close();
                return true;
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
