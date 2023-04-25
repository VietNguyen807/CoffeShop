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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }
        private void BtDangNhap_Click(object sender, EventArgs e)
        {
            string tk = TbxTenDangNhap.Text;
            string mk = TbxMatKhau.Text;
            if (ktrDangNhap(tk,mk) == true)
            {
                TaiKhoan taiKhoan = TaiKhoanDAO.Instance.getTaiKhoan(tk); 
                FPhanMem pm = new FPhanMem(taiKhoan);
                this.Hide();
                pm.ShowDialog();
                this.Show();
            }else
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không chính xác !","Thông báo");
            }    
        }
        bool ktrDangNhap(string tk,string mk)
        {
            return TaiKhoanDAO.Instance.ktrDangNhap(tk, mk);
        }
        private void BtThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
