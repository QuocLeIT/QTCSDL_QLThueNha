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
    public partial class FrmHopDongThue : Form
    {
        DataProvider dp = new DataProvider();
        DataTable ta_Data = new DataTable();
        DataTable ta_NhaXem = new DataTable();

        public FrmHopDongThue()
        {
            InitializeComponent();
        }

        private void FrmHopDongThue_Load(object sender, EventArgs e)
        {
            LoadCboChiNhanh();
            LoadData();

            this.cboChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cboChiNhanh_SelectedIndexChanged);
            this.cboNhaXem.SelectedIndexChanged += new System.EventHandler(this.cboNhaXem_SelectedIndexChanged);
            this.txtThoiGian.ValueChanged += new System.EventHandler(this.txtThoiGian_ValueChanged);
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

        private void LoadCboKhachHang(object idChiNhanh)
        {
            DataTable tb;
            tb = dp.Fillbang("select ID, (Ma + ' - ' + Ten) as Ten from KhachHang where isThueNha = 1 and IDChiNhanh = " + idChiNhanh);

            cboKhachHang.DataSource = tb;
            cboKhachHang.DisplayMember = "Ten";
            cboKhachHang.ValueMember = "ID";
        }

        private void LoadCboNhanVien(object idChiNhanh)
        {
            DataTable tb;
            tb = dp.Fillbang("select ID, (Ma + ' - ' + Ten) as Ten from NhanVien where IDChiNhanh = " + idChiNhanh);

            cboNhanVien.DataSource = tb;
            cboNhanVien.DisplayMember = "Ten";
            cboNhanVien.ValueMember = "ID";
        }

        private void LoadCboNhaXem(object idChiNhanh)
        {
            ta_NhaXem = dp.Fillbang("select ID, (Ma + ' - ' + DiaChi) as Ten, KhucVuc, DiaChi, SoPhong, GiaThue from NhaChoThue where IDChiNhanh = " + idChiNhanh);

            cboNhaXem.DataSource = ta_NhaXem;
            cboNhaXem.DisplayMember = "Ten";
            cboNhaXem.ValueMember = "ID";
        }

        private void cboChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCboKhachHang(cboChiNhanh.SelectedValue);
            LoadCboNhanVien(cboChiNhanh.SelectedValue);
            LoadCboNhaXem(cboChiNhanh.SelectedValue);
        }

        private void cboNhaXem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tb = new DataTable();
                DataView dv = new DataView(ta_NhaXem);
                dv.RowFilter = "ID = " + cboNhaXem.SelectedValue;
                tb = dv.ToTable();

                txtGiaThue.Text = tb.Rows[0]["GiaThue"].ToString();
                txtDiaChi.Text = tb.Rows[0]["DiaChi"].ToString();
            }
            catch (Exception ex)
            {
                txtDiaChi.Text = "";
                txtGiaThue.Text = "0";
            }

            TinhTongTien();
        }

        private void txtThoiGian_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void LoadData()
        {
            ta_Data = dp.Fillbang("select xn.ID, kh.Ten as KhachHang, nv.Ten as NhanVien, nct.DiaChi, xn.ThoiGianKyHopDong, xn.GiaThueThang, xn.ThoiGianThue, xn.TongTien , cn.Ten as ChiNhanh, xn.IDKH as IDKhachHang, xn.IDNV as IDNhanVien, xn.IDNhaThue, nct.IDChiNhanh from HopDongThue as xn inner join KhachHang as kh on xn.IDKH = kh.ID inner join NhanVien as nv on xn.IDNV = nv.ID inner join NhaChoThue as nct on xn.IDNhaThue = nct.ID inner join ChiNhanh as cn on nct.IDChiNhanh = cn.ID order by xn.ID");
            dgvData.DataSource = ta_Data;
        }

        private void dgvData_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;

                int i = dgvData.CurrentRow.Index;

                cboChiNhanh.SelectedValue = Convert.ToInt16(dgvData.Rows[i].Cells["ColIDChiNhanh"].Value.ToString());
                cboKhachHang.SelectedValue = Convert.ToInt16(dgvData.Rows[i].Cells["ColIDKhachHang"].Value.ToString());
                cboNhanVien.SelectedValue = Convert.ToInt16(dgvData.Rows[i].Cells["ColIDNhanVien"].Value.ToString());
                cboNhaXem.SelectedValue = Convert.ToInt16(dgvData.Rows[i].Cells["ColIDNhaThue"].Value.ToString());

                dtpThoiGian.Value = Convert.ToDateTime(dgvData.Rows[i].Cells["ColThoiGianKyHopDong"].Value.ToString());
                txtGiaThue.Text = dgvData.Rows[i].Cells["ColGiaThue"].Value.ToString();
                txtThoiGian.Value = Convert.ToInt16(dgvData.Rows[i].Cells["ColThoiGianThue"].Value.ToString());
                txtThanhTien.Text = dgvData.Rows[i].Cells["ColTongTien"].Value.ToString();
            }
            catch (Exception ex)
            {
                ClearText();
            }
        }

        private void TinhTongTien()
        {
            try {
                Decimal gia = Convert.ToDecimal(txtGiaThue.Text.Trim());
                txtThanhTien.Text = (gia * txtThoiGian.Value).ToString();
            }
            catch (Exception ex) {
                txtThanhTien.Text = "0";
            }
        }

        private void ClearText()
        {
            dtpThoiGian.Value = DateTime.Now;
            txtDiaChi.Text = "";
            txtGiaThue.Text = "0";
            txtThoiGian.Value = 1;
            txtThanhTien.Text = "0";
        }

        private bool CheckData()
        {

            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            cboChiNhanh.Focus();
        }

        private void InsertUpdate(int id)
        {
            string[] str = new string[8];
            object[] val = new object[8];

            str[0] = "@ID";
            str[1] = "@idKhachHang";
            str[2] = "@idNhanVien";
            str[3] = "@idNhaThue";
            str[4] = "@thoiGianKyHD";
            str[5] = "@giaThueThang";
            str[6] = "@thoigGianThue";
            str[7] = "@tongTien";
           
            val[0] = id;
            val[1] = Convert.ToInt16(cboKhachHang.SelectedValue.ToString());
            val[2] = Convert.ToInt16(cboNhanVien.SelectedValue.ToString());
            val[3] = Convert.ToInt16(cboNhaXem.SelectedValue.ToString());
            val[4] = dtpThoiGian.Value;
            val[5] = Convert.ToDecimal(txtGiaThue.Text.Trim());
            val[6] = txtThoiGian.Value;
            val[7] = Convert.ToDecimal(txtThanhTien.Text);

            try
            {
                Int32 re = dp.WriteDataAddParam("sp_InsertUpdate_HopDongThue", str, val, 50);

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
                            MessageBox.Show("Khách hàng trùng với chủ nhà!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cboKhachHang.Focus();
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

                dp.MyExecuteNonQuery("delete from HopDongThue where ID = " + ID);
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
