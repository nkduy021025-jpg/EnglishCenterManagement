using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagement
{
    [Serializable]
    internal class ThoiKhoaBieu
    {
        private string maThoiKhoaBieu;
        private DateTime ngayBatDauHoc;
        private DateTime ngayKetThuc;
        private string maChuongTrinhHoc;
        private string ngayHoc;
        private string caHoc;
        private string phongHoc;

        public ThoiKhoaBieu()
        {
            this.maThoiKhoaBieu = string.Empty;
            this.ngayBatDauHoc = DateTime.Now;
            this.ngayKetThuc = DateTime.Now;
            this.maChuongTrinhHoc = string.Empty;
            this.ngayHoc = string.Empty;
            this.caHoc = string.Empty;
            this.phongHoc = string.Empty;
        }
        public ThoiKhoaBieu(string maThoiKhoaBieu, DateTime ngayBatDauHoc, DateTime ngayKetThuc, string maChuongTrinhHoc, string ngayHoc, string caHoc, string phongHoc)
        {
            this.maThoiKhoaBieu = maThoiKhoaBieu;
            this.ngayBatDauHoc = ngayBatDauHoc;
            this.ngayKetThuc = ngayKetThuc;
            this.maChuongTrinhHoc = maChuongTrinhHoc;
            this.ngayHoc = ngayHoc;
            this.caHoc = caHoc;
            this.phongHoc = phongHoc;
        }
        public string MaThoiKhoaBieu
        {
            get { return this.maThoiKhoaBieu; }
            set { this.MaThoiKhoaBieu = value; }
        }
        public DateTime NgayBatDauHoc
        {
            get { return this.ngayBatDauHoc; }
            set { this.ngayBatDauHoc = value; }
        }
        public DateTime NgayKetThuc
        {
            get { return this.ngayKetThuc; }
            set { this.ngayBatDauHoc = value; }
        }
        public string MaChuongTrinhHoc
        {
            get { return this.maChuongTrinhHoc; }
            set { this.maChuongTrinhHoc = value; }
        }
        public string NgayHoc
        {
            get { return this.ngayHoc; }
            set { this.ngayHoc = value; }
        }
        public string CaHoc
        {
            get { return this.caHoc; }
            set { this.caHoc = value; }
        }
        public string PhongHoc
        {
            get { return this.phongHoc; }
            set { this.phongHoc = value; }
        }
    }
    }
