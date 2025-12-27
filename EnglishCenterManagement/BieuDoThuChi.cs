using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EnglishCenterManagement
{
    public partial class BieuDoThuChi : Form
    {
        private DanhSachThuChi danhSachThuChi = new DanhSachThuChi();
        public BieuDoThuChi()
        {
            InitializeComponent();
        }
        
        private void VeBieuDo()
        {
            catThuChi.Series.Clear();
            catThuChi.Titles.Clear();
            Series Thu = new Series("Tổng Thu");
            Thu.ChartType = SeriesChartType.Column;
            Thu.Color = Color.Green;
            Series Chi = new Series("Tổng Chi");
            Chi.ChartType = SeriesChartType.Column;
            Chi.Color = Color.Red;
            for (int i = 1; i <= 12; i++)
            {
                double tienThu = danhSachThuChi.TongThuChiThang("Thu", i); 
                double tienChi = danhSachThuChi.TongThuChiThang("Chi", i); 

                Thu.Points.AddXY("Tháng " + i, tienThu);
                Chi.Points.AddXY("Tháng " + i, tienChi);
            }

            catThuChi.Series.Add(Thu);
            catThuChi.Series.Add(Chi);
            catThuChi.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";
        }

        private void BieuDoThuChi_Load(object sender, EventArgs e)
        {
            danhSachThuChi.DocFileThuChi("DanhSachThuChi.dat");
            VeBieuDo();
        }
    }
}
