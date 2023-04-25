using QuanLyCaFe.DAO;
using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCaFe
{
    public partial class FAdmin : Form
    {
   

        public FAdmin()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            LoadDataHoaDon();
            LoadThemMon();
            LoadCBMaMon();
            LoadCBMaBan();
            LoadCBTenDangNhap();
        }
        public void LoadCBMaBan()
        {
            List<Ban> lm = BanDAO.Instance.loadDSBan();
            comboBoxMaBan.DataSource = lm;
            comboBoxMaBan.DisplayMember = "MaBan";
        }
        void LoadCBMaMon()
        {
            List<MonAn> lm = MonAnDAO.Instance.loadDSMon();
            comboBoxMaMon.DataSource = lm;
            comboBoxMaMon.DisplayMember = "MaMon";
        }
        void LoadCBTenDangNhap()
        {
            List<TaiKhoan> tk = TaiKhoanDAO.Instance.loadDSTaiKhoan();
            comboBoxTenDangNhap.DataSource = tk;
            comboBoxTenDangNhap.DisplayMember = "TenDangNhap";
        }
        public void LoadDataBan()
        {
            string query = "SELECT MaBan AS [Mã bàn],TenBan AS [Tên bàn],TrangThai AS [Trạng thái] FROM BAN";
            dataGridViewBan.DataSource = DataProvider.Instance.RunQuery(query, new object[] { });
        }
        public void loadDataNhanVien()
        {
            string query = "SELECT TenDangNhap AS [Tài khoản],HoTen AS [Họ tên],MatKhau AS[Mật khẩu],LoaiTaiKhoan AS[Loại tài khoản] FROM NGUOIDUNG";
            dataGridViewNhanVien.DataSource = DataProvider.Instance.RunQuery(query, new object[] { });
        }
        public void LoadDataMonAn()
        {
            string query = "SELECT MaMon AS [Mã món],TenMon AS [Tên món],Gia AS [Giá] FROM MONAN";
            dataGridViewMon.DataSource = DataProvider.Instance.RunQuery(query);
        }
        public void LoadDataHoaDon()
        {
            dataGridViewHoaDon.DataSource = HoaDonDAO.Instance.getDSHoaDonDaTT();
        }
        public void showListMon()
        {
            dataGridViewMon.DataSource = MonAnDAO.Instance.GetListMonAn();
        }
        private void LbMaMon_Click(object sender, EventArgs e)
        {

        }
        void LoadThemMon()
        {
            if (dataGridViewMon.DataSource != null)
            {
                comboBoxMaMon.DataBindings.Add(new Binding("Text", dataGridViewMon.DataSource, "Mã món"));
            }
        }
        private void TbxTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTVNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelMaMon_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPageHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void tabPageMon_Click(object sender, EventArgs e)
        {

        }

        private void tabPageBan_Click(object sender, EventArgs e)
        {

        }

        private void tabPageNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonThemMon_Click(object sender, EventArgs e)
        {
            string tenMon = textBoxTenMon.Text;
            int gia = (int)numericUpDownGia.Value;
            if (tenMon != null && gia != null &&tenMon!="")
            {
                MonAnDAO.Instance.themMonAn(tenMon, gia);
                LoadDataMonAn();
                MessageBox.Show("Thêm món thành công !", "Thông báo");
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo");
        }

        private void buttonXoaMon_Click(object sender, EventArgs e)
        {
            string maMon = comboBoxMaMon.Text;
            int gia = (int)numericUpDownGia.Value;
            if (MessageBox.Show("Xác nhận xóa món ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                MonAnDAO.Instance.XoaMon( maMon);
                LoadDataMonAn();
            }
        }

        private void buttonCapNhatMon_Click(object sender, EventArgs e)
        {
            string maMon = comboBoxMaMon.Text;
            string tenMon = textBoxTenMon.Text;
            int gia = (int)numericUpDownGia.Value;
            if (tenMon != null && gia != null && tenMon != "")
            {
                MonAnDAO.Instance.SuaMonAn(maMon,tenMon, gia);
                LoadDataMonAn();
                MessageBox.Show("Cập nhật món thành công !", "Thông báo");
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo");
        }

        private void buttonXemMon_Click(object sender, EventArgs e)
        {
            LoadDataMonAn();
        }
        void loadDataBan()
        {
            string query = "SELECT MaBan AS [Mã bàn],TenBan AS [Tên bàn],TrangThai AS [Trạng thái] FROM BAN";
            dataGridViewBan.DataSource = DataProvider.Instance.RunQuery(query);
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxMaMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTenMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTenMon_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelGia_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownGia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTrangThai_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTenBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTenBan_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxMaBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMaBan_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTimBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTimBan_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonXemBan_Click(object sender, EventArgs e)
        {
            loadDataBan();
        }

        private void buttonCapNhatBan_Click(object sender, EventArgs e)
        {
            string maBan = comboBoxMaBan.Text;
            string tenBan = textBoxTenBan.Text;
            int gia = (int)numericUpDownGia.Value;
            if (tenBan != null &&tenBan != "")
            {
                BanDAO.Instance.SuaBanAn(maBan, tenBan);
                loadDataBan();
                MessageBox.Show("Cập nhật bàn thành công !", "Thông báo");
                LoadCBMaBan();
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo");
        }

        private void buttonXoaBan_Click(object sender, EventArgs e)
        {
            string maBan = comboBoxMaBan.Text;
            int gia = (int)numericUpDownGia.Value;
            if (MessageBox.Show("Xác nhận xóa bàn ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                BanDAO.Instance.XoaBan(maBan);
                loadDataBan();
                LoadDataHoaDon();
                MessageBox.Show("Xóa bàn thành công !", "Thông báo");
            }
        }

        private void buttonThemBan_Click(object sender, EventArgs e)
        {
            string tenBan = textBoxTenBan.Text;
            string maBan  = comboBoxMaBan.Text;
            if (tenBan != null&& tenBan != "")
            {
                 BanDAO.Instance.themBan(tenBan);
                 loadDataBan();
                 MessageBox.Show("Thêm bàn thành công !", "Thông báo");
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo");
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxTrangThai_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonXemNhanVien_Click(object sender, EventArgs e)
        {
            loadDataNhanVien();
        }

        private void buttonCapNhatNhanVien_Click(object sender, EventArgs e)
        {
            string tenDangNhap = comboBoxTenDangNhap.Text;
            string hoTen = textBoxTenNhanVien.Text;
            string matKhau = textBoxMatKhau.Text;
            string loaiTaiKhoan = numericUpDownLoaiTaiKhoan.Text;
            if (hoTen != null && hoTen != ""&&(loaiTaiKhoan=="1"|| loaiTaiKhoan=="0") && matKhau != null && matKhau != "")
            {
                if (tenDangNhap == "tkadmin")
                    loaiTaiKhoan = "1";
                TaiKhoanDAO.Instance.SuaTaiKhoan(tenDangNhap,hoTen, matKhau,loaiTaiKhoan);
                loadDataNhanVien();
                LoadCBTenDangNhap();
                MessageBox.Show("Cập nhật bàn thành công !", "Thông báo");
            }
            else MessageBox.Show("Vui lòng nhập đủ,đúng thông tin !", "Thông báo");
        }

        private void buttonThemNhanVien_Click(object sender, EventArgs e)
        {
            string tenDangNhap = comboBoxTenDangNhap.Text;
            string hoTen = textBoxTenNhanVien.Text;
            string matKhau = textBoxMatKhau.Text;
            string loai = numericUpDownLoaiTaiKhoan.Text;
            int gia = (int)numericUpDownGia.Value;
            if (hoTen != null && hoTen != "" && (loai == "1" || loai == "0")&&matKhau!=null&&matKhau!="")
            {
                int i = 0;
                DataTable data = DataProvider.Instance.RunQuery("SELECT * FROM NGUOIDUNG WHERE TenDangNhap = N'" + tenDangNhap + "'");
                foreach(DataRow item in data.Rows)
                {
                    i++;
                } 
                if(i==0)
                {
                    TaiKhoanDAO.Instance.themTaiKhoan(tenDangNhap, hoTen, matKhau,loai);
                    LoadCBTenDangNhap();
                    loadDataNhanVien();
                    MessageBox.Show("Thêm nhân viên thành công !", "Thông báo");
                }
                else
                {
                     MessageBox.Show("Tên đang nhập đã tồn tại!", "Thông báo");
                }
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo");
        }

        private void buttonXoaNhanVien_Click(object sender, EventArgs e)
        {
            string tenDangNhap = comboBoxTenDangNhap.Text;
            if (tenDangNhap != "tkadmin")
            {
                if (MessageBox.Show("Xác nhận xóa nhân viên ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    TaiKhoanDAO.Instance.XoaTaiKhoan(tenDangNhap);
                    LoadCBTenDangNhap();
                    loadDataNhanVien();
                    MessageBox.Show("Xóa nhân viên thành công !", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa tài khoản admin !", "Thông báo");
            }    
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bXemTK_Click(object sender, EventArgs e)
        {
            FTKHoaDon ftk = new FTKHoaDon(comboBoxTenDangNhap.Text);
            this.Hide();
            ftk.ShowDialog();
            this.Show();
        }
    }
}
