using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyCaFe.DAO
{
    public class MonAnDAO
    {
        private static MonAnDAO instance;
        public static MonAnDAO Instance
        {
            get
            {
                if (instance == null) MonAnDAO.instance = new MonAnDAO();
                return MonAnDAO.instance;
            }
            private set
            {
                MonAnDAO.instance = value;
            }
        }
        public List<MonAn> loadDSMon()
        {
            List<MonAn> dsMon = new List<MonAn>();
            DataTable data = DataProvider.Instance.RunQuery("SELECT * FROM MONAN");
            foreach (DataRow item in data.Rows)
            {
                MonAn b = new MonAn(item);
                dsMon.Add(b);
            }
            return dsMon;
        }
        public List<QuanLyCaFe.DTO.MonAn> GetListMonAn()
        {
            string query = "SELECT *FROM  MONAN";
            List<QuanLyCaFe.DTO.MonAn> l = new List<QuanLyCaFe.DTO.MonAn>();
            DataTable data = DataProvider.Instance.RunQuery(query);
            foreach (DataRow item in data.Rows)
            {
                QuanLyCaFe.DTO.MonAn m = new QuanLyCaFe.DTO.MonAn(item);
                l.Add(m);
            }
            return l;
        }
        public bool themMonAn(string tenMon, int gia)
        {
            string q = "INSERT dbo.MONAN(TenMon,Gia) VALUES(N'" + tenMon + "'," + gia + ")";
            int kq = DataProvider.Instance.RunNonQuery(q);
            return kq>0;
        }
        public bool SuaMonAn(string maMon,string tenMon, int gia)
        {
            string q = "UPDATE dbo.MONAN SET TenMon =N'"+tenMon+"' ,Gia = "+gia+" WHERE MaMon = "+maMon;
            int kq = DataProvider.Instance.RunNonQuery(q);
            return kq > 0;
        }
        public bool XoaMon(string maMon)
        {
            string q = "DELETE FROM CT_HOADON WHERE MaMon= N'" + maMon+"'";
            int kq = DataProvider.Instance.RunNonQuery(q);
            q = "DELETE FROM MONAN WHERE MaMon= N'" + maMon+"'";
            kq = DataProvider.Instance.RunNonQuery(q);
            return kq > 0;
        }
    }
}
