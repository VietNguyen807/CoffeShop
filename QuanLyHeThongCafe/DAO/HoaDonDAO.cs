using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCaFe.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get{
                if (HoaDonDAO.instance == null)
                    HoaDonDAO.instance =new HoaDonDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public HoaDonDAO() { }
        public int getMaHoaDonTuMaBan(int maBan)
        {
            DataTable data = DataProvider.Instance.RunQuery("SELECT  * FROM dbo.HOADON WHERE HOADON.MaBan = "+maBan+" AND HOADON.TrangThai = 0");
            if (data.Rows.Count > 0)
            {
                HoaDon hd = new HoaDon(data.Rows[0]);
                return hd.MaHoaDon;
            }    
            return -1;
        }
        public void chenHoaDon(int maBan,string tenDangNhap)
        {
            DataProvider.Instance.RunNonQuery("EXEC dbo.chenHoaDon @maBan="+maBan+",@tenDangNhap =N'"+tenDangNhap+"'");
        }
        public int getMaxMaHoaDon()
        {
            try
            {
                return (int)DataProvider.Instance.RunScalary("SELECT MAX(MaHD)FROM dbo.HOADON");
            }
            catch
            {
                return 1;
            }
        }
        public void checkOut(int maHoaDon)
        {
            string q = "UPDATE dbo.HOADON SET TrangThai = 1 WHERE MaHD = " + maHoaDon;
            DataProvider.Instance.RunNonQuery(q);
        }
        public DataTable getDSHoaDonDaTT()
        {
            DataTable data = DataProvider.Instance.RunQuery("SELECT MaHD AS[Mã hóa đơn], MaBan AS [Mã bàn],TrangThai AS [Trạng thái] FROM dbo.HOADON WHERE TrangThai=1");
            
            data.Columns.Add("Tổng tiền");
            foreach (DataRow item in data.Rows)
            {
                
                int tong = 0;
                List<QuanLyCaFe.DTO.Menu> l = MenuDAO.Instance.GetListHoaDonDaTT((int)item["Mã bàn"],(int)item["Mã hóa đơn"]);
                foreach (QuanLyCaFe.DTO.Menu item2 in l)
                {
                    ListViewItem lv = new ListViewItem(item2.TenMon1.ToString());
                    lv.SubItems.Add(item2.SoLuong.ToString());
                    lv.SubItems.Add(item2.DonGia.ToString());
                    lv.SubItems.Add(item2.ThanhTien.ToString());
                    tong += item2.ThanhTien;
                }
                item["Tổng tiền"] = tong.ToString()+"  VNĐ";
            }
            return data;
        }
        public DataTable getDSHDTheoTK(string tk)
        {
            DataTable data = DataProvider.Instance.RunQuery("SELECT MaHD AS[Mã hóa đơn],TenDangNhap AS [Tài khoản], MaBan AS [Mã bàn],TrangThai AS [Trạng thái] FROM dbo.HOADON WHERE TrangThai=1 AND TenDangNhap=N'"+tk+"'");

            data.Columns.Add("Tổng tiền");
            foreach (DataRow item in data.Rows)
            {

                int tong = 0;
                List<QuanLyCaFe.DTO.Menu> l = MenuDAO.Instance.GetListHoaDonDaTT((int)item["Mã bàn"], (int)item["Mã hóa đơn"]);
                foreach (QuanLyCaFe.DTO.Menu item2 in l)
                {
                    ListViewItem lv = new ListViewItem(item2.TenMon1.ToString());
                    lv.SubItems.Add(item2.SoLuong.ToString());
                    lv.SubItems.Add(item2.DonGia.ToString());
                    lv.SubItems.Add(item2.ThanhTien.ToString());
                    tong += item2.ThanhTien;
                }
                item["Tổng tiền"] = tong.ToString() + "  VNĐ";
            }
            return data;
        }
    }
}
