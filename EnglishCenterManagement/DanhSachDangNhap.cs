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
    internal class DanhSachDangNhap
    {
        
        private List<TaiKhoanDangNhap> dsDN;
        public DanhSachDangNhap() 
        {
            dsDN = new List<TaiKhoanDangNhap> ();
        }
        public DanhSachDangNhap (List<TaiKhoanDangNhap> dsDN)
        {
            this.dsDN = dsDN;
        }
        public List<TaiKhoanDangNhap> DSDN
        {
            get { return this.dsDN; }
            set { this.dsDN = value; }
        }
        public bool KiemTraTaiKhoan (string taikhoan)
        {
            foreach (TaiKhoanDangNhap tkmk in dsDN)
            {
                if (tkmk.TaiKhoan.Equals(taikhoan))
                {
                    return false;
                }
            }return true;
        }
        public bool ThemTaiKhoan(TaiKhoanDangNhap tkdn)
        {
            if (KiemTraTaiKhoan(tkdn.TaiKhoan))
            {
                dsDN.Add(tkdn);
                return true;
            }return false;
        }
        public bool GhiFileDN(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this.dsDN);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DocFileDN(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dsDN = (List<TaiKhoanDangNhap>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch
            {

                return false;
            }
        }
        public bool KiemTraDangNhap(string taikhoan, string matkhau)
        {
            foreach (TaiKhoanDangNhap tkdn in dsDN)
            {

                if (tkdn.TaiKhoan == taikhoan && tkdn.MatKhau == matkhau)
                {
                    return true;
                }
            }
            return false; 
        }
    }
}
