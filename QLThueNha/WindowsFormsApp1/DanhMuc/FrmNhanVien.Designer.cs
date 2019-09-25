namespace QLThueNha.DanhMuc
{
    partial class FrmNhanVien
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGioiTinhNam = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbtnNam);
            this.groupBox1.Controls.Add(this.cboChiNhanh);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(442, 124);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(267, 20);
            this.txtPass.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(442, 98);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(267, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(365, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Username";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(442, 19);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(268, 20);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(138, 125);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Checked = true;
            this.rbtnNam.Location = new System.Drawing.Point(85, 125);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(47, 17);
            this.rbtnNam.TabIndex = 4;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(442, 71);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(267, 21);
            this.cboChiNhanh.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(328, 148);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(247, 148);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(166, 148);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 12;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(85, 148);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(442, 45);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(267, 20);
            this.txtLuong.TabIndex = 7;
            this.txtLuong.Text = "0";
            this.txtLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(85, 71);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(267, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(85, 45);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(267, 20);
            this.txtTen.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 74);
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
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "SDT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(85, 97);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(267, 20);
            this.txtDiaChi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(85, 19);
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
            this.groupBox2.Location = new System.Drawing.Point(0, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 207);
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
            this.ColTen,
            this.ColSDT,
            this.ColDiaChi,
            this.ColGioiTinh,
            this.ColGioiTinhNam,
            this.ColNgaySinh,
            this.ColLuong,
            this.ColUsername,
            this.ColPass,
            this.ColChiNhanh,
            this.ColIDChiNhanh});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 16);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(716, 188);
            this.dgvData.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(4, 148);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cập nhật Username password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            // ColTen
            // 
            this.ColTen.DataPropertyName = "Ten";
            this.ColTen.HeaderText = "Tên";
            this.ColTen.Name = "ColTen";
            this.ColTen.ReadOnly = true;
            // 
            // ColSDT
            // 
            this.ColSDT.DataPropertyName = "SDT";
            this.ColSDT.HeaderText = "SDT";
            this.ColSDT.Name = "ColSDT";
            this.ColSDT.ReadOnly = true;
            // 
            // ColDiaChi
            // 
            this.ColDiaChi.DataPropertyName = "DiaChi";
            this.ColDiaChi.HeaderText = "Địa chỉ";
            this.ColDiaChi.Name = "ColDiaChi";
            this.ColDiaChi.ReadOnly = true;
            // 
            // ColGioiTinh
            // 
            this.ColGioiTinh.DataPropertyName = "GioiTinh";
            this.ColGioiTinh.HeaderText = "Giới tính";
            this.ColGioiTinh.Name = "ColGioiTinh";
            this.ColGioiTinh.ReadOnly = true;
            // 
            // ColGioiTinhNam
            // 
            this.ColGioiTinhNam.DataPropertyName = "GioiTinhNam";
            this.ColGioiTinhNam.HeaderText = "GioiTinhNam";
            this.ColGioiTinhNam.Name = "ColGioiTinhNam";
            this.ColGioiTinhNam.ReadOnly = true;
            this.ColGioiTinhNam.Visible = false;
            // 
            // ColNgaySinh
            // 
            this.ColNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.ColNgaySinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColNgaySinh.HeaderText = "Ngày sinh";
            this.ColNgaySinh.Name = "ColNgaySinh";
            this.ColNgaySinh.ReadOnly = true;
            // 
            // ColLuong
            // 
            this.ColLuong.DataPropertyName = "Luong";
            this.ColLuong.HeaderText = "Lương";
            this.ColLuong.Name = "ColLuong";
            this.ColLuong.ReadOnly = true;
            // 
            // ColUsername
            // 
            this.ColUsername.DataPropertyName = "Username";
            this.ColUsername.HeaderText = "Username";
            this.ColUsername.Name = "ColUsername";
            this.ColUsername.ReadOnly = true;
            // 
            // ColPass
            // 
            this.ColPass.DataPropertyName = "Pass";
            this.ColPass.HeaderText = "Pass";
            this.ColPass.Name = "ColPass";
            this.ColPass.ReadOnly = true;
            this.ColPass.Visible = false;
            // 
            // ColChiNhanh
            // 
            this.ColChiNhanh.DataPropertyName = "ChiNhanh";
            this.ColChiNhanh.HeaderText = "Chi nhanh";
            this.ColChiNhanh.Name = "ColChiNhanh";
            this.ColChiNhanh.ReadOnly = true;
            // 
            // ColIDChiNhanh
            // 
            this.ColIDChiNhanh.DataPropertyName = "IDChiNhanh";
            this.ColIDChiNhanh.HeaderText = "IDChiNhanh";
            this.ColIDChiNhanh.Name = "ColIDChiNhanh";
            this.ColIDChiNhanh.ReadOnly = true;
            this.ColIDChiNhanh.Visible = false;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmNhanVien";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH NHÂN VIÊN";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
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
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGioiTinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColGioiTinhNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDChiNhanh;
    }
}