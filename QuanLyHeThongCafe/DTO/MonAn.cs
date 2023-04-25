using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyCaFe.DTO
{
    public class MonAn
    {
        private string tenMon;
        private int maMon;
        private int gia;

        public string TenMon { get => tenMon; set => tenMon = value; }
        public int MaMon { get => maMon; set => maMon = value; }
        public int Gia { get => gia; set => gia = value; }

        public MonAn(string tenMon, int maMon, int gia)
        {
            this.maMon = maMon;
            this.tenMon = tenMon;
            this.gia = gia;
        }
        public MonAn(DataRow d)
        {
            this.maMon = (int)d["MaMon"];
            this.tenMon = d["TenMon"].ToString();
            this.gia = (int)d["Gia"];
        }
    }
}
