using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishCenterManagement
{
    [Serializable]
    internal class DanhSachThoiKhoaBieu
    {
        List<ThoiKhoaBieu> dsTKB;
        public DanhSachThoiKhoaBieu()
        {
            DSTKB = new List<ThoiKhoaBieu>();
        }
        public DanhSachThoiKhoaBieu(List<ThoiKhoaBieu> DSTKB)
        {
            this.DSTKB = DSTKB;
        }
        public List<ThoiKhoaBieu> DSTKB
        {
            get { return this.dsTKB; }
            set { this.dsTKB = value; }
        }
        public bool KiemTraMa(string ma)
        {
            foreach (ThoiKhoaBieu tkb in dsTKB)
            {
                if (tkb.MaThoiKhoaBieu.Equals(ma))
                {
                    return false;
                }
            }
            return true;
        }
        public bool ThemTKB (ThoiKhoaBieu tkb)
        {
            if (KiemTraMa(tkb.MaThoiKhoaBieu))
            {
                dsTKB.Add(tkb);
                return true;    
            }return false;
        }
        public bool XoaTKB (int vitri)
        {
            dsTKB.RemoveAt (vitri);
            return true;    
        }
        public bool SuaTKB(int vitri, ThoiKhoaBieu tkb) 
        {
            dsTKB[vitri] = tkb; 
            return true;
        }
        public List<ThoiKhoaBieu> KiemTheoMa(string ma) 
        {
            List<ThoiKhoaBieu> timkiem = new List<ThoiKhoaBieu>();
            foreach (ThoiKhoaBieu tkb in dsTKB)
            {
                if (tkb.MaThoiKhoaBieu.Equals(ma))
                {
                    timkiem.Add(tkb);
                }
            }return timkiem;
        }
        public List <ThoiKhoaBieu> KiemTheoMaCT (string ma)
        {
            List <ThoiKhoaBieu> timkiem = new List<ThoiKhoaBieu> ();
            foreach (ThoiKhoaBieu tkb in dsTKB)
            {
                if (tkb.MaChuongTrinhHoc.Equals(ma))
                {
                    timkiem.Add(tkb);
                }
            }return timkiem;
        }
        public List<ThoiKhoaBieu> KiemTheoPhongHoc(string PhongHoc) 
        {
            List<ThoiKhoaBieu> timkiem = new List<ThoiKhoaBieu>();
            foreach (ThoiKhoaBieu tkb in dsTKB)
            {
                if (tkb.PhongHoc.Equals(PhongHoc))
                {
                    timkiem.Add(tkb);
                }
            }return timkiem;
        }
        public List<ThoiKhoaBieu> KiemTheoCaHoc(string caHoc) 
        {
            List<ThoiKhoaBieu> timkiem = new List<ThoiKhoaBieu>();
            foreach (ThoiKhoaBieu tkb in dsTKB)
            {
                if (tkb.CaHoc.Equals(caHoc))
                {
                    timkiem.Add(tkb);
                }
            }return timkiem;
        }

        public bool GhiFile (string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile,FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsTKB);
                fs.Close();
                return true;
            }
            catch 
            {

                return false;
            }
        }public bool DocFile(string tenFile) 
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dsTKB = (List<ThoiKhoaBieu>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch 
            {
                return false ;  
            }
           
        }
    }
}
