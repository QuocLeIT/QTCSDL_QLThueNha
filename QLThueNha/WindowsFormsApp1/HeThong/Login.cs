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

namespace QLThueNha.HeThong
{
    public partial class Login : Form
    {
        DataProvider dp = new DataProvider();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "") {
                MessageBox.Show("Thiếu Username, Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try {
                DataTable tb;

                if (rbtnNhanVien.Checked)
                {
                    //tb = dp.Fillbang("select ID, Ma, Ten, IDChiNhanh, IDChucVu from NhanVien where Username = N'" + txtUsername.Text.Trim() + "' and Pass = N'" + txtPassword.Text.Trim() + "'");

                    string[] str = new string[2];
                    object[] val = new object[2];

                    str[0] = "@username";
                    str[1] = "@pass";

                    val[0] = txtUsername.Text.Trim();
                    val[1] = txtPassword.Text.Trim();

                    //Unrepeatable read
                    if (DataAccount._fix)
                        tb = dp.ReadDataAddPram("sp_ReadLogin_NhanVien_Fix", str, val, 100);
                    else
                        tb = dp.ReadDataAddPram("sp_ReadLogin_NhanVien", str, val, 100);

                }
                else {
                    tb = dp.Fillbang(" select ID, Ma, Ten, IDChiNhanh, 3 as IDChucVu from KhachHang where Username = N'" + txtUsername.Text.Trim() + "' and Pass = N'" + txtPassword.Text.Trim() + "'");
                }

                if (tb.Columns.Count < 1) {
                    MessageBox.Show("Username, Password không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idUser = Convert.ToInt16(tb.Rows[0]["ID"].ToString());
                int idChiNhanh = Convert.ToInt16(tb.Rows[0]["IDChiNhanh"].ToString());
                int idChucVu = Convert.ToInt16(tb.Rows[0]["IDChucVu"].ToString());

                DataAccount.SetDataAccount(idUser, txtUsername.Text.Trim(), tb.Rows[0]["Ma"].ToString(), tb.Rows[0]["Ten"].ToString(), idChiNhanh, idChucVu);

                MessageBox.Show("Thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex) {
                DataAccount.ResetDataAccount();
                MessageBox.Show("Lỗi Username, Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
           
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                button1_Click(sender, e);
            }
        }

        private void chkFix_CheckedChanged(object sender, EventArgs e)
        {
            DataAccount._fix = chkFix.Checked;
        }
    }
}
