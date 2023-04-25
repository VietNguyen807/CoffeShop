using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyCaFe.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }
        private TaiKhoanDAO()
        {
        }
        public bool ktrDangNhap(string tk, string mk)
        {
            string query= "SELECT *FROM dbo.NGUOIDUNG WHERE TenDangNhap = N'"+tk+ "' AND MatKhau = N'"+mk+"'";
            DataTable data = DataProvider.Instance.RunQuery(query);
            return data.Rows.Count>0;
        }
        public TaiKhoan getTaiKhoan(string tenDangNhap)
        {
            string query = "SELECT *FROM dbo.NGUOIDUNG WHERE TenDangNhap = N'"+ tenDangNhap+"'";
            DataTable data = DataProvider.Instance.RunQuery(query);
            foreach(DataRow item in data.Rows)
            {
                return new TaiKhoan(item);
            }    
            return null;
        }
        public bool SuaTaiKhoan(string tenDangNhap,string hoTen,string matKhau,string loai)
        {
            string q = "UPDATE dbo.NGUOIDUNG SET HoTen =N'" + hoTen + "',MatKhau=N'"+matKhau+"' ,LoaiTaiKhoan = " + loai + " WHERE TenDangNhap = N'" + tenDangNhap + "'";
            int kq = DataProvider.Instance.RunNonQuery(q);
            return kq > 0;
        }
        public List<TaiKhoan> loadDSTaiKhoan()
        {
            List<TaiKhoan> dsTK = new List<TaiKhoan>();
            DataTable data = DataProvider.Instance.RunQuery("SELECT * FROM NGUOIDUNG");
            foreach (DataRow item in data.Rows)
            {
                TaiKhoan b = new TaiKhoan(item);
                dsTK.Add(b);
            }
            return dsTK;
        }
        public bool themTaiKhoan(string tenDangNhap,string hoTen,string matKhau,string loai)
        {
            string q = "INSERT dbo.NGUOIDUNG(TenDangNhap,HoTen,MatKhau,LoaiTaiKhoan) VALUES(N'"+tenDangNhap+"',N'" + hoTen + "',N'"+matKhau+"'," + loai + ")";
            int kq = DataProvider.Instance.RunNonQuery(q);
            return kq > 0;
        }
        public bool XoaTaiKhoan(string tenDangNhap)
        {
            string q = "DELETE FROM NGUOIDUNG WHERE TenDangNhap= N'" + tenDangNhap+"'";
            int kq = DataProvider.Instance.RunNonQuery(q);
            return kq > 0;
        }
    }
}
