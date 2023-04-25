using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyCaFe.DAO
{
    public class CT_HoaDonDAO
    {
        private static CT_HoaDonDAO instance;

        public static CT_HoaDonDAO Instance
        {
            get
            {
                if (CT_HoaDonDAO.instance == null)
                    CT_HoaDonDAO.instance = new CT_HoaDonDAO();
                return instance;
            }
            private set 
            {
                instance = value;
            }
        }
        public CT_HoaDonDAO() { }
        public List<CT_HoaDon> getDSCT_HD(int id)
        {
            List<CT_HoaDon> l = new List<CT_HoaDon>();
            DataTable data = DataProvider.Instance.RunQuery("SELECT  *FROM dbo.CT_HOADONWHERE dbo.CT_HOADON.MaHD = "+id);
            foreach (DataRow item in data.Rows)
            {
                CT_HoaDon ct = new CT_HoaDon(item);
                l.Add(ct);
            }    
            return l;
        }
        public void chenCT_HoaDon(int maHoaDon,int maMonAn,int soLuong)
        {
            DataProvider.Instance.RunNonQuery("EXEC chenCT_HoaDon @maHoaDon = "+maHoaDon+" , @maMon = "+maMonAn+" , @soLuong = " +soLuong);
        }
    }
}
