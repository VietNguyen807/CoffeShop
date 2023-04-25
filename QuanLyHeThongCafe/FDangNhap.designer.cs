
namespace QuanLyCaFe
{
    partial class FDangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtThoat = new System.Windows.Forms.Button();
            this.BtDangNhap = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TbxMatKhau = new System.Windows.Forms.TextBox();
            this.LbMatKhau = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TbxTenDangNhap = new System.Windows.Forms.TextBox();
            this.LbTenDangNhap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtThoat);
            this.panel1.Controls.Add(this.BtDangNhap);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 263);
            this.panel1.TabIndex = 0;
            // 
            // BtThoat
            // 
            this.BtThoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtThoat.Location = new System.Drawing.Point(493, 196);
            this.BtThoat.Name = "BtThoat";
            this.BtThoat.Size = new System.Drawing.Size(173, 40);
            this.BtThoat.TabIndex = 4;
            this.BtThoat.Text = "Thoát";
            this.BtThoat.UseVisualStyleBackColor = true;
            this.BtThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // BtDangNhap
            // 
            this.BtDangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDangNhap.Location = new System.Drawing.Point(303, 196);
            this.BtDangNhap.Name = "BtDangNhap";
            this.BtDangNhap.Size = new System.Drawing.Size(173, 40);
            this.BtDangNhap.TabIndex = 3;
            this.BtDangNhap.Text = "Đăng nhập";
            this.BtDangNhap.UseVisualStyleBackColor = true;
            this.BtDangNhap.Click += new System.EventHandler(this.BtDangNhap_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TbxMatKhau);
            this.panel3.Controls.Add(this.LbMatKhau);
            this.panel3.Location = new System.Drawing.Point(81, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 63);
            this.panel3.TabIndex = 2;
            // 
            // TbxMatKhau
            // 
            this.TbxMatKhau.Location = new System.Drawing.Point(222, 25);
            this.TbxMatKhau.Name = "TbxMatKhau";
            this.TbxMatKhau.Size = new System.Drawing.Size(313, 22);
            this.TbxMatKhau.TabIndex = 1;
            this.TbxMatKhau.UseSystemPasswordChar = true;
            // 
            // LbMatKhau
            // 
            this.LbMatKhau.AutoSize = true;
            this.LbMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMatKhau.Location = new System.Drawing.Point(33, 23);
            this.LbMatKhau.Name = "LbMatKhau";
            this.LbMatKhau.Size = new System.Drawing.Size(109, 28);
            this.LbMatKhau.TabIndex = 0;
            this.LbMatKhau.Text = "Mật khẩu :";
            this.LbMatKhau.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TbxTenDangNhap);
            this.panel2.Controls.Add(this.LbTenDangNhap);
            this.panel2.Location = new System.Drawing.Point(81, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 63);
            this.panel2.TabIndex = 1;
            // 
            // TbxTenDangNhap
            // 
            this.TbxTenDangNhap.Location = new System.Drawing.Point(222, 25);
            this.TbxTenDangNhap.Name = "TbxTenDangNhap";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // FDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 273);
            this.Controls.Add(this.panel1);
            this.Name = "FDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FDangNhap_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtThoat;
        private System.Windows.Forms.Button BtDangNhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TbxMatKhau;
        private System.Windows.Forms.Label LbMatKhau;
        private System.Windows.Forms.TextBox TbxTenDangNhap;
    }
}

