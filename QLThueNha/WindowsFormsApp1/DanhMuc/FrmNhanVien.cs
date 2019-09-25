using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Provider;


namespace QLThueNha.DanhMuc
{
    public partial class FrmNhanVien : Form
    {
        DataProvider dp = new DataProvider();
        DataTable ta_Data = new DataTable();

        //2019-09-25
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadCboChiNhanh();
            LoadData();

            this.dgvData.CurrentCellChanged += new System.EventHandler(this.dgvData_CurrentCellChanged);
        }

        private void LoadCboChiNhanh()
        {
            DataTable tb;
            tb = dp.Fillbang("select ID, Ten from ChiNhanh order by Ten");

            cboChiNhanh.DataSource = tb;
            cboChiNhanh.DisplayMember = "Ten";
            cboChiNhanh.ValueMember = "ID";
        }

        private void LoadData()
        {
            ta_Data = dp.Fillbang("select nv.ID, nv.Ma,nv.Ten, nv.SDT, nv.DiaChi, (case when nv.GioiTinh = 1 then N'Nam' else N'Nữ' end) as GioiTinh, nv.GioiTinh as GioiTinhNam, nv.NgaySinh, nv.Luong, nv.Username, nv.Pass,cn.Ten as ChiNhanh, nv.IDChiNhanh from NhanVien as nv inner join ChiNhanh as cn on nv.IDChiNhanh = cn.ID where nv.ID > 1 order by nv.Ten");
            dgvData.DataSource = ta_Data;
        }

        private void dgvData_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;

                int i = dgvData.CurrentRow.Index;

                txtMa.Text = dgvData.Rows[i].Cells["ColMa"].Value.ToString();
                txtTen.Text = dgvData.Rows[i].Cells["ColTen"].Value.ToString();
                txtSDT.Text = dgvData.Rows[i].Cells["ColSDT"].Value.ToString();
                txtDiaChi.Text = dgvData.Rows[i].Cells["ColDiaChi"].Value.ToString();
                rbtnNam.Checked = Convert.ToBoolean(dgvData.Rows[i].Cells["ColGioiTinhNam"].Value.ToString());
                dtpNgaySinh.Value = Convert.ToDateTime(dgvData.Rows[i].Cells["ColNgaySinh"].Value.ToString());
                txtLuong.Text = dgvData.Rows[i].Cells["ColLuong"].Value.ToString();
                cboChiNhanh.SelectedValue = Convert.ToInt16(dgvData.Rows[i].Cells["ColIDCHiNhanh"].Value.ToString());
                txtUsername.Text = dgvData.Rows[i].Cells["ColUsername"].Value.ToString();
                txtPass.Text = dgvData.Rows[i].Cells["ColPass"].Value.ToString();
            }
            catch (Exception ex)
            {
                ClearText();
            }
        }

        private void ClearText()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtLuong.Text = "0";
            txtDiaChi.Text = "";
            txtUsername.Text = "";
            txtPass.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            txtMa.Focus();
        }

        private bool CheckData()
        {
            if (txtMa.Text.Trim() == "" || txtTen.Text.Trim() == "" || txtUsername.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu dữ liệu Mã, Tên nhân viên, Username, Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            try {
                Decimal l = Convert.ToDecimal(txtLuong.Text.Trim());
                if (l < 0) {
                    MessageBox.Show("Lương không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Lương không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private int UpdateUsernamePass(int id, string username, string pass) {
            string[] str = new string[3];
            object[] val = new object[3];

            str[0] = "@ID";
            str[1] = "@Username";
            str[2] = "@Password";

            val[0] = id;
            val[1] = username.Trim();
            val[2] = pass.Trim();

            //
            try
            {
                return dp.WriteDataAddParam("sp_UpdateUsernamePass_NhanVien", str, val, 50);
            }
            catch (Exception ex) {
                return -1;     
            }
        }

        private void InsertUpdate(int id) {
            string[] str = new string[9];
            object[] val = new object[9];

            str[0] = "@ID";
            str[1] = "@Ma";
            str[2] = "@Ten";
            str[3] = "@SDT";
            str[4] = "@DiaChi";
            str[5] = "@GioiTinh";
            str[6] = "@NgaySinh";
            str[7] = "@Luong";
            str[8] = "@IDChiNhanh";
            //str[9] = "@Username";
            //str[10] = "@Password";

            val[0] = id;
            val[1] = txtMa.Text.Trim();
            val[2] = txtTen.Text.Trim();
            val[3] = txtSDT.Text.Trim();
            val[4] = txtDiaChi.Text.Trim();
            val[5] = rbtnNam.Checked;
            val[6] = dtpNgaySinh.Value;
            val[7] = Convert.ToDecimal(txtLuong.Text.Trim());
            val[8] = cboChiNhanh.SelectedValue;
            //val[9] = txtUsername.Text.Trim();
            //val[10] = txtPass.Text.Trim();

            try
            {
                Int32 re = dp.WriteDataAddParam("sp_InsertUpdateNhanVien", str, val, 50);

                if (re > 0)
                {
                    int up = UpdateUsernamePass(re, txtUsername.Text, txtPass.Text);
                    if (up == -3)
                    {
                        MessageBox.Show("Trùng Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        return;
                    }
                    if (up < 1)
                    {
                        MessageBox.Show("Lỗi Username, password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ClearText();
                    LoadData();
                    MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (re == -2 || re == -3)
                    {
                        if (re == -2) {
                            MessageBox.Show("Trùng mã", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMa.Focus();
                        }
                    }
                    else MessageBox.Show("Lỗi...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckData()) return;
            InsertUpdate(0);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;
            if (CheckData()) return;
            try
            {
                int i = dgvData.CurrentRow.Index;
                int ID = Convert.ToInt32(dgvData.Rows[i].Cells["ColID"].Value.ToString());
                InsertUpdate(ID);
            }
            catch (Exception ex)
            {

            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;
            if (MessageBox.Show("Xác nhận?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;
            try
            {
                int i = dgvData.CurrentRow.Index;
                int ID = Convert.ToInt32(dgvData.Rows[i].Cells["ColID"].Value.ToString());

                dp.MyExecuteNonQuery("delete from NhanVien where ID = " + ID);
                ClearText();

                LoadData();
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;
            if (CheckData()) return;
            if (MessageBox.Show("Xác nhận?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;

            try
            {
                int i = dgvData.CurrentRow.Index;
                int ID = Convert.ToInt32(dgvData.Rows[i].Cells["ColID"].Value.ToString());

                int up = UpdateUsernamePass(ID, txtUsername.Text, txtPass.Text);
                if (up == -3)
                {
                    MessageBox.Show("Trùng Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }
                if (up < 1)
                {
                    MessageBox.Show("Lỗi Username, password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ClearText();
                LoadData();
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
