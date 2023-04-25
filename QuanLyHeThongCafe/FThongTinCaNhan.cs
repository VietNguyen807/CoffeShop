using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCaFe
{
    public partial class FThongTinCaNhan : Form
    {
        private TaiKhoan taiKhoan;

        public TaiKhoan TaiKhoan
        {
            get => taiKhoan;
            set
            {
                taiKhoan = value;
                ChangeTaiKhoan(taiKhoan);
            }
        }
        public FThongTinCaNhan()
        {
            InitializeComponent();
            loadThongTin();
        }
        public FThongTinCaNhan(TaiKhoan tk)
        {
            taiKhoan = tk;
            InitializeComponent();
            loadThongTin();
        }
        void ChangeTaiKhoan(TaiKhoan tk)
        {
            TbxTenDangNhap.Text = tk.TenDangNhap;
            TbxHoTen.Text = tk.HoTen;
            TbxMatKhau.Text = tk.MatKhau;
        }
        private void loadThongTin()
        {
            TbxTenDangNhap.Show();
        }
        private void FThongTinCaNhan_Load(object sender, EventArgs e)
        {
            TbxTenDangNhap.Text = taiKhoan.TenDangNhap;
            TbxHoTen.Text = taiKhoan.HoTen;
            TbxMatKhau.Text = taiKhoan.MatKhau;
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            FTKHoaDon ftk = new FTKHoaDon(taiKhoan.TenDangNhap);
            this.Hide();
            ftk.ShowDialog();
            this.Show();
        }
    }
}
