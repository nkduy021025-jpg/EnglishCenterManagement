namespace EnglishCenterManagement
{
    partial class BieuDoThuChi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuanLyGiaoVien = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.catThuChi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.catThuChi)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 16);
            this.label4.TabIndex = 191;
            this.label4.Text = "---------------------------------------------------------------------------\r\n";
            // 
            // lblQuanLyGiaoVien
            // 
            this.lblQuanLyGiaoVien.AutoSize = true;
            this.lblQuanLyGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQuanLyGiaoVien.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblQuanLyGiaoVien.Location = new System.Drawing.Point(274, 53);
            this.lblQuanLyGiaoVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuanLyGiaoVien.Name = "lblQuanLyGiaoVien";
            this.lblQuanLyGiaoVien.Size = new System.Drawing.Size(513, 31);
            this.lblQuanLyGiaoVien.TabIndex = 190;
            this.lblQuanLyGiaoVien.Text = "Biểu đồ thu chi theo từng tháng năm 2025\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Location = new System.Drawing.Point(242, 1);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(587, 46);
            this.label14.TabIndex = 189;
            this.label14.Text = "ENGLISH CENTER DOUBLE D";
            // 
            // catThuChi
            // 
            chartArea2.Name = "ChartArea1";
            this.catThuChi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.catThuChi.Legends.Add(legend2);
            this.catThuChi.Location = new System.Drawing.Point(-10, 87);
            this.catThuChi.Name = "catThuChi";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.catThuChi.Series.Add(series2);
            this.catThuChi.Size = new System.Drawing.Size(1045, 415);
            this.catThuChi.TabIndex = 188;
            this.catThuChi.Text = "Biểu đồ thu chi theo từng tháng";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EnglishCenterManagement.Properties.Resources.z7257614198401_9f47daa8ab828779f1ab0654d6b1fe48;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(108, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 72);
            this.panel1.TabIndex = 192;
            // 
            // BieuDoThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblQuanLyGiaoVien);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.catThuChi);
            this.Name = "BieuDoThuChi";
            this.Text = "BieuDoThuChi";
            this.Load += new System.EventHandler(this.BieuDoThuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catThuChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuanLyGiaoVien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataVisualization.Charting.Chart catThuChi;
    }
}