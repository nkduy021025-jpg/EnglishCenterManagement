using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishCenterManagement
{
    [Serializable]
    internal class DanhSachThietBi
    {
        private List<ThietBi> dsThietBi;
        public DanhSachThietBi()
        {
            this.dsThietBi = new List<ThietBi>();
        }
        public DanhSachThietBi(List<ThietBi> dsThietBi)
        {
            this.dsThietBi = dsThietBi;
        }
        public List<ThietBi> DSThietBi
        {
            get { return this.dsThietBi; }
            set { this.dsThietBi = value; }
        }
        public bool KiemTraThietBi(string ma)
        {
            foreach (ThietBi tb in this.dsThietBi)
            {
                if (tb.maTB.Equals(ma))
                    return true;
            }
            return false;
        }
        public bool ThemThietBi(ThietBi tb)
        {
            if (KiemTraThietBi(tb.maTB)) return false;
            else
            {
                this.dsThietBi.Add(tb);
                return true;
            }
        }
        public bool XoaThietBi(int viTri)
        {
            this.dsThietBi.RemoveAt(viTri);
            return true;
        }
        public bool SuaThietBi(ThietBi tb, int viTri)
        {
            this.dsThietBi[viTri] = tb;
            return true;
        }
        public bool GhiFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this.dsThietBi);
                fs.Close();
                return true;
            }
            catch (Exception)
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
                this.dsThietBi = (List<ThietBi>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public ThietBi TimKiemThietBi(string maTB)
        {
            foreach (ThietBi tb in this.dsThietBi)
            {
                if (tb.maTB.Equals(maTB))
                    return tb;
            }
            return null;
        }
        public List<ThietBi> TimTheoTenTB(string ten)
        {
            List<ThietBi> ketQua = new List<ThietBi>();
            foreach(ThietBi tb in this.dsThietBi)
            {
                if(tb.TachTen().Equals(ten))
                {
                    ketQua.Add(tb);
                }
            }
            return ketQua;
        }
    }
}
