using QuanLyCaFe.DAO;
using QuanLyCaFe.DTO;
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
    public partial class FPhanMem : Form
    {
        private TaiKhoan taiKhoan;

        public TaiKhoan TaiKhoan 
        { 
            get => taiKhoan; 
            set
            {
                taiKhoan = value;
                ChangeTaiKhoan(taiKhoan.LoaiTaiKhoan);
            }
        }
        public FPhanMem(TaiKhoan tk)
        {
            InitializeComponent();
            this.TaiKhoan = tk;
            loadBan();
            loadMon();
            xuatHoaDon();
        }
        public FPhanMem()
        {
            InitializeComponent();
            loadBan();
            loadMon();
            xuatHoaDon();
        }
        private void xuatHoaDon()
        {
            
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAdmin ad = new FAdmin();
            this.Hide();
            ad.ShowDialog();
            this.Show();
            loadMon();
            loadBan();
        }
        void loadMon()
        {
            List<MonAn> lm = MonAnDAO.Instance.loadDSMon();
            ComboBoxTenMon.DataSource = lm;
            ComboBoxTenMon.DisplayMember = "TenMon";
        }
        private void loadBan()
        {
            flowLayoutPanelBan.Controls.Clear();
            List<Ban> dsBan = BanDAO.Instance.loadDSBan();
            foreach (Ban item in dsBan)
            {
                Button bt = new Button() {Width= BanDAO.rong,Height=BanDAO.cao};
                bt.Text = item.TenBan+"\n"+item.TrangThai;
                bt.Click += bt_Click;
                bt.Tag = item;
                if (item.TrangThai == "Trống")
                    bt.BackColor = Color.Aqua;
                else bt.BackColor = Color.Gold;
                flowLayoutPanelBan.Controls.Add(bt);
            }
            
        }
        void showHoaDon(int maBan)
        {
             listViewHoaDon.Items.Clear();
             int tong = 0;
             List<QuanLyCaFe.DTO.Menu> l = MenuDAO.Instance.GetListMenu(HoaDonDAO.Instance.getMaHoaDonTuMaBan(maBan));
             foreach (QuanLyCaFe.DTO.Menu item  in l)
             {
                ListViewItem lv = new ListViewItem(item.TenMon1.ToString());
                lv.SubItems.Add(item.SoLuong.ToString());
                lv.SubItems.Add(item.DonGia.ToString());
                lv.SubItems.Add(item.ThanhTien.ToString());
                listViewHoaDon.Items.Add(lv);
                tong += item.ThanhTien;
             }
             textBoxTongTien.Text = tong.ToString()+"  VNĐ";
            
        }
        void ChangeTaiKhoan(int loaiTaiKhoan)
        {
            adminToolStripMenuItem.Enabled = loaiTaiKhoan==1;
        }
        public void bt_Click(object sender, EventArgs e)
        {
            int maBan=((sender as Button).Tag as Ban).MaBan;
            listViewHoaDon.Tag = (sender as Button).Tag;
            showHoaDon(maBan);
        }
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FThongTinCaNhan tt = new FThongTinCaNhan(taiKhoan);
            this.Hide();
            tt.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }
        private void BtThemMon_Click(object sender, EventArgs e)
        {
            Ban b = listViewHoaDon.Tag as Ban;
            int maBan = b.getMaBan();
            int maHoaDon = HoaDonDAO.Instance.getMaHoaDonTuMaBan(maBan);
            int maMon = (ComboBoxTenMon.SelectedItem as MonAn).MaMon;
            int soLuong = (int)NudSoLuong.Value;
            if (maHoaDon==-1)
            {
                HoaDonDAO.Instance.chenHoaDon(b.MaBan,taiKhoan.TenDangNhap);
                CT_HoaDonDAO.Instance.chenCT_HoaDon(HoaDonDAO.Instance.getMaxMaHoaDon(), maMon, soLuong);
            } 
            else
            {
                CT_HoaDonDAO.Instance.chenCT_HoaDon(maHoaDon, maMon, soLuong);
            }
            showHoaDon(b.getMaBan());
            loadBan();
        }

        private void BtThanhToan_Click(object sender, EventArgs e)
        {
            Ban b = listViewHoaDon.Tag as Ban;
            int maHoaDon = HoaDonDAO.Instance.getMaHoaDonTuMaBan(b.getMaBan());
            if(maHoaDon==-1)
            {

            }
            else
            {
                if (MessageBox.Show("Xác nhận thanh toán " + b.TenBan + " ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    HoaDonDAO.Instance.checkOut(maHoaDon);
                }    
            }
            showHoaDon(b.getMaBan());
            loadBan();
        }
    }
}
