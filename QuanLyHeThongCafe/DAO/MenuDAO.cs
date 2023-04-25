using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCaFe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance =new  MenuDAO();return instance; }
            private set { instance = value; }
        }
        private MenuDAO() { }
        public List<QuanLyCaFe.DTO.Menu> GetListMenu(int id)
        {
            string query = "SELECT TenMon AS[Tên món], SoLuong AS[Số lượng], Gia AS[Đơn giá],SoLuong*Gia AS[Thành tiền] FROM MONAN,HOADON,CT_HOADON,BAN WHERE HOADON.MaHD = CT_HOADON.MaHD AND BAN.MaBan= HOADON.MaBan AND CT_HOADON.MaMon = MONAN.MaMon AND BAN.TrangThai = 1 AND HOADON.MaHD = "+id;
            List<QuanLyCaFe.DTO.Menu> l= new List<QuanLyCaFe.DTO.Menu>();
            DataTable data = DataProvider.Instance.RunQuery(query);
            foreach(DataRow item in data.Rows)
            {
                QuanLyCaFe.DTO.Menu m = new QuanLyCaFe.DTO.Menu(item);
                l.Add(m);
            }    
            return l;
        }
        public List<QuanLyCaFe.DTO.Menu> GetListMenuTheoMaHDVaTenDangNhap(int maHD,string tk)
        {
            string query = "SELECT TenMon AS[Tên món], SoLuong AS[Số lượng], Gia AS[Đơn giá],SoLuong*Gia AS[Thành tiền] FROM MONAN,HOADON,CT_HOADON WHERE HOADON.MaHD = CT_HOADON.MaHD AND CT_HOADON.MaMon = MONAN.MaMon AND HOADON.TrangThai=1 AND HOADON.MaHD = " + maHD+" AND HOADON.TenDangNhap=N'"+tk+"'";
            List<QuanLyCaFe.DTO.Menu> l = new List<QuanLyCaFe.DTO.Menu>();
            DataTable data = DataProvider.Instance.RunQuery(query);
            foreach (DataRow item in data.Rows)
            {
                QuanLyCaFe.DTO.Menu m = new QuanLyCaFe.DTO.Menu(item);
                l.Add(m);
            }
            return l;
        }
        public List<QuanLyCaFe.DTO.Menu> GetListHoaDonDaTT(int maBan,int maHD)
        {
            string query = "SELECT TenMon AS[Tên món], SoLuong AS[Số lượng], Gia AS[Đơn giá],SoLuong*Gia AS[Thành tiền] FROM MONAN,HOADON,CT_HOADON,BAN WHERE HOADON.MaHD = CT_HOADON.MaHD AND BAN.MaBan= HOADON.MaBan AND CT_HOADON.MaMon = MONAN.MaMon  AND HOADON.MaHD = " + maHD+" AND BAN.MaBan = "+maBan;
            List<QuanLyCaFe.DTO.Menu> l = new List<QuanLyCaFe.DTO.Menu>();
            DataTable data = DataProvider.Instance.RunQuery(query);
            foreach (DataRow item in data.Rows)
            {
                QuanLyCaFe.DTO.Menu m = new QuanLyCaFe.DTO.Menu(item);
                l.Add(m);
            }
            return l;
        }
    }
}
