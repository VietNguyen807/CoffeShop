using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyCaFe.DAO
{
    public class BanDAO
    {
        private static BanDAO instance;
        public static int rong = 100;
        public static int cao = 100;
        public static BanDAO Instance
        {
            get
            {
                if (instance == null) BanDAO.instance = new BanDAO();
                return BanDAO.instance;
            }
            private set
            {
                BanDAO.instance = value;
            }
        }
        public List<Ban> loadDSBan()
        {
            List <Ban> dsBan= new List<Ban>();
            DataTable data = DataProvider.Instance.RunQuery("layDanhSachBan");
            foreach(DataRow item in data.Rows)
            {
                Ban b = new Ban(item);
                dsBan.Add(b);
            }    
            return dsBan;
        }
        public bool SuaBanAn(string maBan, string tenBan)
        {
            string q = "UPDATE dbo.BAN SET TenBan =N'" + tenBan + "' WHERE MaBan = " + maBan;
            int kq = DataProvider.Instance.RunNonQuery(q);
            return kq > 0;
        }
        public bool XoaBan(string maBan)
        {
            string q = "SELECT* FROM HOADON WHERE MaBan= " + maBan ;
            DataTable data = DataProvider.Instance.RunQuery(q);
            int kq = 0;
            foreach(DataRow item in data.Rows)
            {
                HoaDon hd = new HoaDon(item);
                q = "DELETE FROM CT_HOADON WHERE MaHD= " + hd.MaHoaDon;
                kq = DataProvider.Instance.RunNonQuery(q);
            }    
            q = "DELETE FROM HOADON WHERE MaBan= " + maBan ;
            kq = DataProvider.Instance.RunNonQuery(q);
            q = "DELETE FROM BAN WHERE MaBan= " + maBan;
            kq = DataProvider.Instance.RunNonQuery(q);
            return kq > 0;
        }
        public bool themBan(string tenBan)
        {
            
            string q = "INSERT dbo.BAN(TenBan) VALUES(N'" + tenBan +"')";
            int kq = DataProvider.Instance.RunNonQuery(q);
            return kq > 0;
        }
    }
}
