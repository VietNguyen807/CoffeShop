
namespace QuanLyCaFe
{
    partial class FPhanMem
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtThemMon = new System.Windows.Forms.Button();
            this.NudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxTenMon = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.listViewHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtThanhToan = new System.Windows.Forms.Button();
            this.flowLayoutPanelBan = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSoLuong)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtThemMon);
            this.panel3.Controls.Add(this.NudSoLuong);
            this.panel3.Controls.Add(this.ComboBoxTenMon);
            this.panel3.Location = new System.Drawing.Point(17, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 72);
            this.panel3.TabIndex = 2;
            // 
            // BtThemMon
            // 
            this.BtThemMon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtThemMon.Location = new System.Drawing.Point(278, 19);
            this.BtThemMon.Name = "BtThemMon";
            this.BtThemMon.Size = new System.Drawing.Size(130, 40);
            this.BtThemMon.TabIndex = 2;
            this.BtThemMon.Text = "Thêm món";
            this.BtThemMon.UseVisualStyleBackColor = true;
            this.BtThemMon.Click += new System.EventHandler(this.BtThemMon_Click);
            // 
            // NudSoLuong
            // 
            this.NudSoLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudSoLuong.Location = new System.Drawing.Point(192, 24);
            this.NudSoLuong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NudSoLuong.Name = "NudSoLuong";
            this.NudSoLuong.Size = new System.Drawing.Size(80, 30);
            this.NudSoLuong.TabIndex = 1;
            this.NudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ComboBoxTenMon
            // 
            this.ComboBoxTenMon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTenMon.FormattingEnabled = true;
            this.ComboBoxTenMon.Location = new System.Drawing.Point(3, 24);
            this.ComboBoxTenMon.Name = "ComboBoxTenMon";
            this.ComboBoxTenMon.Size = new System.Drawing.Size(183, 32);
            this.ComboBoxTenMon.TabIndex = 0;
            this.ComboBoxTenMon.Text = "Tên món";
            this.ComboBoxTenMon.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTenMon_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxTongTien);
            this.panel4.Controls.Add(this.labelTongTien);
            this.panel4.Controls.Add(this.listViewHoaDon);
            this.panel4.Controls.Add(this.BtThanhToan);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(631, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(461, 660);
            this.panel4.TabIndex = 3;
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongTien.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBoxTongTien.Location = new System.Drawing.Point(178, 571);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.ReadOnly = true;
            this.textBoxTongTien.Size = new System.Drawing.Size(261, 34);
            this.textBoxTongTien.TabIndex = 5;
            this.textBoxTongTien.Text = "0  VNĐ";
            this.textBoxTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.Location = new System.Drawing.Point(12, 574);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(130, 29);
            this.labelTongTien.TabIndex = 4;
            this.labelTongTien.Text = "Tổng tiền:";
            // 
            // listViewHoaDon
            // 
            this.listViewHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewHoaDon.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewHoaDon.GridLines = true;
            this.listViewHoaDon.HideSelection = false;
            this.listViewHoaDon.Location = new System.Drawing.Point(3, 103);
            this.listViewHoaDon.Name = "listViewHoaDon";
            this.listViewHoaDon.Size = new System.Drawing.Size(458, 460);
            this.listViewHoaDon.TabIndex = 3;
            this.listViewHoaDon.UseCompatibleStateImageBehavior = false;
            this.listViewHoaDon.View = System.Windows.Forms.View.Details;
            this.listViewHoaDon.SelectedIndexChanged += new System.EventHandler(this.listViewHoaDon_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 80;
            // 
            // BtThanhToan
            // 
            this.BtThanhToan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtThanhToan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtThanhToan.Location = new System.Drawing.Point(3, 611);
            this.BtThanhToan.Name = "BtThanhToan";
            this.BtThanhToan.Size = new System.Drawing.Size(455, 46);
            this.BtThanhToan.TabIndex = 0;
            this.BtThanhToan.Text = "Thanh toán";
            this.BtThanhToan.UseVisualStyleBackColor = true;
            this.BtThanhToan.Click += new System.EventHandler(this.BtThanhToan_Click);
            // 
            // flowLayoutPanelBan
            // 
            this.flowLayoutPanelBan.AutoScroll = true;
            this.flowLayoutPanelBan.Location = new System.Drawing.Point(11, 31);
            this.flowLayoutPanelBan.Name = "flowLayoutPanelBan";
            this.flowLayoutPanelBan.Size = new System.Drawing.Size(610, 659);
            this.flowLayoutPanelBan.TabIndex = 4;
            // 
            // FPhanMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 703);
            this.Controls.Add(this.flowLayoutPanelBan);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FPhanMem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudSoLuong)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtThemMon;
        private System.Windows.Forms.NumericUpDown NudSoLuong;
        private System.Windows.Forms.ComboBox ComboBoxTenMon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtThanhToan;
        private System.Windows.Forms.ListView listViewHoaDon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label labelTongTien;
    }
}