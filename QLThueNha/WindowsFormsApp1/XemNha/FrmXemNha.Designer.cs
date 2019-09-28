namespace QLThueNha.DanhMuc
{
    partial class FrmXemNha
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChiTiet = new System.Windows.Forms.TextBox();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.cboNhaXem = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtNhanXet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThoiGianXem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNhanSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDNhaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐẶT LỊCH XEM NHÀ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtChiTiet);
            this.groupBox1.Controls.Add(this.dtpThoiGian);
            this.groupBox1.Controls.Add(this.cboNhaXem);
            this.groupBox1.Controls.Add(this.cboNhanVien);
            this.groupBox1.Controls.Add(this.cboChiNhanh);
            this.groupBox1.Controls.Add(this.cboKhachHang);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txtNhanXet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Location = new System.Drawing.Point(443, 45);
            this.txtChiTiet.Multiline = true;
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.ReadOnly = true;
            this.txtChiTiet.Size = new System.Drawing.Size(267, 72);
            this.txtChiTiet.TabIndex = 5;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "HH:mm - dd/MM/yyyy";
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(85, 98);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(260, 20);
            this.dtpThoiGian.TabIndex = 3;
            // 
            // cboNhaXem
            // 
            this.cboNhaXem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaXem.FormattingEnabled = true;
            this.cboNhaXem.Location = new System.Drawing.Point(443, 18);
            this.cboNhaXem.Name = "cboNhaXem";
            this.cboNhaXem.Size = new System.Drawing.Size(267, 21);
            this.cboNhaXem.TabIndex = 4;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(85, 71);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(260, 21);
            this.cboNhanVien.TabIndex = 2;
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(85, 18);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(260, 21);
            this.cboChiNhanh.TabIndex = 0;
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(85, 45);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(260, 21);
            this.cboKhachHang.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(347, 160);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(266, 160);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(185, 160);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(23, 160);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(104, 160);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtNhanXet
            // 
            this.txtNhanXet.Location = new System.Drawing.Point(443, 122);
            this.txtNhanXet.Multiline = true;
            this.txtNhanXet.Name = "txtNhanXet";
            this.txtNhanXet.Size = new System.Drawing.Size(267, 46);
            this.txtNhanXet.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhà xem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nhận xét";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chi nhánh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColKhachHang,
            this.ColNhanVien,
            this.ColDiaChi,
            this.ColThoiGianXem,
            this.ColNhanSet,
            this.ColChiNhanh,
            this.ColIDKhachHang,
            this.ColIDNhanVien,
            this.ColIDNhaThue,
            this.ColIDChiNhanh});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 16);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(716, 186);
            this.dgvData.TabIndex = 0;
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ID";
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColKhachHang
            // 
            this.ColKhachHang.DataPropertyName = "KhachHang";
            this.ColKhachHang.HeaderText = "Khách hàng";
            this.ColKhachHang.Name = "ColKhachHang";
            this.ColKhachHang.ReadOnly = true;
            // 
            // ColNhanVien
            // 
            this.ColNhanVien.DataPropertyName = "NhanVien";
            this.ColNhanVien.HeaderText = "Nhân viên";
            this.ColNhanVien.Name = "ColNhanVien";
            this.ColNhanVien.ReadOnly = true;
            // 
            // ColDiaChi
            // 
            this.ColDiaChi.DataPropertyName = "DiaChi";
            this.ColDiaChi.HeaderText = "Nhà xem";
            this.ColDiaChi.Name = "ColDiaChi";
            this.ColDiaChi.ReadOnly = true;
            this.ColDiaChi.Width = 200;
            // 
            // ColThoiGianXem
            // 
            this.ColThoiGianXem.DataPropertyName = "ThoiGianXem";
            dataGridViewCellStyle1.Format = "HH:mm - dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.ColThoiGianXem.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColThoiGianXem.HeaderText = "Thời gian";
            this.ColThoiGianXem.Name = "ColThoiGianXem";
            this.ColThoiGianXem.ReadOnly = true;
            // 
            // ColNhanSet
            // 
            this.ColNhanSet.DataPropertyName = "NhanSet";
            this.ColNhanSet.HeaderText = "Nhận xét";
            this.ColNhanSet.Name = "ColNhanSet";
            this.ColNhanSet.ReadOnly = true;
            // 
            // ColChiNhanh
            // 
            this.ColChiNhanh.DataPropertyName = "ChiNhanh";
            this.ColChiNhanh.HeaderText = "Chi nhánh";
            this.ColChiNhanh.Name = "ColChiNhanh";
            this.ColChiNhanh.ReadOnly = true;
            // 
            // ColIDKhachHang
            // 
            this.ColIDKhachHang.DataPropertyName = "IDKhachHang";
            this.ColIDKhachHang.HeaderText = "IDKhachHang";
            this.ColIDKhachHang.Name = "ColIDKhachHang";
            this.ColIDKhachHang.ReadOnly = true;
            this.ColIDKhachHang.Visible = false;
            // 
            // ColIDNhanVien
            // 
            this.ColIDNhanVien.DataPropertyName = "IDNhanVien";
            this.ColIDNhanVien.HeaderText = "IDNhanVien";
            this.ColIDNhanVien.Name = "ColIDNhanVien";
            this.ColIDNhanVien.ReadOnly = true;
            this.ColIDNhanVien.Visible = false;
            // 
            // ColIDNhaThue
            // 
            this.ColIDNhaThue.DataPropertyName = "IDNhaThue";
            this.ColIDNhaThue.HeaderText = "IDNhaXem";
            this.ColIDNhaThue.Name = "ColIDNhaThue";
            this.ColIDNhaThue.ReadOnly = true;
            this.ColIDNhaThue.Visible = false;
            // 
            // ColIDChiNhanh
            // 
            this.ColIDChiNhanh.DataPropertyName = "IDChiNhanh";
            this.ColIDChiNhanh.HeaderText = "IDChiNhanh";
            this.ColIDChiNhanh.Name = "ColIDChiNhanh";
            this.ColIDChiNhanh.ReadOnly = true;
            this.ColIDChiNhanh.Visible = false;
            // 
            // FrmXemNha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmXemNha";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐẶT LỊCH XEM NHÀ";
            this.Load += new System.EventHandler(this.FrmXemNha_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.TextBox txtNhanXet;
        private System.Windows.Forms.ComboBox cboNhaXem;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThoiGianXem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNhanSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDNhaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDChiNhanh;
    }
}