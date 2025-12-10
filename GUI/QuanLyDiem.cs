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
        private void TinhDiemVaXepLoai()
        {
            // Nếu thiếu dữ liệu thì không tính
            if (string.IsNullOrWhiteSpace(txbDiemLop.Text) ||
                string.IsNullOrWhiteSpace(txbDiemThi.Text))
                return;

            if (!float.TryParse(txbDiemLop.Text, out float diemlop)) return;
            if (!float.TryParse(txbDiemThi.Text, out float diemthi)) return;

            int ptLop = (int)numPhanTramLop.Value;
            int ptThi = (int)numPhanTramThi.Value;

            // Tính điểm trung bình
            float diemtb = (diemlop * ptLop / 100f) + (diemthi * ptThi / 100f);
            diemtb = (float)Math.Round(diemtb, 2);

            // Gán vào textbox
            txbDiemTB.Text = diemtb.ToString("0.00");

            // Xếp loại
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
                // Load dữ liệu cho ComboBox Loại
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
                //numPhanTramLop.Text = "";
                //numPhanTramThi.Text = "";
                //txbDiemLop.Text = "";
                //txbDiemThi.Text = "";
                //txbDiemTB.Text = "";
                //cmbLoai.SelectedIndex = -1;
                // Load bảng điểm
                var dtDiem = BLL_Diem.Instance.DanhSach();
                dgvQuanLyDiem.DataSource = dtDiem;
                // Format hiển thị cột điểm
                if (dgvQuanLyDiem.Columns.Contains("DiemLop"))
                    dgvQuanLyDiem.Columns["DiemLop"].DefaultCellStyle.Format = "0.00";

                if (dgvQuanLyDiem.Columns.Contains("DiemThi"))
                    dgvQuanLyDiem.Columns["DiemThi"].DefaultCellStyle.Format = "0.00";

                if (dgvQuanLyDiem.Columns.Contains("DiemTB"))
                    dgvQuanLyDiem.Columns["DiemTB"].DefaultCellStyle.Format = "0.00";


                // Load danh sách SinhVien
                var dtSV = BLL_SinhVien.Instance.DanhSach();
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

                // Load danh sách Môn Học
                var dtMH = BLL_MonHoc.Instance.DanhSach();
                if (dtMH != null && dtMH.Rows.Count > 0)
                {
                    cmbMaMH.DataSource = dtMH;
                    cmbMaMH.DisplayMember = "TenMH";
                    cmbMaMH.ValueMember = "MaMH";
                }
                else
                {
                    MessageBox.Show("Chưa có dữ liệu môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                // Kiểm tra điểm
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

                // Lấy giá trị sinh viên
                string masv = "";
                if (cmbMaSinhVien.SelectedValue != null)
                {
                    masv = cmbMaSinhVien.SelectedValue.ToString();
                }
                else if (cmbMaSinhVien.SelectedItem is DataRowView rowSV)
                {
                    masv = rowSV["MaSV"].ToString();
                }
                // neu SelectedBalue null, SelectedItem ko phai DataRowView
                // hoặc người dùng tự gõ vào ComboBox (không chọn từ danh sách)
                // thì sẽ lấy mà sinh viên từ chuỗi text mà người dùng nhập
                // neu nguoi dung nhap 'sv001_Nguyen Van B
                // -> tach ra thành "sv001", "Nguyen", "Van", "B"
                // RemoveEmptyEntries -> loại bỏ phần rỗng nêu chuỗi nhiều khoảng trắng
                //  [0] - lấy phần từ đầu tiên .Trim() để xoá khoangr trắng thừa
                else if (!string.IsNullOrEmpty(cmbMaSinhVien.Text))
                {
                    masv = cmbMaSinhVien.Text.Split(new[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                }

                // Lấy giá trị môn học
                string mamh = "";
                if (cmbMaMH.SelectedValue != null)
                {
                    mamh = cmbMaMH.SelectedValue.ToString();
                }
                else if (cmbMaMH.SelectedItem is DataRowView rowMH)
                {
                    mamh = rowMH["MaMH"].ToString();
                }
                else if (!string.IsNullOrEmpty(cmbMaMH.Text))
                {
                    mamh = cmbMaMH.Text.Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                }

                // Kiểm tra đã lấy được mã chưa
                if (string.IsNullOrEmpty(masv))
                {
                    MessageBox.Show("Không thể lấy mã sinh viên. Vui lòng chọn lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(mamh))
                {
                    MessageBox.Show("Không thể lấy mã môn học. Vui lòng chọn lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Parse điểm
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

                // Lấy loại điểm
                string loai = "";
                if (cmbLoai.SelectedItem != null)
                {
                    loai = cmbLoai.SelectedItem.ToString();
                }
                else if (!string.IsNullOrWhiteSpace(cmbLoai.Text))
                {
                    loai = cmbLoai.Text.Trim();
                }


                int nam = DateTime.Now.Year;

                // Gọi BLL để thêm
                bool ok = BLL_Diem.Instance.Them(masv, mamh, phantramlop, phantramthi, diemlop, diemthi, diemtb, loai, nam);

                if (ok)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTaiLai.PerformClick();

                    // Clear form
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

                // Lấy giá trị an toàn
                string masv = "";
                string mamh = "";

                if (cmbMaSinhVien.SelectedValue != null)
                {
                    masv = cmbMaSinhVien.SelectedValue.ToString();
                }
                else if (cmbMaSinhVien.SelectedItem is DataRowView rowSV)
                {
                    masv = rowSV["MaSV"].ToString();
                }

                if (cmbMaMH.SelectedValue != null)
                {
                    mamh = cmbMaMH.SelectedValue.ToString();
                }
                else if (cmbMaMH.SelectedItem is DataRowView rowMH)
                {
                    mamh = rowMH["MaMH"].ToString();
                }

                if (string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(mamh))
                {
                    MessageBox.Show("Không thể lấy mã sinh viên hoặc môn học", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int nam = DateTime.Now.Year;

                if (BLL_Diem.Instance.Sua(masv, mamh, phantramlop, phamtramthi, diemlop, diemthi, diemtb, loai, nam, id))
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

                txbID.Text = row.Cells[0].Value?.ToString() ?? "";
                var valMaSV = row.Cells[1].Value?.ToString();
                var valMaMH = row.Cells[2].Value?.ToString();

                if (!string.IsNullOrEmpty(valMaSV) && cmbMaSinhVien.DataSource != null)
                    cmbMaSinhVien.SelectedValue = valMaSV;

                if (!string.IsNullOrEmpty(valMaMH) && cmbMaMH.DataSource != null)
                    cmbMaMH.SelectedValue = valMaMH;

                if (row.Cells[3].Value != null)
                    numPhanTramLop.Value = Convert.ToDecimal(row.Cells[3].Value);

                if (row.Cells[4].Value != null)
                    numPhanTramThi.Value = Convert.ToDecimal(row.Cells[4].Value);

                txbDiemLop.Text = row.Cells[5].Value?.ToString() ?? "";
                txbDiemThi.Text = row.Cells[6].Value?.ToString() ?? "";
                if (row.Cells[7].Value != null)
                {
                    if (float.TryParse(row.Cells[7].Value.ToString(), out float tb))
                        txbDiemTB.Text = tb.ToString("0.00");
                    else
                        txbDiemTB.Text = "0.00";
                }

                if (row.Cells[8].Value != null)
                {
                    string loaiValue = row.Cells[8].Value.ToString().Trim();
                    int index = cmbLoai.FindStringExact(loaiValue);
                    if (index >= 0)
                        cmbLoai.SelectedIndex = index;
                    else
                        cmbLoai.Text = loaiValue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi click bảng:\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handlers không sử dụng
        private void label7_Click(object sender, EventArgs e) { }
        //private void numPhanTramThi_ValueChanged(object sender, EventArgs e) { }
        private void cmbMaSinhVien_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dgvQuanLyDiem_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e) { }
        //private void txbDiemTB_TextChanged(object sender, EventArgs e) { }
    }
}