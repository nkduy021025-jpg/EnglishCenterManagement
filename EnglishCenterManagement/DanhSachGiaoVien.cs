using System;
using System.Collections.Generic;
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
          
    }
}
