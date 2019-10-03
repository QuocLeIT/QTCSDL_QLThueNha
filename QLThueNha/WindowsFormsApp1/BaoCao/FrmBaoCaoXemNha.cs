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

namespace QLThueNha.BaoCao
{
    public partial class FrmBaoCaoXemNha : Form
    {
        DataProvider dp = new DataProvider();
        DataTable ta_Data = new DataTable();
        DataTable ta_NhaXem = new DataTable();

        public FrmBaoCaoXemNha()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoXemNha_Load(object sender, EventArgs e)
        {
            LoadCboChiNhanh();
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
            string[] str = new string[3];
            object[] val = new object[3];

            str[0] = "@tuNgay";
            str[1] = "@denNgay";
            str[2] = "@idChiNhanh";

            val[0] = dtpTuNgay.Value.Date;
            val[1] = dtpDenNgay.Value.Date;
            val[2] = cboChiNhanh.SelectedValue;

            //Unrepeatable read
            if (DataAccount._fix)
                ta_Data = dp.ReadDataAddPram("sp_Read_BaoCaoXemNha_Fix", str, val, 100);
            else
                ta_Data = dp.ReadDataAddPram("sp_Read_BaoCaoXemNha", str, val, 100);

            //ta_Data = dp.Fillbang("select xn.ID, kh.Ten as KhachHang, nv.Ten as NhanVien, nct.DiaChi, xn.ThoiGianXem, xn.NhanSet, cn.Ten as ChiNhanh, xn.IDKH as IDKhachHang, xn.IDNV as IDNhanVien, xn.IDNhaThue, nct.IDChiNhanh from XemNha as xn inner join KhachHang as kh on xn.IDKH = kh.ID inner join NhanVien as nv on xn.IDNV = nv.ID inner join NhaChoThue as nct on xn.IDNhaThue = nct.ID inner join ChiNhanh as cn on nct.IDChiNhanh = cn.ID order by xn.ID");
            dgvData.DataSource = ta_Data;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Ngày không đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadData();
        }
       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
