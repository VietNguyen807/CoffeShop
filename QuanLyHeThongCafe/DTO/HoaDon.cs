using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyCaFe.DTO
{
    public class HoaDon
    {
        private int maHoaDon;
        private int maBan;
        private int trangThai;
        private string tenDangNhap;
        public HoaDon(int maHoaDon,int maBan,int trangThai)
        {
            this.maHoaDon= maHoaDon;
            this.maBan = maBan;
            this.trangThai = trangThai;
            this.TenDangNhap = TenDangNhap;
        }
        public HoaDon(DataRow d)
        {
            this.maHoaDon = (int)d["MaHD"];
            this.maBan = (int)d["MaBan"];
            this.trangThai = (int)d["TrangThai"];
            this.TenDangNhap = d["TenDangNhap"].ToString();
        }
        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int MaBan { get => maBan; set => maBan = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
    }
}
