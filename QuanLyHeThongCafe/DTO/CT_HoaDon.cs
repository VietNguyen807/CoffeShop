using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyCaFe.DTO
{
    public class CT_HoaDon
    {
        private int maHD;
        private int maMon;
        private int soLuong;
        public CT_HoaDon(int maHD,int maMon,int soLuong)
        {
            this.maHD = maHD;
            this.maMon = maMon;
            this.soLuong = soLuong;
        }
        public CT_HoaDon()
        {
        }
        public CT_HoaDon(DataRow r)
        {
            this.maHD = (int)r["MaHD"];
            this.maMon = (int)r["MaMon"];
            this.soLuong = (int)r["SoLuong"];
        }
        public int MaHD { get => maHD; set => maHD = value; }
        public int MaMon { get => maMon; set => maMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
