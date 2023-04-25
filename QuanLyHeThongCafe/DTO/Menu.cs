using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyCaFe.DTO
{
    public class Menu
    {
        private string tenMon;
        private int soLuong;
        private int donGia;
        private int thanhTien;
        public Menu(string tenMon, int soLuong,int donGia,int thanhTien=0)
        {
            this.tenMon = tenMon;
            this.SoLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }
        public Menu(DataRow r)
        {
             this.tenMon = r["Tên món"].ToString();
            this.SoLuong = (int)r["Số lượng"];
            this.donGia = (int)r["Đơn giá"];
            this.thanhTien = (int)r["Thành tiền"];
        }
        public string TenMon1 { get => tenMon; set => tenMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
