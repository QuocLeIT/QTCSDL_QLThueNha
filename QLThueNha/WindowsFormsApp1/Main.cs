using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThueNha.DanhMuc;
using QLThueNha.HeThong;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mnuChiNhanh_Click(object sender, EventArgs e)
        {
            FrmChiNhanh frm = new FrmChiNhanh();
            frm.ShowDialog();
        }

        private void mnuLoaiNhaChoTHue_Click(object sender, EventArgs e)
        {
            LoaiNha frm = new LoaiNha();
            frm.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.ShowDialog();
        }

        private void mnuKHThue_Click(object sender, EventArgs e)
        {
            FrmKhachHangThueNha frm = new FrmKhachHangThueNha();
            frm.ShowDialog();
        }

        private void mnuKHChoThue_Click(object sender, EventArgs e)
        {
            FrmChuNha frm = new FrmChuNha();
            frm.ShowDialog();
        }

        private void mnuNhaChoThue_Click(object sender, EventArgs e)
        {
            FrmNhaChoThue frm = new FrmNhaChoThue();
            frm.ShowDialog();
        }

        private void mnuDatLichXemNha_Click(object sender, EventArgs e)
        {
            FrmXemNha frm = new FrmXemNha();
            frm.ShowDialog();

        }

        private void mnuHopDong_Click(object sender, EventArgs e)
        {
            FrmHopDongThue frm = new FrmHopDongThue();
            frm.ShowDialog();
        }

        private void mnuDN_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
        }
    }
}
