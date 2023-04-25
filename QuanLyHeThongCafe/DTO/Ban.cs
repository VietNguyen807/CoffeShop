using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyCaFe.DTO
{
    public class Ban
    {
        private string tenBan;
        private int maBan;
        private string trangThai;

        public string TenBan { get => tenBan; set => tenBan = value; }
        public int MaBan { get => maBan; set => maBan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public Ban(int maBan,String tenBan, string trangThai)
        {
            this.maBan = maBan;
            this.tenBan = tenBan;
            this.trangThai = trangThai;
        }
        public int getMaBan()
        {
            return maBan;
        }
        public Ban(DataRow d)
        {
            this.maBan = (int)d["MaBan"];
            this.tenBan = d["TenBan"].ToString();
            string t= d["TrangThai"].ToString();
            if (t.Equals("0"))
                this.TrangThai = "Trống";
                else
                this.TrangThai = "Đang dùng";
        }    
    }
}
