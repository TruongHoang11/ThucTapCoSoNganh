using Dayone.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dayone.GUI
{
    public partial class CoVanHocTap : Form
    {
        public CoVanHocTap()
        {
            InitializeComponent();
        }

        private void CoVanHocTap_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public object BLL_Khoa { get; private set; }

        private void fQuanLyCoVanHocTap_Load(object sender, EventArgs e)
        {
            btnTaiLai.PerformClick();
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvCoVanHocTap.DataSource = BLL_CoVanHocTap.Instance.DanhSach();
            //cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";
            //cmbMaLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaLop.DisplayMember = "TenLop";
            cmbMaLop.ValueMember = "MaLop";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string macovan = txbMaCoVan.Text;
            string tencovan = txbTenCoVan.Text;
            string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            string malop = cmbMaLop.SelectedValue.ToString();

            if (BLL_CoVanHocTap.Instance.Them(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop) == true)
            {
                btnTaiLai.PerformClick();

            }

        }

        private void dgvCoVanHocTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvCoVanHocTap.CurrentRow.Cells[0].Value.ToString();
            txbMaCoVan.Text = dgvCoVanHocTap.CurrentRow.Cells[1].Value.ToString();
            txbTenCoVan.Text = dgvCoVanHocTap.CurrentRow.Cells[2].Value.ToString();
            dtpkNgaySinh.Value = (DateTime)dgvCoVanHocTap.CurrentRow.Cells[3].Value;
            if (dgvCoVanHocTap.CurrentRow.Cells[4].Value.ToString().Trim() == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            cmbMaLop.SelectedValue = dgvCoVanHocTap.CurrentRow.Cells[6].Value.ToString().Trim();
            cmbMaKhoa.SelectedValue = dgvCoVanHocTap.CurrentRow.Cells[5].Value.ToString().Trim();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string macovan = txbMaCoVan.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa cố vấn học tập có mã: " + macovan, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BLL_CoVanHocTap.Instance.Xoa(id) == true)
                {
                    btnTaiLai.PerformClick();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string macovan = txbMaCoVan.Text;
            string tencovan = txbTenCoVan.Text;
            string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            string malop = cmbMaLop.SelectedValue.ToString();

            if (BLL_CoVanHocTap.Instance.Sua(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop, id) == true)
            {
                btnTaiLai.PerformClick();

            }
        }
    }
}
