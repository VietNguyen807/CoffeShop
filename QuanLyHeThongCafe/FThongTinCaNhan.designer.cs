
namespace QuanLyCaFe
{
    partial class FThongTinCaNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.TbxTenDangNhap = new System.Windows.Forms.TextBox();
            this.LbTenDangNhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbxHoTen = new System.Windows.Forms.TextBox();
            this.LbHoTen = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TbxMatKhau = new System.Windows.Forms.TextBox();
            this.LbMatKhau = new System.Windows.Forms.Label();
            this.BtThoat = new System.Windows.Forms.Button();
            this.btThongKe = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TbxTenDangNhap);
            this.panel2.Controls.Add(this.LbTenDangNhap);
            this.panel2.Location = new System.Drawing.Point(94, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 63);
            this.panel2.TabIndex = 2;
            // 
            // TbxTenDangNhap
            // 
            this.TbxTenDangNhap.Location = new System.Drawing.Point(222, 25);
            this.TbxTenDangNhap.Name = "TbxTenDangNhap";
            this.TbxTenDangNhap.ReadOnly = true;
            this.TbxTenDangNhap.Size = new System.Drawing.Size(313, 22);
            this.TbxTenDangNhap.TabIndex = 1;
            // 
            // LbTenDangNhap
            // 
            this.LbTenDangNhap.AutoSize = true;
            this.LbTenDangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTenDangNhap.Location = new System.Drawing.Point(33, 23);
            this.LbTenDangNhap.Name = "LbTenDangNhap";
            this.LbTenDangNhap.Size = new System.Drawing.Size(165, 24);
            this.LbTenDangNhap.TabIndex = 0;
            this.LbTenDangNhap.Text = "Tên đăng nhập :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TbxHoTen);
            this.panel1.Controls.Add(this.LbHoTen);
            this.panel1.Location = new System.Drawing.Point(94, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 63);
            this.panel1.TabIndex = 2;
            // 
            // TbxHoTen
            // 
            this.TbxHoTen.Location = new System.Drawing.Point(222, 25);
            this.TbxHoTen.Name = "TbxHoTen";
            this.TbxHoTen.Size = new System.Drawing.Size(313, 22);
            this.TbxHoTen.TabIndex = 1;
            // 
            // LbHoTen
            // 
            this.LbHoTen.AutoSize = true;
            this.LbHoTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHoTen.Location = new System.Drawing.Point(33, 23);
            this.LbHoTen.Name = "LbHoTen";
            this.LbHoTen.Size = new System.Drawing.Size(85, 24);
            this.LbHoTen.TabIndex = 0;
            this.LbHoTen.Text = "Họ tên :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TbxMatKhau);
            this.panel3.Controls.Add(this.LbMatKhau);
            this.panel3.Location = new System.Drawing.Point(94, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 63);
            this.panel3.TabIndex = 3;
            // 
            // TbxMatKhau
            // 
            this.TbxMatKhau.Location = new System.Drawing.Point(222, 25);
            this.TbxMatKhau.Name = "TbxMatKhau";
            this.TbxMatKhau.Size = new System.Drawing.Size(313, 22);
            this.TbxMatKhau.TabIndex = 1;
            // 
            // LbMatKhau
            // 
            this.LbMatKhau.AutoSize = true;
            this.LbMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMatKhau.Location = new System.Drawing.Point(33, 23);
            this.LbMatKhau.Name = "LbMatKhau";
            this.LbMatKhau.Size = new System.Drawing.Size(110, 24);
            this.LbMatKhau.TabIndex = 0;
            this.LbMatKhau.Text = "Mật khẩu :";
            // 
            // BtThoat
            // 
            this.BtThoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtThoat.Location = new System.Drawing.Point(545, 264);
            this.BtThoat.Name = "BtThoat";
            this.BtThoat.Size = new System.Drawing.Size(134, 38);
            this.BtThoat.TabIndex = 4;
            this.BtThoat.Text = "Thoát";
            this.BtThoat.UseVisualStyleBackColor = true;
            this.BtThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // btThongKe
            // 
            this.btThongKe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.Location = new System.Drawing.Point(94, 264);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(143, 38);
            this.btThongKe.TabIndex = 5;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // FThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThongKe);
            this.Controls.Add(this.BtThoat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FThongTinCaNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.FThongTinCaNhan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TbxTenDangNhap;
        private System.Windows.Forms.Label LbTenDangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbxHoTen;
        private System.Windows.Forms.Label LbHoTen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TbxMatKhau;
        private System.Windows.Forms.Label LbMatKhau;
        private System.Windows.Forms.Button BtThoat;
        private System.Windows.Forms.Button btThongKe;
    }
}