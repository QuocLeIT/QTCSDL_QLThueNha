namespace QLThueNha.DanhMuc
{
    partial class FrmNhaChoThue
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboChuNha = new System.Windows.Forms.ComboBox();
            this.cboLoaiNha = new System.Windows.Forms.ComboBox();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtKhuVuc = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoPhong = new System.Windows.Forms.NumericUpDown();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGiaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLoaiNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChuNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDLoaiNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDChuNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH NHÀ CHO THUÊ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoPhong);
            this.groupBox1.Controls.Add(this.cboChuNha);
            this.groupBox1.Controls.Add(this.cboLoaiNha);
            this.groupBox1.Controls.Add(this.cboChiNhanh);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txtKhuVuc);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cboChuNha
            // 
            this.cboChuNha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuNha.FormattingEnabled = true;
            this.cboChuNha.Location = new System.Drawing.Point(419, 72);
            this.cboChuNha.Name = "cboChuNha";
            this.cboChuNha.Size = new System.Drawing.Size(260, 21);
            this.cboChuNha.TabIndex = 5;
            // 
            // cboLoaiNha
            // 
            this.cboLoaiNha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiNha.FormattingEnabled = true;
            this.cboLoaiNha.Location = new System.Drawing.Point(419, 18);
            this.cboLoaiNha.Name = "cboLoaiNha";
            this.cboLoaiNha.Size = new System.Drawing.Size(260, 21);
            this.cboLoaiNha.TabIndex = 6;
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(419, 45);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(260, 21);
            this.cboChiNhanh.TabIndex = 7;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(332, 123);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(251, 123);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(170, 123);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(89, 123);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtKhuVuc
            // 
            this.txtKhuVuc.Location = new System.Drawing.Point(62, 71);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.Size = new System.Drawing.Size(267, 20);
            this.txtKhuVuc.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(170, 99);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(159, 20);
            this.txtGia.TabIndex = 4;
            this.txtGia.Text = "0";
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(62, 45);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(267, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chi nhánh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Khu vực";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Loại nhà";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chủ nhà";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(62, 19);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(267, 20);
            this.txtMa.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvData);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 235);
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
            this.ColMa,
            this.ColDiaChi,
            this.ColKhuVuc,
            this.ColSoPhong,
            this.ColGiaThue,
            this.ColLoaiNha,
            this.ColChiNhanh,
            this.ColChuNha,
            this.ColIDLoaiNha,
            this.ColIDChiNhanh,
            this.ColIDChuNha});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 16);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(685, 216);
            this.dgvData.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(8, 123);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(62, 97);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(68, 20);
            this.txtSoPhong.TabIndex = 11;
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ID";
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColMa
            // 
            this.ColMa.DataPropertyName = "Ma";
            this.ColMa.HeaderText = "Mã";
            this.ColMa.Name = "ColMa";
            this.ColMa.ReadOnly = true;
            // 
            // ColDiaChi
            // 
            this.ColDiaChi.DataPropertyName = "DiaChi";
            this.ColDiaChi.HeaderText = "Địa chỉ";
            this.ColDiaChi.Name = "ColDiaChi";
            this.ColDiaChi.ReadOnly = true;
            // 
            // ColKhuVuc
            // 
            this.ColKhuVuc.DataPropertyName = "KhucVuc";
            this.ColKhuVuc.HeaderText = "Khu vực";
            this.ColKhuVuc.Name = "ColKhuVuc";
            this.ColKhuVuc.ReadOnly = true;
            // 
            // ColSoPhong
            // 
            this.ColSoPhong.DataPropertyName = "SoPhong";
            this.ColSoPhong.HeaderText = "Số phòng";
            this.ColSoPhong.Name = "ColSoPhong";
            this.ColSoPhong.ReadOnly = true;
            this.ColSoPhong.Width = 200;
            // 
            // ColGiaThue
            // 
            this.ColGiaThue.DataPropertyName = "GiaThue";
            this.ColGiaThue.HeaderText = "Giá";
            this.ColGiaThue.Name = "ColGiaThue";
            this.ColGiaThue.ReadOnly = true;
            // 
            // ColLoaiNha
            // 
            this.ColLoaiNha.DataPropertyName = "LoaiNha";
            this.ColLoaiNha.HeaderText = "Loại nhà";
            this.ColLoaiNha.Name = "ColLoaiNha";
            this.ColLoaiNha.ReadOnly = true;
            // 
            // ColChiNhanh
            // 
            this.ColChiNhanh.DataPropertyName = "ChiNhanh";
            this.ColChiNhanh.HeaderText = "Chi nhanh";
            this.ColChiNhanh.Name = "ColChiNhanh";
            this.ColChiNhanh.ReadOnly = true;
            // 
            // ColChuNha
            // 
            this.ColChuNha.DataPropertyName = "ChuNha";
            this.ColChuNha.HeaderText = "Chủ nhà";
            this.ColChuNha.Name = "ColChuNha";
            this.ColChuNha.ReadOnly = true;
            // 
            // ColIDLoaiNha
            // 
            this.ColIDLoaiNha.DataPropertyName = "IDLoaiNha";
            this.ColIDLoaiNha.HeaderText = "IDLoaiNha";
            this.ColIDLoaiNha.Name = "ColIDLoaiNha";
            this.ColIDLoaiNha.ReadOnly = true;
            this.ColIDLoaiNha.Visible = false;
            // 
            // ColIDChiNhanh
            // 
            this.ColIDChiNhanh.DataPropertyName = "IDChiNhanh";
            this.ColIDChiNhanh.HeaderText = "IDChiNhanh";
            this.ColIDChiNhanh.Name = "ColIDChiNhanh";
            this.ColIDChiNhanh.ReadOnly = true;
            this.ColIDChiNhanh.Visible = false;
            // 
            // ColIDChuNha
            // 
            this.ColIDChuNha.DataPropertyName = "IDChuNha";
            this.ColIDChuNha.HeaderText = "IDChuNha";
            this.ColIDChuNha.Name = "ColIDChuNha";
            this.ColIDChuNha.ReadOnly = true;
            this.ColIDChuNha.Visible = false;
            // 
            // FrmNhaChoThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmNhaChoThue";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH NHÀ CHO THUÊ";
            this.Load += new System.EventHandler(this.FrmNhaChoThue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtKhuVuc;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.ComboBox cboChuNha;
        private System.Windows.Forms.ComboBox cboLoaiNha;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown txtSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGiaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLoaiNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChuNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDLoaiNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDChuNha;
    }
}