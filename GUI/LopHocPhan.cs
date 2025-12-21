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
    public partial class LopHocPhan : Form
    {
        public LopHocPhan()
        {
            InitializeComponent();
        }

        private void QuanLyLop_Load(object sender, EventArgs e)
        {
            btnTaiLai.PerformClick();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                // Load danh sách lớp học phần
                var dtLopHocPhan = BLL_LopHocPhan.Instance.DanhSach();
                dgvLop.DataSource = dtLopHocPhan;

                // Đặt tên cột cho DataGridView
                if (dgvLop.Columns.Count > 0) dgvLop.Columns[0].HeaderText = "ID";
                if (dgvLop.Columns.Count > 1) dgvLop.Columns[1].HeaderText = "Mã Lớp HP";
                if (dgvLop.Columns.Count > 2) dgvLop.Columns[2].HeaderText = "Tên Lớp HP";
                if (dgvLop.Columns.Count > 3) dgvLop.Columns[3].HeaderText = "Số Lượng";
                if (dgvLop.Columns.Count > 4) dgvLop.Columns[4].HeaderText = "Năm Học";
                if (dgvLop.Columns.Count > 5) dgvLop.Columns[5].HeaderText = "Mã MH";
                if (dgvLop.Columns.Count > 6) dgvLop.Columns[6].HeaderText = "Tên Môn Học";

                // Ẩn cột MaMH (cột 5) vì đã có TenMH
                if (dgvLop.Columns.Count > 5)
                    dgvLop.Columns[5].Visible = false;

                // Load danh sách môn học vào ComboBox
                var dtMonHoc = BLL_MonHoc.Instance.DanhSach();
                if (dtMonHoc != null && dtMonHoc.Rows.Count > 0)
                {
                    cmbMaMH.DataSource = dtMonHoc;
                    cmbMaMH.DisplayMember = "TenMH";
                    cmbMaMH.ValueMember = "MaMH";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string mahp = txbMaHP.Text.Trim();
                string tenhp = txbTenHP.Text.Trim();

                if (string.IsNullOrWhiteSpace(mahp))
                {
                    MessageBox.Show("Vui lòng nhập Mã Lớp Học Phần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbMaHP.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tenhp))
                {
                    MessageBox.Show("Vui lòng nhập Tên Lớp Học Phần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbTenHP.Focus();
                    return;
                }

                if (cmbMaMH.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn Môn Học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mamh = cmbMaMH.SelectedValue.ToString().Trim();
                int nam = DateTime.Now.Year;
                int soluong = (int)numSoLuong.Value;

                if (BLL_LopHocPhan.Instance.Them(mahp, mamh, tenhp, nam, soluong))
                {
                    MessageBox.Show("Thêm lớp học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTaiLai.PerformClick();

                    // Clear form
                    txbMaHP.Clear();
                    txbTenHP.Clear();
                    numSoLuong.Value = 0;
                }
                else
                {
                    MessageBox.Show("Thêm lớp học phần thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã lớp học phần đã tồn tại hoặc có lỗi:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbID.Text))
                {
                    MessageBox.Show("Vui lòng chọn lớp học phần cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(txbID.Text);
                string mahp = txbMaHP.Text.Trim();
                string tenhp = txbTenHP.Text.Trim();

                if (string.IsNullOrWhiteSpace(mahp))
                {
                    MessageBox.Show("Vui lòng nhập Mã Lớp Học Phần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbMaHP.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(tenhp))
                {
                    MessageBox.Show("Vui lòng nhập Tên Lớp Học Phần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbTenHP.Focus();
                    return;
                }

                if (cmbMaMH.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn Môn Học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mamh = cmbMaMH.SelectedValue.ToString().Trim();
                int nam = int.Parse(txbNamHoc.Text.Trim());
                int soluong = (int)numSoLuong.Value;

                if (BLL_LopHocPhan.Instance.Sua(mahp, mamh, tenhp, nam, soluong, id))
                {
                    MessageBox.Show("Sửa lớp học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTaiLai.PerformClick();
                }
                else
                {
                    MessageBox.Show("Sửa lớp học phần thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã lớp đã tồn tại hoặc có lỗi:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbID.Text))
                {
                    MessageBox.Show("Vui lòng chọn lớp học phần cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(txbID.Text);
                string tenhp = txbTenHP.Text.Trim();

                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa lớp '{tenhp}' không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BLL_LopHocPhan.Instance.Xoa(id))
                    {
                        MessageBox.Show("Xóa lớp học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnTaiLai.PerformClick();

                        // Clear form
                        txbID.Clear();
                        txbMaHP.Clear();
                        txbTenHP.Clear();
                        txbNamHoc.Clear();
                        numSoLuong.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Xóa lớp học phần thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lớp học phần đang được sử dụng!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataToForm();
        }

        // Thêm event SelectionChanged để chắc chắn hơn
        private void dgvLop_SelectionChanged(object sender, EventArgs e)
        {
            LoadDataToForm();
        }

        // Tách riêng logic load data vào form
        private void LoadDataToForm()
        {
            try
            {
                // Kiểm tra có dòng nào được chọn không
                if (dgvLop.CurrentRow == null) return;
                if (dgvLop.CurrentRow.Index < 0) return;

                DataGridViewRow row = dgvLop.CurrentRow;

                // Debug: Hiển thị số cột
                // MessageBox.Show("Số cột: " + row.Cells.Count);

                // Cột 0: Id - QUAN TRỌNG
                if (row.Cells[0].Value != null && row.Cells[0].Value != DBNull.Value)
                {
                    txbID.Text = row.Cells[0].Value.ToString().Trim();
                    // Debug
                    // MessageBox.Show("ID đã load: " + txbID.Text);
                }
                else
                {
                    txbID.Text = "";
                    return;
                }

                // Cột 1: MaLopHocPhan
                if (row.Cells[1].Value != null && row.Cells[1].Value != DBNull.Value)
                    txbMaHP.Text = row.Cells[1].Value.ToString().Trim();
                else
                    txbMaHP.Text = "";

                // Cột 2: TenLopHocPhan
                if (row.Cells[2].Value != null && row.Cells[2].Value != DBNull.Value)
                    txbTenHP.Text = row.Cells[2].Value.ToString().Trim();
                else
                    txbTenHP.Text = "";

                // Cột 3: SoLuong
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    if (int.TryParse(row.Cells[3].Value.ToString(), out int soluong))
                        numSoLuong.Value = soluong;
                    else
                        numSoLuong.Value = 0;
                }
                else
                {
                    numSoLuong.Value = 0;
                }

                // Cột 4: NamHoc
                if (row.Cells[4].Value != null && row.Cells[4].Value != DBNull.Value)
                    txbNamHoc.Text = row.Cells[4].Value.ToString().Trim();
                else
                    txbNamHoc.Text = "";

                // Cột 5: MaMH - dùng để set ComboBox
                if (row.Cells.Count > 5 && row.Cells[5].Value != null && row.Cells[5].Value != DBNull.Value)
                {
                    string mamh = row.Cells[5].Value.ToString().Trim();
                    if (cmbMaMH.DataSource != null)
                    {
                        cmbMaMH.SelectedValue = mamh;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu vào form:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Event handler trống
        }

        //private void dgvLop_SelectionChanged(object sender, EventArgs e)
        //{
        //    LoadDataToForm();
        //}
    }
}