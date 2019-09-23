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
    public partial class LoaiNha : Form
    {
        DataProvider dp = new DataProvider();
        DataTable ta_Data = new DataTable();
      

        public LoaiNha()
        {
            InitializeComponent();
        }

        private void LoaiNha_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMa.Focus();
            this.dgvData.CurrentCellChanged += new System.EventHandler(this.dgvData_CurrentCellChanged);
        }

        private void LoadData()
        {
            ta_Data = dp.Fillbang("select ID, Ma, Ten from LoaiNha order by Ten");
            dgvData.DataSource = ta_Data;
        }

        private void dgvData_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                //if (dgvData.Rows.Count < 2 || dgvData.CurrentCellAddress.Y < 0) return;
                if ( dgvData.CurrentRow.Index == dgvData.Rows.Count - 1)
                {
                    ClearText();
                    return;
                }

                int i = dgvData.CurrentRow.Index;

                txtMa.Text = dgvData.Rows[i].Cells["ColMa"].Value.ToString();
                txtTen.Text = dgvData.Rows[i].Cells["ColTen"].Value.ToString();
                
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
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool ThieuDuLieu()
        {
            if (txtMa.Text.Trim() == "" || txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Thiếu dữ liệu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ThieuDuLieu()) return;

            try
            {
                dp.MyExecuteNonQuery("insert into LoaiNha(Ma, Ten)values(N'" + txtMa.Text.Trim() + "', N'" + txtTen.Text.Trim() + "')");
                LoadData();
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi, Vui lòng kiểm tra lại...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 2 || dgvData.CurrentCellAddress.Y < 0) return;
            if (dgvData.CurrentRow.Index == dgvData.Rows.Count - 1) return;
            if (ThieuDuLieu()) return;

            try
            {
                int i = dgvData.CurrentRow.Index;
                int ID = Convert.ToInt32(dgvData.Rows[i].Cells["ColID"].Value.ToString());

                dp.MyExecuteNonQuery("update LoaiNha set Ma = N'" + txtMa.Text.Trim() + "', Ten = N'" + txtTen.Text.Trim() + "' where ID = " + ID);
                ClearText();

                LoadData();
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi, Vui lòng kiểm tra lại...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 2 || dgvData.CurrentCellAddress.Y < 0) return;
            if (dgvData.CurrentRow.Index == dgvData.Rows.Count - 1) return;

            if (MessageBox.Show("Xác nhận xóa?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;

            try
            {
                int i = dgvData.CurrentRow.Index;
                int ID = Convert.ToInt32(dgvData.Rows[i].Cells["ColID"].Value.ToString());

                dp.MyExecuteNonQuery("delete from LoaiNha where ID = " + ID);
                ClearText();

                LoadData();
                MessageBox.Show("Thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi, Vui lòng kiểm tra lại...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
