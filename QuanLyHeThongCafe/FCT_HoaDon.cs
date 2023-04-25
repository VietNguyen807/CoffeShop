using QuanLyCaFe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCaFe
{
    public partial class FCT_HoaDon : Form
    {
        public FCT_HoaDon()
        {
            InitializeComponent();
        }
        public FCT_HoaDon(int maHD,string tk)
        {
            InitializeComponent();
            showHoaDon(maHD,tk);
        }

        private void listViewHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void showHoaDon(int maHD,string tk)
        {
            lvCTHD.Items.Clear();
            int tong = 0;
            List<QuanLyCaFe.DTO.Menu> l = MenuDAO.Instance.GetListMenuTheoMaHDVaTenDangNhap(maHD,tk);
            foreach (QuanLyCaFe.DTO.Menu item in l)
            {
                ListViewItem lv = new ListViewItem(item.TenMon1.ToString());
                lv.SubItems.Add(item.SoLuong.ToString());
                lv.SubItems.Add(item.DonGia.ToString());
                lv.SubItems.Add(item.ThanhTien.ToString());
                lvCTHD.Items.Add(lv);
                tong += item.ThanhTien;
            }
            lvCTHD.Show();
        }
    }
}
