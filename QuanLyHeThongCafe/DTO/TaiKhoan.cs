using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyCaFe.DTO
{
    public class TaiKhoan
    {
        private string tenDangNhap;
        private string hoTen;
        private string matKhau;
        private int loaiTaiKhoan;
        public TaiKhoan() { }
        public TaiKhoan(string tenDangNhap, string hoTen,string matKhau,int loaiTaiKhoan)
        {
            this.tenDangNhap = tenDangNhap;
            this.hoTen = hoTen;
            this.matKhau = matKhau;
            this.loaiTaiKhoan = loaiTaiKhoan;
        }
        public TaiKhoan(DataRow d)
        {
            this.tenDangNhap = d["TenDangNhap"].ToString();
            this.hoTen = d["HoTen"].ToString();
            this.matKhau = d["MatKhau"].ToString();
            this.loaiTaiKhoan = (int)d["LoaiTaiKhoan"];
        }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
    }
}
