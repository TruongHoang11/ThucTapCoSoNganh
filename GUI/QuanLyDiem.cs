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
        // Biến lưu trạng thái lọc
        private string maLopHocPhanDangLoc = "";

        public QuanLyDiem()
        {
            InitializeComponent();
        }

        private void TinhDiemVaXepLoai()
        {
            if (string.IsNullOrWhiteSpace(txbDiemLop.Text) ||
                string.IsNullOrWhiteSpace(txbDiemThi.Text))
                return;

            if (!float.TryParse(txbDiemLop.Text, out float diemlop)) return;
            if (!float.TryParse(txbDiemThi.Text, out float diemthi)) return;

            int ptLop = (int)numPhanTramLop.Value;
            int ptThi = (int)numPhanTramThi.Value;

            float diemtb = (diemlop * ptLop / 100f) + (diemthi * ptThi / 100f);
            diemtb = (float)Math.Round(diemtb, 2);

            txbDiemTB.Text = diemtb.ToString("0.00");

            string loai;
            if (diemtb >= 8.5) loai = "A";
            else if (diemtb >= 7.7) loai = "B+";
            else if (diemtb >= 7) loai = "B";
            else if (diemtb >= 6.2) loai = "C+";
            else if (diemtb >= 5.5) loai = "C";
            else if (diemtb >= 4.7) loai = "D+";
            else if (diemtb >= 4) loai = "D";
            else loai = "F";

            cmbLoai.Text = loai;
        }

        private void QuanLyDiem_Load(object sender, EventArgs e)
        {
            try
            {
                cmbLoai.Items.Clear();
                cmbLoai.Items.AddRange(new string[] { "A", "B+", "B", "C+", "C", "D+", "D", "F" });
                if (cmbLoai.Items.Count > 0)
                    cmbLoai.SelectedIndex = -1;

                btnTaiLai.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load form:\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                // Load bảng điểm - Kiểm tra có đang lọc không
                DataTable dtDiem;
                if (!string.IsNullOrEmpty(maLopHocPhanDangLoc))
                {
                    dtDiem = BLL_Diem.Instance.LayDiemTheoLopHocPhan(maLopHocPhanDangLoc);
                }
                else
                {
                    dtDiem = BLL_Diem.Instance.DanhSach();
                }
                dgvQuanLyDiem.DataSource = dtDiem;

                if (dgvQuanLyDiem.Columns.Count > 0) dgvQuanLyDiem.Columns[0].HeaderText = "ID";
                if (dgvQuanLyDiem.Columns.Count > 1) dgvQuanLyDiem.Columns[1].HeaderText = "Mã SV";
                if (dgvQuanLyDiem.Columns.Count > 2) dgvQuanLyDiem.Columns[2].HeaderText = "Tên Sinh Viên";
                if (dgvQuanLyDiem.Columns.Count > 3) dgvQuanLyDiem.Columns[3].HeaderText = "Mã Lớp HP";
                if (dgvQuanLyDiem.Columns.Count > 4) dgvQuanLyDiem.Columns[4].HeaderText = "Tên Lớp HP";
                if (dgvQuanLyDiem.Columns.Count > 5) dgvQuanLyDiem.Columns[5].HeaderText = "Tên Môn Học";
                if (dgvQuanLyDiem.Columns.Count > 6) dgvQuanLyDiem.Columns[6].HeaderText = "PT Lớp (%)";
                if (dgvQuanLyDiem.Columns.Count > 7) dgvQuanLyDiem.Columns[7].HeaderText = "PT Thi (%)";
                if (dgvQuanLyDiem.Columns.Count > 8)
                {
                    dgvQuanLyDiem.Columns[8].HeaderText = "Điểm Lớp";
                    dgvQuanLyDiem.Columns[8].DefaultCellStyle.Format = "0.00";
                }
                if (dgvQuanLyDiem.Columns.Count > 9)
                {
                    dgvQuanLyDiem.Columns[9].HeaderText = "Điểm Thi";
                    dgvQuanLyDiem.Columns[9].DefaultCellStyle.Format = "0.00";
                }
                if (dgvQuanLyDiem.Columns.Count > 10)
                {
                    dgvQuanLyDiem.Columns[10].HeaderText = "Điểm TB";
                    dgvQuanLyDiem.Columns[10].DefaultCellStyle.Format = "0.00";
                }
                if (dgvQuanLyDiem.Columns.Count > 11) dgvQuanLyDiem.Columns[11].HeaderText = "Xếp Loại";

                // Load danh sách SinhVien - Nếu đang lọc thì chỉ load sinh viên của lớp đó
                DataTable dtSV;
                if (!string.IsNullOrEmpty(maLopHocPhanDangLoc))
                {
                    dtSV = BLL_Diem.Instance.LaySinhVienTheoLopHocPhan(maLopHocPhanDangLoc);
                }
                else
                {
                    dtSV = BLL_SinhVien.Instance.DanhSach();
                }

                if (dtSV != null && dtSV.Rows.Count > 0)
                {
                    cmbMaSinhVien.DataSource = dtSV;
                    cmbMaSinhVien.DisplayMember = "TenSV";
                    cmbMaSinhVien.ValueMember = "MaSV";
                }
                else
                {
                    MessageBox.Show("Chưa có dữ liệu sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Load danh sách Lớp Học Phần
                var dtHP = BLL_LopHocPhan.Instance.DanhSach();
                if (dtHP != null && dtHP.Rows.Count > 0)
                {
                    cmbMaLopHP.DataSource = dtHP;
                    cmbMaLopHP.DisplayMember = "TenLopHocPhan";
                    cmbMaLopHP.ValueMember = "MaLopHocPhan";

                    // Giữ lại lựa chọn lớp học phần đang lọc
                    if (!string.IsNullOrEmpty(maLopHocPhanDangLoc))
                    {
                        cmbMaLopHP.SelectedValue = maLopHocPhanDangLoc;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có dữ liệu lớp học phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu:\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numPhanTramLop_ValueChanged(object sender, EventArgs e)
        {
            TinhDiemVaXepLoai();
        }

        private void numPhanTramThi_ValueChanged(object sender, EventArgs e)
        {
            TinhDiemVaXepLoai();
        }

        private void txbDiemLop_TextChanged(object sender, EventArgs e)
        {
            TinhDiemVaXepLoai();
        }

        private void txbDiemThi_TextChanged(object sender, EventArgs e)
        {
            TinhDiemVaXepLoai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(numPhanTramLop.Text))
                {
                    MessageBox.Show("Phần trăm lớp không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(numPhanTramThi.Text))
                {
                    MessageBox.Show("Phần trăm thi không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txbDiemLop.Text))
                {
                    MessageBox.Show("Điểm lớp không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txbDiemThi.Text))
                {
                    MessageBox.Show("Điểm thi không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string masv = "";
                if (cmbMaSinhVien.SelectedValue != null)
                {
                    masv = cmbMaSinhVien.SelectedValue.ToString();
                }
                else if (cmbMaSinhVien.SelectedItem is DataRowView rowSV)
                {
                    masv = rowSV["MaSV"].ToString();
                }
                else if (!string.IsNullOrEmpty(cmbMaSinhVien.Text))
                {
                    masv = cmbMaSinhVien.Text.Split(new[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                }

                string mahp = "";
                if (cmbMaLopHP.SelectedValue != null)
                {
                    mahp = cmbMaLopHP.SelectedValue.ToString();
                }
                else if (cmbMaLopHP.SelectedItem is DataRowView rowMH)
                {
                    mahp = rowMH["MaLopHocPhan"].ToString();
                }
                else if (!string.IsNullOrEmpty(cmbMaLopHP.Text))
                {
                    mahp = cmbMaLopHP.Text.Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                }

                if (string.IsNullOrEmpty(masv))
                {
                    MessageBox.Show("Không thể lấy mã sinh viên. Vui lòng chọn lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(mahp))
                {
                    MessageBox.Show("Không thể lấy mã lớp học phần. Vui lòng chọn lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!BLL_Diem.Instance.KiemTraSinhVienDaDangKy(masv, mahp))
                {
                    MessageBox.Show($"Sinh viên {masv} chưa đăng ký lớp học phần này!\nVui lòng đăng ký môn học trước khi nhập điểm.",
                        "Không được phép", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int phantramlop = (int)numPhanTramLop.Value;
                int phantramthi = (int)numPhanTramThi.Value;
                TinhDiemVaXepLoai();

                if (phantramlop + phantramthi != 100)
                {
                    MessageBox.Show("Phần trăm lớp và phần trăm thi không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txbDiemLop.Text, out float diemlop) || diemlop > 10)
                {
                    MessageBox.Show("Điểm lớp không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txbDiemThi.Text, out float diemthi) || diemthi > 10)
                {
                    MessageBox.Show("Điểm thi không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txbDiemTB.Text, out float diemtb))
                {
                    MessageBox.Show("Điểm TB không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                diemtb = (float)Math.Round(diemtb, 2);

                string loai = "";
                if (cmbLoai.SelectedItem != null)
                {
                    loai = cmbLoai.SelectedItem.ToString();
                }
                else if (!string.IsNullOrWhiteSpace(cmbLoai.Text))
                {
                    loai = cmbLoai.Text.Trim();
                }

                bool ok = BLL_Diem.Instance.Them(masv, mahp, phantramlop, phantramthi, diemlop, diemthi, diemtb, loai);

                if (ok)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTaiLai.PerformClick();

                    txbDiemLop.Clear();
                    txbDiemThi.Clear();
                    txbDiemTB.Clear();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại (Kiểm tra BLL/DAL/Database)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                TinhDiemVaXepLoai();
                if (string.IsNullOrWhiteSpace(txbID.Text))
                {
                    MessageBox.Show("Chưa chọn bản ghi để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(txbID.Text);

                string masv = "";
                string mahp = "";

                if (cmbMaSinhVien.SelectedValue != null)
                {
                    masv = cmbMaSinhVien.SelectedValue.ToString();
                }
                else if (cmbMaSinhVien.SelectedItem is DataRowView rowSV)
                {
                    masv = rowSV["MaSV"].ToString();
                }

                if (cmbMaLopHP.SelectedValue != null)
                {
                    mahp = cmbMaLopHP.SelectedValue.ToString();
                }
                else if (cmbMaLopHP.SelectedItem is DataRowView rowHP)
                {
                    mahp = rowHP["MaLopHocPhan"].ToString();
                }

                if (string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(mahp))
                {
                    MessageBox.Show("Không thể lấy mã sinh viên hoặc lớp học phần", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!BLL_Diem.Instance.KiemTraSinhVienDaDangKy(masv, mahp))
                {
                    MessageBox.Show($"Sinh viên {masv} chưa đăng ký lớp học phần này!\nKhông thể sửa điểm cho sinh viên chưa đăng ký.",
                        "Không được phép", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int phantramlop = (int)numPhanTramLop.Value;
                int phamtramthi = (int)numPhanTramThi.Value;

                if (phantramlop + phamtramthi != 100)
                {
                    MessageBox.Show("Phần trăm lớp và phần trăm thi không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txbDiemLop.Text, out float diemlop) ||
                    !float.TryParse(txbDiemThi.Text, out float diemthi) ||
                    !float.TryParse(txbDiemTB.Text, out float diemtb))
                {
                    MessageBox.Show("Điểm không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (diemlop > 10)
                {
                    MessageBox.Show("Điểm lớp không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (diemthi > 10)
                {
                    MessageBox.Show("Điểm thi không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string loai = (cmbLoai.SelectedItem != null) ? cmbLoai.SelectedItem.ToString() : cmbLoai.Text.Trim();

                if (BLL_Diem.Instance.Sua(masv, mahp, phantramlop, phamtramthi, diemlop, diemthi, diemtb, loai, id))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTaiLai.PerformClick();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa:\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbID.Text))
                {
                    MessageBox.Show("Chưa chọn bản ghi để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(txbID.Text);

                if (MessageBox.Show($"Bạn có muốn xoá điểm có ID: {id}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BLL_Diem.Instance.Xoa(id))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnTaiLai.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa:\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvQuanLyDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (dgvQuanLyDiem.CurrentRow == null) return;

                var row = dgvQuanLyDiem.CurrentRow;

                if (row.Cells[0].Value != null)
                    txbID.Text = row.Cells[0].Value.ToString();

                var valMaSV = row.Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(valMaSV) && cmbMaSinhVien.DataSource != null)
                    cmbMaSinhVien.SelectedValue = valMaSV;

                var valMaHP = row.Cells[3].Value?.ToString();
                if (!string.IsNullOrEmpty(valMaHP) && cmbMaLopHP.DataSource != null)
                    cmbMaLopHP.SelectedValue = valMaHP;

                if (row.Cells[6].Value != null && row.Cells[6].Value != DBNull.Value)
                {
                    if (int.TryParse(row.Cells[6].Value.ToString(), out int ptLop))
                        numPhanTramLop.Value = ptLop;
                    else
                        numPhanTramLop.Value = 0;
                }

                if (row.Cells[7].Value != null && row.Cells[7].Value != DBNull.Value)
                {
                    if (int.TryParse(row.Cells[7].Value.ToString(), out int ptThi))
                        numPhanTramThi.Value = ptThi;
                    else
                        numPhanTramThi.Value = 0;
                }

                if (row.Cells[8].Value != null && row.Cells[8].Value != DBNull.Value)
                    txbDiemLop.Text = row.Cells[8].Value.ToString();
                else
                    txbDiemLop.Text = "";

                if (row.Cells[9].Value != null && row.Cells[9].Value != DBNull.Value)
                    txbDiemThi.Text = row.Cells[9].Value.ToString();
                else
                    txbDiemThi.Text = "";

                if (row.Cells[10].Value != null && row.Cells[10].Value != DBNull.Value)
                {
                    if (float.TryParse(row.Cells[10].Value.ToString(), out float tb))
                        txbDiemTB.Text = tb.ToString("0.00");
                    else
                        txbDiemTB.Text = "0.00";
                }
                else
                {
                    txbDiemTB.Text = "0.00";
                }

                if (row.Cells[11].Value != null && row.Cells[11].Value != DBNull.Value)
                {
                    string loaiValue = row.Cells[11].Value.ToString().Trim();
                    int index = cmbLoai.FindStringExact(loaiValue);
                    if (index >= 0)
                        cmbLoai.SelectedIndex = index;
                    else
                        cmbLoai.Text = loaiValue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi click bảng:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string maLopHP = "";

                if (cmbMaLopHP.SelectedValue != null)
                {
                    maLopHP = cmbMaLopHP.SelectedValue.ToString();
                }
                else if (cmbMaLopHP.SelectedItem is DataRowView rowHP)
                {
                    maLopHP = rowHP["MaLopHocPhan"].ToString();
                }
                else if (!string.IsNullOrEmpty(cmbMaLopHP.Text))
                {
                    maLopHP = cmbMaLopHP.Text.Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                }

                if (string.IsNullOrEmpty(maLopHP))
                {
                    MessageBox.Show("Vui lòng chọn Mã Lớp Học Phần trước khi tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // LƯU TRẠNG THÁI LỌC
                maLopHocPhanDangLoc = maLopHP;

                var dtSinhVien = BLL_Diem.Instance.LaySinhVienTheoLopHocPhan(maLopHP);

                if (dtSinhVien != null && dtSinhVien.Rows.Count > 0)
                {
                    cmbMaSinhVien.DataSource = dtSinhVien;
                    cmbMaSinhVien.DisplayMember = "TenSV";
                    cmbMaSinhVien.ValueMember = "MaSV";
                }
                else
                {
                    MessageBox.Show("Không có sinh viên nào đăng ký lớp học phần này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    var dtAllSV = BLL_SinhVien.Instance.DanhSach();
                    if (dtAllSV != null)
                    {
                        cmbMaSinhVien.DataSource = dtAllSV;
                        cmbMaSinhVien.DisplayMember = "TenSV";
                        cmbMaSinhVien.ValueMember = "MaSV";
                    }
                }

                var dtDiem = BLL_Diem.Instance.LayDiemTheoLopHocPhan(maLopHP);
                dgvQuanLyDiem.DataSource = dtDiem;

                if (dgvQuanLyDiem.Columns.Count > 0) dgvQuanLyDiem.Columns[0].HeaderText = "ID";
                if (dgvQuanLyDiem.Columns.Count > 1) dgvQuanLyDiem.Columns[1].HeaderText = "Mã SV";
                if (dgvQuanLyDiem.Columns.Count > 2) dgvQuanLyDiem.Columns[2].HeaderText = "Tên Sinh Viên";
                if (dgvQuanLyDiem.Columns.Count > 3) dgvQuanLyDiem.Columns[3].HeaderText = "Mã Lớp HP";
                if (dgvQuanLyDiem.Columns.Count > 4) dgvQuanLyDiem.Columns[4].HeaderText = "Tên Lớp HP";
                if (dgvQuanLyDiem.Columns.Count > 5) dgvQuanLyDiem.Columns[5].HeaderText = "Tên Môn Học";
                if (dgvQuanLyDiem.Columns.Count > 6) dgvQuanLyDiem.Columns[6].HeaderText = "PT Lớp (%)";
                if (dgvQuanLyDiem.Columns.Count > 7) dgvQuanLyDiem.Columns[7].HeaderText = "PT Thi (%)";

                if (dgvQuanLyDiem.Columns.Count > 8)
                {
                    dgvQuanLyDiem.Columns[8].HeaderText = "Điểm Lớp";
                    dgvQuanLyDiem.Columns[8].DefaultCellStyle.Format = "0.00";
                }

                if (dgvQuanLyDiem.Columns.Count > 9)
                {
                    dgvQuanLyDiem.Columns[9].HeaderText = "Điểm Thi";
                    dgvQuanLyDiem.Columns[9].DefaultCellStyle.Format = "0.00";
                }

                if (dgvQuanLyDiem.Columns.Count > 10)
                {
                    dgvQuanLyDiem.Columns[10].HeaderText = "Điểm TB";
                    dgvQuanLyDiem.Columns[10].DefaultCellStyle.Format = "0.00";
                }

                if (dgvQuanLyDiem.Columns.Count > 11) dgvQuanLyDiem.Columns[11].HeaderText = "Xếp Loại";

                int soDiem = (dtDiem != null) ? dtDiem.Rows.Count : 0;
                MessageBox.Show($"Đã tìm thấy {dtSinhVien.Rows.Count} sinh viên và {soDiem} bản ghi điểm trong lớp học phần này!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm:\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NÚT BỎ LỌC - HỦY TÌM KIẾM VÀ HIỂN THỊ TẤT CẢ
        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa trạng thái lọc
                maLopHocPhanDangLoc = "";

                // Reload lại toàn bộ dữ liệu
                btnTaiLai.PerformClick();

                MessageBox.Show("Đã bỏ lọc và hiển thị tất cả bản ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi bỏ lọc:\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handlers không sử dụng
        private void label7_Click(object sender, EventArgs e) { }
        private void cmbMaSinhVien_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dgvQuanLyDiem_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}