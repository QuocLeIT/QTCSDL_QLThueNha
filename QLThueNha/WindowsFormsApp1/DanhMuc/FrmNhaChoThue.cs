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
using QLThueNha.Module;

namespace QLThueNha.DanhMuc
{
    public partial class FrmNhaChoThue : Form
    {
        DataProvider dp = new DataProvider();
        DataTable ta_Data = new DataTable();

        public FrmNhaChoThue()
        {
            InitializeComponent();
        }

        private void FrmNhaChoThue_Load(object sender, EventArgs e)
        {
            if (DataAccount._idUser > 0) {
                LockButton(true);
            }else
                LockButton(false);

            LoadCboLoaiNha();
            LoadCboChiNhanh();
            LoadData();

            this.cboChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cboChiNhanh_SelectedIndexChanged);
            this.dgvData.CurrentCellChanged += new System.EventHandler(this.dgvData_CurrentCellChanged);     
        }

        private void LockButton(bool isLock) {
            btnLuu.Enabled = isLock;
            btnCapNhat.Enabled = isLock;
            btnXoa.Enabled = isLock;
        }

        private void LoadCboLoaiNha()
        {
            DataTable tb;
            tb = dp.Fillbang("select ID, Ten from LoaiNha order by Ten");

            cboLoaiNha.DataSource = tb;
            cboLoaiNha.DisplayMember = "Ten";
            cboLoaiNha.ValueMember = "ID";
        }

        private void LoadCboChiNhanh()
        {
            DataTable tb;
            tb = dp.Fillbang("select ID, Ten from ChiNhanh order by Ten");

            cboChiNhanh.DataSource = tb;
            cboChiNhanh.DisplayMember = "Ten";
            cboChiNhanh.ValueMember = "ID";
        }

        private void LoadCboChuNha(object idChiNhanh)
        {
            DataTable tb;
            tb = dp.Fillbang("select ID, (Ma + ' - ' + Ten) as Ten from KhachHang where isChoThueNha = 1 and IDChiNhanh = " + idChiNhanh);

            cboChuNha.DataSource = tb;
            cboChuNha.DisplayMember = "Ten";
            cboChuNha.ValueMember = "ID";
        }

        private void LoadData()
        {
            ta_Data = dp.Fillbang("select nct.ID, nct.Ma, nct.DiaChi, nct.KhucVuc, nct.SoPhong, nct.GiaThue, l.Ten as LoaiNha, cn.Ten as ChiNhanh, kh.Ten as ChuNha, nct.IDLoaiNha, nct.IDChiNhanh, nct.IDChuNha from NhaChoThue as nct inner join LoaiNha as l on nct.IDLoaiNha = l.ID inner join ChiNhanh as cn on nct.IDChiNhanh = cn.ID inner join KhachHang as kh on nct.IDChuNha = kh.ID order by nct.ID DESC");
            dgvData.DataSource = ta_Data;
        }

        private void cboChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCboChuNha(cboChiNhanh.SelectedValue);
        }

        private void dgvData_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;

                int i = dgvData.CurrentRow.Index;

                txtMa.Text = dgvData.Rows[i].Cells["ColMa"].Value.ToString();
                txtDiaChi.Text = dgvData.Rows[i].Cells["ColDiaChi"].Value.ToString();
                txtKhuVuc.Text = dgvData.Rows[i].Cells["ColKhuVuc"].Value.ToString();
                txtDiaChi.Text = dgvData.Rows[i].Cells["ColDiaChi"].Value.ToString();
                txtSoPhong.Value = Convert.ToInt16(dgvData.Rows[i].Cells["ColSoPhong"].Value.ToString());
                txtGia.Text = dgvData.Rows[i].Cells["ColGiaThue"].Value.ToString();

                cboLoaiNha.SelectedValue = Convert.ToInt16(dgvData.Rows[i].Cells["ColIDLoaiNha"].Value.ToString());
                cboChiNhanh.SelectedValue = Convert.ToInt16(dgvData.Rows[i].Cells["ColIDChiNhanh"].Value.ToString());
                cboChuNha.SelectedValue = Convert.ToInt16(dgvData.Rows[i].Cells["ColIDChuNha"].Value.ToString());
            }
            catch (Exception ex)
            {
                ClearText();
            }
        }

        private void ClearText()
        {
            txtMa.Text = "";
            txtDiaChi.Text = "";
            txtKhuVuc.Text = "";
            txtGia.Text = "0";
            txtSoPhong.Value = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            txtMa.Focus();
        }

        private bool CheckData()
        {
            if (txtMa.Text.Trim() == "" || txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu dữ liệu Mã, Địa chỉ!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            try
            {
                Decimal l = Convert.ToDecimal(txtGia.Text.Trim());
                if (l < 0)
                {
                    MessageBox.Show("Giá không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giá không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private void InsertUpdate(int id)
        {
            string[] str = new string[9];
            object[] val = new object[9];

            str[0] = "@ID";
            str[1] = "@Ma";
            str[2] = "@DiaChi";
            str[3] = "@KhuVuc";
            str[4] = "@SoPhong";
            str[5] = "@Gia";
            str[6] = "@idLoaiNha";
            str[7] = "@idChiNhanh";
            str[8] = "@idChuNha";
         

            val[0] = id;
            val[1] = txtMa.Text.Trim();
            val[2] = txtDiaChi.Text.Trim();
            val[3] = txtKhuVuc.Text.Trim();
            val[4] = txtSoPhong.Value;
            val[5] = Convert.ToDecimal(txtGia.Text.Trim());
            val[6] = Convert.ToInt16(cboLoaiNha.SelectedValue.ToString());
            val[7] = Convert.ToInt16(cboChiNhanh.SelectedValue.ToString());
            val[8] = Convert.ToInt16(cboChuNha.SelectedValue.ToString());

            try
            {
                Int32 re = dp.WriteDataAddParam("sp_InsertUpdate_NhaChiThue", str, val, 50);

                if (re > 0)
                {                  
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

                dp.MyExecuteNonQuery("delete from NhaChoThue where ID = " + ID);
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
    }
}
