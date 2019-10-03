namespace WindowsFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChiNhanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiNhaChoTHue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaChoThue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatLichXemNha = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHopDong = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThôgnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLicXemNha = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuNhaChoThue,
            this.mnuDatLichXemNha,
            this.mnuHopDong,
            this.toolStripMenuItem1,
            this.hệThôgnsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChiNhanh,
            this.mnuLoaiNhaChoTHue,
            this.toolStripSeparator1,
            this.mnuNhanVien,
            this.mnuKhachHang});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuChiNhanh
            // 
            this.mnuChiNhanh.Name = "mnuChiNhanh";
            this.mnuChiNhanh.Size = new System.Drawing.Size(169, 22);
            this.mnuChiNhanh.Text = "Chi nhánh";
            this.mnuChiNhanh.Click += new System.EventHandler(this.mnuChiNhanh_Click);
            // 
            // mnuLoaiNhaChoTHue
            // 
            this.mnuLoaiNhaChoTHue.Name = "mnuLoaiNhaChoTHue";
            this.mnuLoaiNhaChoTHue.Size = new System.Drawing.Size(169, 22);
            this.mnuLoaiNhaChoTHue.Text = "Loại nhà cho thuê";
            this.mnuLoaiNhaChoTHue.Click += new System.EventHandler(this.mnuLoaiNhaChoTHue_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(169, 22);
            this.mnuNhanVien.Text = "Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(169, 22);
            this.mnuKhachHang.Text = "Khách hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKHThue_Click);
            // 
            // mnuNhaChoThue
            // 
            this.mnuNhaChoThue.Name = "mnuNhaChoThue";
            this.mnuNhaChoThue.Size = new System.Drawing.Size(147, 20);
            this.mnuNhaChoThue.Text = "Danh sách nhà cho thuê";
            this.mnuNhaChoThue.Click += new System.EventHandler(this.mnuNhaChoThue_Click_1);
            // 
            // mnuDatLichXemNha
            // 
            this.mnuDatLichXemNha.Name = "mnuDatLichXemNha";
            this.mnuDatLichXemNha.Size = new System.Drawing.Size(107, 20);
            this.mnuDatLichXemNha.Text = "Đặt lịch xem nhà";
            this.mnuDatLichXemNha.Click += new System.EventHandler(this.mnuDatLichXemNha_Click);
            // 
            // mnuHopDong
            // 
            this.mnuHopDong.Name = "mnuHopDong";
            this.mnuHopDong.Size = new System.Drawing.Size(123, 20);
            this.mnuHopDong.Text = "Hợp đồng thuê nhà";
            this.mnuHopDong.Click += new System.EventHandler(this.mnuHopDong_Click);
            // 
            // hệThôgnsToolStripMenuItem
            // 
            this.hệThôgnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDN,
            this.mnuDX,
            this.mnuDoiMatKhau,
            this.mnuThoat});
            this.hệThôgnsToolStripMenuItem.Name = "hệThôgnsToolStripMenuItem";
            this.hệThôgnsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThôgnsToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuDN
            // 
            this.mnuDN.Name = "mnuDN";
            this.mnuDN.Size = new System.Drawing.Size(180, 22);
            this.mnuDN.Text = "Đăng nhập";
            this.mnuDN.Click += new System.EventHandler(this.mnuDN_Click);
            // 
            // mnuDX
            // 
            this.mnuDX.Name = "mnuDX";
            this.mnuDX.Size = new System.Drawing.Size(180, 22);
            this.mnuDX.Text = "Đăng xuất";
            this.mnuDX.Click += new System.EventHandler(this.mnuDX_Click);
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(180, 22);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(180, 22);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLicXemNha});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Báo cáo";
            // 
            // mnuLicXemNha
            // 
            this.mnuLicXemNha.Name = "mnuLicXemNha";
            this.mnuLicXemNha.Size = new System.Drawing.Size(180, 22);
            this.mnuLicXemNha.Text = "Lịch xem nhà";
            this.mnuLicXemNha.Click += new System.EventHandler(this.mnuLicXemNha_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THUÊ NHÀ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuDatLichXemNha;
        private System.Windows.Forms.ToolStripMenuItem mnuHopDong;
        private System.Windows.Forms.ToolStripMenuItem hệThôgnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuChiNhanh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiNhaChoTHue;
        private System.Windows.Forms.ToolStripMenuItem mnuDN;
        private System.Windows.Forms.ToolStripMenuItem mnuDX;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaChoThue;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuLicXemNha;
    }
}

