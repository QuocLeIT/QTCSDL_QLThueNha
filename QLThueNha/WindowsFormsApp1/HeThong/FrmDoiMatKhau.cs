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
    public partial class FrmDoiMatKhau : Form
    {
        DataProvider dp =new DataProvider();

        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassOld.Text.Trim() == "" || txtPassNew.Text.Trim() == "") {
                MessageBox.Show("Thiếu thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try {
                DataTable tb;
                tb = dp.Fillbang("select ID from NhanVien where ID = "+ DataAccount._idUser +" and Pass = N'" + txtPassOld.Text.Trim() + "'");

                if (tb.Rows.Count < 1) {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dp.MyExecuteNonQuery("update NhanVien set Pass = N'"+ txtPassNew.Text.Trim() +"' where ID = " + DataAccount._idUser);
                DataAccount.ResetDataAccount();
                MessageBox.Show("Thành công, vui lòng đăng nhập lại...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
