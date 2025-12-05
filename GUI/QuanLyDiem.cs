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
    public partial class QuanLyDiem : Form
    {
        public QuanLyDiem()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numPhanTramThi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvQuanLyDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbDiemTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvQuanLyDiem.DataSource = BLL_Diem.Instance.DanhSach();
            //cmbMaSinhVien.DataSource = BLL_SinhVien.Instance.DanhSach();
            cmbMaSinhVien.DisplayMember = "TenSV";
            cmbMaSinhVien.ValueMember = "MaSV";
            cmbMaMH.DataSource = BLL_MonHoc.Instance.DanhSach();
            cmbMaMH.DisplayMember = "TenMH";
            cmbMaMH.ValueMember = "MaMH";
        }

        private void QuanLyDiem_Load(object sender, EventArgs e)
        {
            btnTaiLai.PerformClick();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string masv = cmbMaSinhVien.SelectedValue.ToString();
            string mamh = cmbMaMH.SelectedValue.ToString();
            int phantramlop = (int)numPhanTramLop.Value;
            int phamtramthi = (int)numPhanTramThi.Value;
            float diemlop = float.Parse(txbDiemLop.Text);
            float diemthi = float.Parse(txbDiemThi.Text);
            float diemtb = float.Parse(txbDiemTB.Text);
            string loai = cmbLoai.SelectedItem.ToString();
            int nam = DateTime.Now.Year;

            if (BLL_Diem.Instance.Them(masv, mamh, phantramlop, phamtramthi, diemlop, diemthi, diemtb, loai, nam) == true)
            {
                btnTaiLai.PerformClick();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string masv = cmbMaSinhVien.SelectedValue.ToString();
            string mamh = cmbMaMH.SelectedValue.ToString();
            int phantramlop = (int)numPhanTramLop.Value;
            int phamtramthi = (int)numPhanTramThi.Value;
            float diemlop = float.Parse(txbDiemLop.Text);
            float diemthi = float.Parse(txbDiemThi.Text);
            float diemtb = float.Parse(txbDiemTB.Text);
            string loai = cmbLoai.SelectedItem.ToString();
            int nam = DateTime.Now.Year;

            if (BLL_Diem.Instance.Sua(masv, mamh, phantramlop, phamtramthi, diemlop, diemthi, diemtb, loai, nam, id) == true)
            {
                btnTaiLai.PerformClick();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            if(MessageBox.Show($"Bạn có muốn xoá điểm có ID: {id}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BLL_Diem.Instance.Xoa(id) == true)
                    btnTaiLai.PerformClick();
            } 
        }

        private void dgvQuanLyDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvQuanLyDiem.CurrentRow.Cells[0].Value.ToString();
            cmbMaSinhVien.SelectedValue = dgvQuanLyDiem.CurrentRow.Cells[1].Value.ToString();
            cmbMaMH.SelectedValue = dgvQuanLyDiem.CurrentRow.Cells[2].Value.ToString();
            numPhanTramLop.Value = int.Parse(dgvQuanLyDiem.CurrentRow.Cells[3].Value.ToString());
            numPhanTramThi.Value = int.Parse(dgvQuanLyDiem.CurrentRow.Cells[4].Value.ToString());
            txbDiemLop.Text = dgvQuanLyDiem.CurrentRow.Cells[5].Value.ToString();
            txbDiemThi.Text = dgvQuanLyDiem.CurrentRow.Cells[6].Value.ToString();
            txbDiemTB.Text = dgvQuanLyDiem.CurrentRow.Cells[7].Value.ToString();
            cmbLoai.SelectedItem = dgvQuanLyDiem.CurrentRow.Cells[8].Value.ToString().Trim();
        }
    }
}
