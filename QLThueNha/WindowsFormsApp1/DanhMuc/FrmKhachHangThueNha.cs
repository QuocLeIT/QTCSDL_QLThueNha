using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThueNha.Module;
using Provider;

namespace QLThueNha.DanhMuc
{
    public partial class FrmKhachHangThueNha : Form
    {

        DataProvider dp = new DataProvider();
        DataTable ta_Data = new DataTable();


        public FrmKhachHangThueNha()
        {
            InitializeComponent();
        }

        private void FrmKhachHangThueNha_Load(object sender, EventArgs e)
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
            ta_Data = dp.Fillbang("select kh.ID, kh.Ma, kh.Ten, kh.SDT, kh.DiaChi, cn.Ten as ChiNhanh, kh.isChoThueNha, kh.isThueNha, kh.ThongTinNhaMuonThue, kh.KhaNangThue, kh.Username, kh.Pass, kh.IDChiNhanh from KhachHang as kh inner join ChiNhanh as cn on kh.IDChiNhanh = cn.ID order by kh.Ten");
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
                chkChoThue.Checked = Convert.ToBoolean(dgvData.Rows[i].Cells["ColisChoThueNha"].Value.ToString());
                chkThueNha.Checked = Convert.ToBoolean(dgvData.Rows[i].Cells["ColisThueNha"].Value.ToString());

                txtThongTinTHue.Text = dgvData.Rows[i].Cells["ColThongTinNhaMuonThue"].Value.ToString();
                txtKhaNang.Text = dgvData.Rows[i].Cells["ColKhaNangThue"].Value.ToString();
              
                cboChiNhanh.SelectedValue = Convert.ToInt16(dgvData.Rows[i].Cells["ColIDChiNhanh"].Value.ToString());
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
            txtDiaChi.Text = "";

            chkChoThue.Checked = false;
            chkThueNha.Checked = false;

            txtThongTinTHue.Text = "";
            txtKhaNang.Text = "";
            
            txtUsername.Text = "";
            txtPass.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

            if (chkChoThue.Checked == false &&  chkThueNha.Checked == false)
            {
                MessageBox.Show("Chọn ít nhất 1 thông tin: Cho thuê nhà hoặc Thuê nhà!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private int UpdateUsernamePass(int id, string username, string pass)
        {
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
                return dp.WriteDataAddParam("sp_UpdateUsernamePass_KhachHang", str, val, 50);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        private void InsertUpdate(int id)
        {
            string[] str = new string[10];
            object[] val = new object[10];

            str[0] = "@ID";
            str[1] = "@Ma";
            str[2] = "@Ten";
            str[3] = "@SDT";
            str[4] = "@DiaChi";
            str[5] = "@isChoThueNha";
            str[6] = "@isThueNha";
            str[7] = "@ThongTin";
            str[8] = "@KhaNang";
            str[9] = "@idChiNhanh";

            val[0] = id;
            val[1] = txtMa.Text.Trim();
            val[2] = txtTen.Text.Trim();
            val[3] = txtSDT.Text.Trim();
            val[4] = txtDiaChi.Text.Trim();
            val[5] = chkChoThue.Checked;
            val[6] = chkThueNha.Checked;
            val[7] = txtThongTinTHue.Text.Trim();
            val[8] = txtKhaNang.Text.Trim();
            val[9] = cboChiNhanh.SelectedValue;

            try
            {
                Int32 re = dp.WriteDataAddParam("sp_InsertUpdate_KhachHang", str, val, 50);

                if (re > 0)
                {
                    int up = UpdateUsernamePass(re, txtUsername.Text, txtPass.Text);
                    if (up == -3)
                    {
                        MessageBox.Show("Trùng Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        //return;
                    }
                    if (up < 1)
                    {
                        MessageBox.Show("Lỗi Username, password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }

                    ClearText();
                    LoadData();
                    MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (re == -2 || re == -3)
                    {
                        if (re == -2)
                        {
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

        private void btnLuu_Click(object sender, EventArgs e)
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

                dp.MyExecuteNonQuery("delete from KhachHang where ID = " + ID);
                ClearText();

                LoadData();
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
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
