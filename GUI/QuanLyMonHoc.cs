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
using System.Linq;

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


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maMH = txbMaMonHoc.Text.Trim();
                string tenMH = txbTenMonHoc.Text.Trim();
                int soTC = (int)numTinChi.Value;
                int tietLT = (int)numLyThuyet.Value;
                int tietTH = (int)numThucHanh.Value;

                if (string.IsNullOrWhiteSpace(maMH))
                {
                    MessageBox.Show("Vui lòng nhập mã môn học.",
                        "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(tenMH))
                {
                    MessageBox.Show("Vui lòng nhập tên môn học.",
                        "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (soTC <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0.",
                        "Sai dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tietLT < 0 || tietTH < 0)
                {
                    MessageBox.Show("Số tiết không được âm.",
                        "Sai dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var danhSach = DAL_MonHoc.Instance.DanhSach();

                bool maTonTai = danhSach
                    .AsEnumerable()
                    .Any(row => row["MaMH"].ToString().Equals(maMH, StringComparison.OrdinalIgnoreCase));

                if (maTonTai)
                {
                    MessageBox.Show("Mã môn học đã tồn tại. Vui lòng nhập mã khác.",
                        "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool ketQua = BLL_MonHoc.Instance.Them(maMH, tenMH, soTC, tietLT, tietTH);

                if (ketQua)
                {
                    MessageBox.Show("Thêm môn học thành công!",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnLamMoi.PerformClick();
                }
                else
                {
                    MessageBox.Show("Không thể thêm môn học.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm môn học.",
                    "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private string connectionString = DAL_KetNoi.Instance.ConnectionString;

        //public bool IsMaMonHocExists(string MaMH)
        //{
        //    string query = "SELECT COUNT(*) FROM MonHoc WHERE MaMH = @MaMH";
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    using (SqlCommand cmd = new SqlCommand(query, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@MaMH", MaMH);
        //        conn.Open();

        //        int count = (int)cmd.ExecuteScalar();
        //        return count > 0;   // nếu > 0 tức là đã tồn tại
        //    }
        //}

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbID.Text))
                    throw new Exception("Vui lòng chọn môn học cần sửa.");

                int Id;
                if (!int.TryParse(txbID.Text, out Id))
                    throw new Exception("ID môn học không hợp lệ.");

                string MaMH = txbMaMonHoc.Text.Trim();
                string TenMH = txbTenMonHoc.Text.Trim();
                int SoTC = (int)numTinChi.Value;
                int TietLT = (int)numLyThuyet.Value;
                int TietTH = (int)numThucHanh.Value;

                if (string.IsNullOrWhiteSpace(MaMH))
                    throw new Exception("Mã môn học không được để trống.");

                if (string.IsNullOrWhiteSpace(TenMH))
                    throw new Exception("Tên môn học không được để trống.");

                if (SoTC <= 0)
                    throw new Exception("Số tín chỉ phải lớn hơn 0.");

                if (TietLT < 0 || TietTH < 0)
                    throw new Exception("Tiết lý thuyết và thực hành không được âm.");

                DialogResult dr = MessageBox.Show(
                    $"Bạn có chắc muốn sửa thông tin môn học ID = {Id}?",
                    "Xác nhận sửa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr != DialogResult.Yes)
                    return;

                bool kq = BLL_MonHoc.Instance.Sua(MaMH, TenMH, SoTC, TietLT, TietTH, Id);

                if (kq)
                {
                    MessageBox.Show("Cập nhật môn học thành công!",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnLamMoi.PerformClick();
                }
                else
                {
                    throw new Exception("Không thể cập nhật môn học. Có thể mã môn học bị trùng hoặc xảy ra lỗi dữ liệu.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống cập nhật môn học ",
                    "Lỗi cập nhật môn học", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbID.Text))
                    throw new Exception("Vui lòng chọn môn học cần xoá.");

                int Id;
                if (!int.TryParse(txbID.Text, out Id))
                    throw new Exception("ID môn học không hợp lệ.");

                string MaMH = txbMaMonHoc.Text.Trim();

                DialogResult dr = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xoá môn học: {MaMH}?",
                    "Xác nhận xoá",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dr != DialogResult.Yes)
                    return;

                bool kq = BLL_MonHoc.Instance.Xoa(Id);

                if (kq)
                {
                    MessageBox.Show(
                        "Xoá môn học thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    btnLamMoi.PerformClick();
                }
                else
                {
                    throw new Exception("Không thể xoá môn học. Có thể đang tồn tại dữ liệu liên quan (bảng điểm...).");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Lỗi: Không thể xoá môn học. Có thể đang tồn tại dữ liệu liên quan ",
                    "Lỗi xoá môn học",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvQuanLyMonHoc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvQuanLyMonHoc.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaMonHoc.Text = dgvQuanLyMonHoc.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenMonHoc.Text = dgvQuanLyMonHoc.CurrentRow.Cells[2].Value.ToString().Trim();
            numTinChi.Value = int.Parse(dgvQuanLyMonHoc.CurrentRow.Cells[3].Value.ToString());
            numLyThuyet.Value = int.Parse(dgvQuanLyMonHoc.CurrentRow.Cells[4].Value.ToString());
            numThucHanh.Value = int.Parse(dgvQuanLyMonHoc.CurrentRow.Cells[5].Value.ToString());
        }
    }
}
