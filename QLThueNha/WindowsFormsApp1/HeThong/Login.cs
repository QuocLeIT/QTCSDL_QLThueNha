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
                tb = dp.Fillbang("select ID, Ma, Ten, IDChiNhanh, IDChucVu from NhanVien where Username = N'" + txtUsername.Text.Trim() + "' and Pass = N'" + txtPassword.Text.Trim() + "'");

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
    }
}
