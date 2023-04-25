using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCaFe.DAO;
using QuanLyCaFe.DTO;

namespace QuanLyCaFe
{
    public partial class FTKHoaDon : Form
    {
        private Panel panel1;
        private Panel panel2;
        private Button btXemCTHD;
        private NumericUpDown nudMaHoaDon;
        private DataGridView dtvTKHoaDon;
        private string tk;

        public FTKHoaDon()
        {
            InitializeComponent();
        }
        public FTKHoaDon(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            dtvTKHoaDon.DataSource = HoaDonDAO.Instance.getDSHDTheoTK(tk);
        }
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudMaHoaDon = new System.Windows.Forms.NumericUpDown();
            this.btXemCTHD = new System.Windows.Forms.Button();
            this.dtvTKHoaDon = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvTKHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtvTKHoaDon);
            this.panel1.Location = new System.Drawing.Point(2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 480);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudMaHoaDon);
            this.panel2.Controls.Add(this.btXemCTHD);
            this.panel2.Location = new System.Drawing.Point(798, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 426);
            this.panel2.TabIndex = 1;
            // 
            // nudMaHoaDon
            // 
            this.nudMaHoaDon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaHoaDon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudMaHoaDon.Location = new System.Drawing.Point(19, 83);
            this.nudMaHoaDon.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaHoaDon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaHoaDon.Name = "nudMaHoaDon";
            this.nudMaHoaDon.Size = new System.Drawing.Size(120, 30);
            this.nudMaHoaDon.TabIndex = 2;
            this.nudMaHoaDon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btXemCTHD
            // 
            this.btXemCTHD.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemCTHD.Location = new System.Drawing.Point(3, 18);
            this.btXemCTHD.Name = "btXemCTHD";
            this.btXemCTHD.Size = new System.Drawing.Size(147, 36);
            this.btXemCTHD.TabIndex = 1;
            this.btXemCTHD.Text = "Xem Chi Tiết";
            this.btXemCTHD.UseVisualStyleBackColor = true;
            this.btXemCTHD.Click += new System.EventHandler(this.btXemCTHD_Click);
            // 
            // dtvTKHoaDon
            // 
            this.dtvTKHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvTKHoaDon.Location = new System.Drawing.Point(4, 7);
            this.dtvTKHoaDon.Name = "dtvTKHoaDon";
            this.dtvTKHoaDon.RowHeadersWidth = 51;
            this.dtvTKHoaDon.RowTemplate.Height = 24;
            this.dtvTKHoaDon.Size = new System.Drawing.Size(786, 472);
            this.dtvTKHoaDon.TabIndex = 0;
            // 
            // FTKHoaDon
            // 
            this.ClientSize = new System.Drawing.Size(969, 495);
            this.Controls.Add(this.panel1);
            this.Name = "FTKHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hóa đơn";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvTKHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btXemCTHD_Click(object sender, EventArgs e)
        {
            int maHD=(int)nudMaHoaDon.Value;
            FCT_HoaDon ftk = new FCT_HoaDon(maHD,tk);
            this.Hide();
            ftk.ShowDialog();
            this.Show();
        }
    }
}
