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
    public partial class FrmXemNha : Form
    {
        DataProvider dp = new DataProvider();
        DataTable ta_Data = new DataTable();
        DataTable ta_NhaXem = new DataTable();

        public FrmXemNha()
        {
            InitializeComponent();
        }

        private void FrmXemNha_Load(object sender, EventArgs e)
        {
            LoadCboChiNhanh();
            LoadData();


            this.cboChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cboChiNhanh_SelectedIndexChanged);
            this.cboNhaXem.SelectedIndexChanged += new System.EventHandler(this.cboNhaXem_SelectedIndexChanged);
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
            try {
                DataTable tb = new DataTable();
                DataView dv = new DataView(ta_NhaXem);
                dv.RowFilter = "ID = " + cboNhaXem.SelectedValue;
                tb = dv.ToTable();

                string ct = "-Địa chỉ: " + tb.Rows[0]["DiaChi"].ToString() + "\n";
                ct += "-Khu vực: " + tb.Rows[0]["KhucVuc"].ToString() + "\n";
                ct += "-Số phòng: " + tb.Rows[0]["SoPhong"].ToString() + "\n";
                ct += "-Giá cho thuê: " + tb.Rows[0]["GiaThue"].ToString();
             
                txtChiTiet.Text = ct;
            }
            catch (Exception ex) {
                txtChiTiet.Text = "";
            }         
        }

        private void LoadData()
        {
            ta_Data = dp.Fillbang("select xn.ID, kh.Ten as KhachHang, nv.Ten as NhanVien, nct.DiaChi, xn.ThoiGianXem, xn.NhanSet, cn.Ten as ChiNhanh, xn.IDKH as IDKhachHang, xn.IDNV as IDNhanVien, xn.IDNhaThue, nct.IDChiNhanh from XemNha as xn inner join KhachHang as kh on xn.IDKH = kh.ID inner join NhanVien as nv on xn.IDNV = nv.ID inner join NhaChoThue as nct on xn.IDNhaThue = nct.ID inner join ChiNhanh as cn on nct.IDChiNhanh = cn.ID order by xn.ID");
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

                dtpThoiGian.Value = Convert.ToDateTime(dgvData.Rows[i].Cells["ColThoiGianXem"].Value.ToString());
                txtNhanXet.Text = dgvData.Rows[i].Cells["ColNhanSet"].Value.ToString();   
            }
            catch (Exception ex)
            {
                ClearText();
            }
        }

        private void ClearText()
        {
            dtpThoiGian.Value = DateTime.Now;
            txtChiTiet.Text = "";
            txtNhanXet.Text = "";
            
        }

        private bool CheckData()
        {
            return false;
        }

        private void InsertUpdate(int id)
        {
            string[] str = new string[6];
            object[] val = new object[6];

            str[0] = "@ID";
            str[1] = "@idKhachHang";
            str[2] = "@idNhanVien";
            str[3] = "@thoiGian";
            str[4] = "@idNhaXem";
            str[5] = "@nhanXet";
         
            val[0] = id;
            val[1] = Convert.ToInt16(cboKhachHang.SelectedValue.ToString());
            val[2] = Convert.ToInt16(cboNhanVien.SelectedValue.ToString());
            val[3] = dtpThoiGian.Value;
            val[4] = Convert.ToInt16(cboNhaXem.SelectedValue.ToString());
            val[5] = txtNhanXet.Text.Trim();

            try
            {
                Int32 re = dp.WriteDataAddParam("sp_InsertUpdate_XemNha", str, val, 50);

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            cboChiNhanh.Focus();
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

                dp.MyExecuteNonQuery("delete from XemNha where ID = " + ID);
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
