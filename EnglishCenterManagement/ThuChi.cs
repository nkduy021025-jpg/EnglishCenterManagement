using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagement
{
    internal class ThuChi
    {
        private string MaThuChi;
        private string LuaChonThuChi;
        private DateTime NgayThuChi;
        private double SoTien;
        private string LyDo;
        private string NoiDung;

        public ThuChi()
        {
            this.MaThuChi = null;
            this.LuaChonThuChi = null;
            this.NgayThuChi = DateTime.Now;
            this.SoTien = 0;
            this.LyDo = null;
            this.NoiDung = null;
        }
        public ThuChi(string maThuChi, string luaChonThuChi, DateTime ngayThuChi, double soTien, string lyDo, string noiDung)
        {
            this.MaThuChi = maThuChi;
            this.LuaChonThuChi = luaChonThuChi;
            this.NgayThuChi = ngayThuChi;
            this.SoTien = soTien;
            this.LyDo = lyDo;
            this.NoiDung = noiDung;
        }
        public string maThuChi
        {
            get { return this.MaThuChi; }
            set { this.MaThuChi = value; }
        }
        public string luaChonThuChi
        {
            get { return this.LuaChonThuChi; }
            set { this.LuaChonThuChi= value; }
        }
        public DateTime ngayThuChi
        {
            get { return this.NgayThuChi; }
            set { this.NgayThuChi = value; }
        }
        public double soTien
        {
            get { return this.SoTien; }
            set { this.SoTien = value; }
        }
        public string lyDo
        {
            get { return this.LyDo; }
            set { this.LyDo = value; }
        }
        public string noiDung
        {
            get { return this.NoiDung; }
            set { this.NoiDung = value; }
        }
    }
}
