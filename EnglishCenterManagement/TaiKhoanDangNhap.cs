using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagement
{
    [Serializable]
    internal class TaiKhoanDangNhap
    {
        private string taiKhoan;
        private string matKhau;
        
        public TaiKhoanDangNhap () 
        {
            taiKhoan = "";
            matKhau = "";
            
        }
        public TaiKhoanDangNhap (string taiKhoan, string matKhau)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;             
        }
        public string TaiKhoan
        {
            get { return this.taiKhoan; }
            set { this.taiKhoan = value; }
        }
        public string MatKhau
        {
            get { return this.matKhau; }
            set { this.matKhau = value; }
        }
      
    }
}
