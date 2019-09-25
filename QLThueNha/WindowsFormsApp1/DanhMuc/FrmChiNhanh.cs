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
    public partial class FrmChiNhanh : Form
    {
        DataProvider dp = new DataProvider();
        DataTable ta_Data = new DataTable();
       

        public FrmChiNhanh()
        {
            InitializeComponent();
        }

        private void FrmChiNhanh_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMa.Focus();
            this.dgvData.CurrentCellChanged += new System.EventHandler(this.dgvData_CurrentCellChanged);
        }

        private void LoadData() {        
            ta_Data = dp.Fillbang("select ID, Ma, Ten, SDT, FAX, DiaChi, KhuVuc  from ChiNhanh order by Ten");
            dgvData.DataSource = ta_Data;
        }

        private int InsertUpdateData(int ID, string Ma, string Ten, string SDT, string FAX, string DiaChi, string KhuVuc)
        {
            string[] str = new string[7];
            object[] val = new object[7];

            str[0] = "@ID";
            str[1] = "@Ma";
            str[2] = "@Ten";
            str[3] = "@SDT";
            str[4] = "@FAX";
            str[5] = "@DiaChi";
            str[6] = "@KhuVuc";

            val[0] = ID;
            val[1] = Ma.Trim();
            val[2] = Ten.Trim();
            val[3] = SDT.Trim();
            val[4] = FAX.Trim();
            val[5] = DiaChi.Trim();
            val[6] = KhuVuc.Trim();

            try {
                return dp.WriteDataAddParam("sp_InsertUpdateChiNhanh", str, val, 50);
            }
            catch (Exception ex) {
                return -1;
            }
        }

        private void InsertUpdate(int ID, string Ma, string Ten, string SDT, string FAX, string DiaChi, string KhuVuc)
        {
            int re = InsertUpdateData(ID, Ma, Ten, SDT, FAX, DiaChi, KhuVuc);

            if (re > 0)
            {
                LoadData();
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
            else
            {
                if (re == -2)
                {
                    MessageBox.Show("Trùng mã", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMa.Focus();
                }
                else MessageBox.Show("Lỗi...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ThieuDuLieu() {
            if (txtMa.Text.Trim() == "" || txtTen.Text.Trim() == "") {
                MessageBox.Show("Thiếu dữ liệu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ThieuDuLieu()) return;
            InsertUpdate(0, txtMa.Text, txtTen.Text, txtSDT.Text, txtFAX.Text, txtDiaChi.Text, txtKhuVuc.Text);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;
            if (ThieuDuLieu()) return;

            try
            {
                int i = dgvData.CurrentRow.Index;
                int ID = Convert.ToInt32(dgvData.Rows[i].Cells["ColID"].Value.ToString());
                InsertUpdate(ID, txtMa.Text, txtTen.Text, txtSDT.Text, txtFAX.Text, txtDiaChi.Text, txtKhuVuc.Text);
            }
            catch (Exception ex) { 
            
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;

            if (MessageBox.Show("Xác nhận xóa?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;

            try
            {
                int i = dgvData.CurrentRow.Index;
                int ID = Convert.ToInt32(dgvData.Rows[i].Cells["ColID"].Value.ToString());

                dp.MyExecuteNonQuery("delete from ChiNhanh where ID = " + ID);
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

        private void dgvData_CurrentCellChanged(object sender, EventArgs e)
        {
            try {
                if (dgvData.Rows.Count < 1 || dgvData.CurrentCellAddress.Y < 0) return;

                int i = dgvData.CurrentRow.Index;

                txtMa.Text = dgvData.Rows[i].Cells["ColMa"].Value.ToString();
                txtTen.Text = dgvData.Rows[i].Cells["ColTen"].Value.ToString();
                txtSDT.Text = dgvData.Rows[i].Cells["ColSDT"].Value.ToString();
                txtFAX.Text = dgvData.Rows[i].Cells["ColFAX"].Value.ToString();
                txtDiaChi.Text = dgvData.Rows[i].Cells["ColDiaChi"].Value.ToString();
                txtKhuVuc.Text = dgvData.Rows[i].Cells["ColKhuVuc"].Value.ToString();
               
            }
            catch (Exception ex) {
                ClearText();
            }        
        }

        private void ClearText() {
            txtMa.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtFAX.Text = "";
            txtDiaChi.Text = "";
            txtKhuVuc.Text = "";         
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            txtMa.Focus();
        }
    }
}
