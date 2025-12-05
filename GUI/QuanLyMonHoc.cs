using Dayone.BLL;
using Dayone.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dayone.GUI
{
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvQuanLyMonHoc.DataSource = DAL_MonHoc.Instance.DanhSach();
        }

        private void dgvQuanLyMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvQuanLyMonHoc.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaMonHoc.Text = dgvQuanLyMonHoc.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenMonHoc.Text = dgvQuanLyMonHoc.CurrentRow.Cells[2].Value.ToString().Trim();
            numTinChi.Value = int.Parse(dgvQuanLyMonHoc.CurrentRow.Cells[3].Value.ToString());
            numLyThuyet.Value = int.Parse(dgvQuanLyMonHoc.CurrentRow.Cells[4].Value.ToString());
            numThucHanh.Value = int.Parse(dgvQuanLyMonHoc.CurrentRow.Cells[5].Value.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checker() == false)
                return;
            string MaMH = txbMaMonHoc.Text;
            string TenMH = txbTenMonHoc.Text;
            int SoTC = (int)numTinChi.Value;
            int TietLT = (int)numLyThuyet.Value;
            int TietTH = (int)numThucHanh.Value;


            if (BLL_MonHoc.Instance.Them(MaMH, TenMH, SoTC, TietLT, TietTH) == true)
                btnLamMoi.PerformClick();




        }

        public bool checker()
        {
            if (txbMaMonHoc.Text == "")
            {
                MessageBox.Show("bạn nhập thiếu mã môn học", "lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMaMonHoc.Focus();
                return false;
            }

            if (IsMaMonHocExists(txbMaMonHoc.Text))
            {
                MessageBox.Show("Mã môn học đã tồn tại! Vui lòng nhập mã khác",
                                "Lỗi trùng dữ liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMaMonHoc.Focus();
                return false;
            }

            if (txbTenMonHoc.Text == "")
            {
                MessageBox.Show("bạn nhận thiếu tên môn học", "lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTenMonHoc.Focus();
                return false;
            }

            return true;
        }

        private string connectionString = DAL_KetNoi.Instance.ConnectionString;

        public bool IsMaMonHocExists(string MaMH)
        {
            string query = "SELECT COUNT(*) FROM MonHoc WHERE MaMH = @MaMH";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaMH", MaMH);
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                return count > 0;   // nếu > 0 tức là đã tồn tại
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txbID.Text);
            string MaMH = txbMaMonHoc.Text;
            string TenMH = txbTenMonHoc.Text;
            int SoTC = (int)numTinChi.Value;
            int TietLT = (int)numLyThuyet.Value;
            int TietTH = (int)numThucHanh.Value;

            if (BLL_MonHoc.Instance.Sua(MaMH, TenMH, SoTC, TietLT, TietTH, Id) == true)
                btnLamMoi.PerformClick();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txbID.Text);
            string MaMH = txbMaMonHoc.Text;
            if (MessageBox.Show($"Bạn muốn xóa môn học {MaMH}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BLL_MonHoc.Instance.Xoa(Id) == true)
                    btnLamMoi.PerformClick();
            }
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
