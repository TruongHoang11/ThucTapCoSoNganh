using Dayone.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Dayone.GUI
{
    public partial class DangKyMon : Form
    {
        public DangKyMon()
        {
            InitializeComponent();
        }

        private void DangKyMon_Load(object sender, EventArgs e)
        {
            try
            {
                // ✅ XÓA HẾT CỘT CŨ VÀ TỰ ĐỘNG TẠO MỚI
                //dgvDangKyMon.Columns.Clear();
                //dgvDangKyMon.AutoGenerateColumns = true;

                //cmbMaSinhVien.SelectedIndexChanged -= cmbMaSinhVien_SelectedIndexChanged;

                var dtSV = BLL_SinhVien.Instance.DanhSach();
                if (dtSV != null && dtSV.Rows.Count > 0)
                {
                    cmbMaSinhVien.DataSource = dtSV;
                    cmbMaSinhVien.DisplayMember = "TenSV";
                    cmbMaSinhVien.ValueMember = "MaSV";
                }

                DataTable dt = BLL_DangKyMon.Instance.GetLopHocPhan();
                cmbMaHocPhan.DataSource = dt;
                cmbMaHocPhan.DisplayMember = "TenLopHocPhan";
                cmbMaHocPhan.ValueMember = "MaLopHocPhan";

                // LOAD TOÀN BỘ DỮ LIỆU ĐĂNG KÝ
                DataTable dtDangKy = BLL_DangKyMon.Instance.DanhSachTatCa();
                dgvDangKyMon.DataSource = dtDangKy;

                // ✅ ĐỔI TÊN CỘT SANG TIẾNG VIỆT
                //if (dgvDangKyMon.Columns.Contains("Id"))
                //    dgvDangKyMon.Columns["Id"].HeaderText = "ID";
                //if (dgvDangKyMon.Columns.Contains("MaSV"))
                //    dgvDangKyMon.Columns["MaSV"].HeaderText = "MÃ SV";
                //if (dgvDangKyMon.Columns.Contains("TenSV"))
                //    dgvDangKyMon.Columns["TenSV"].HeaderText = "TÊN SV";
                //if (dgvDangKyMon.Columns.Contains("MaLopHocPhan"))
                //    dgvDangKyMon.Columns["MaLopHocPhan"].HeaderText = "MÃ H.PHẦN";
                //if (dgvDangKyMon.Columns.Contains("TenLopHocPhan"))
                //    dgvDangKyMon.Columns["TenLopHocPhan"].HeaderText = "TÊN H.PHẦN";
                //if (dgvDangKyMon.Columns.Contains("TenMH"))
                //    dgvDangKyMon.Columns["TenMH"].HeaderText = "TÊN MH";
                //if (dgvDangKyMon.Columns.Contains("NgayDangKy"))
                //    dgvDangKyMon.Columns["NgayDangKy"].HeaderText = "NGÀY ĐĂNG KÝ";

                //dgvDangKyMon.AutoResizeColumns();
                //dgvDangKyMon.Refresh();

                //cmbMaSinhVien.SelectedIndexChanged += cmbMaSinhVien_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form:\n" + ex.Message);
            }
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                var dtDangKy = BLL_DangKyMon.Instance.DanhSachTatCa();
                dgvDangKyMon.DataSource = dtDangKy;
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

                // Load danh sách Lớp Học Phần
                var dtHP = BLL_DangKyMon.Instance.GetLopHocPhan();
                if (dtHP != null && dtHP.Rows.Count > 0)
                {
                    cmbMaHocPhan.DataSource = dtHP;
                    cmbMaHocPhan.DisplayMember = "TenLopHocPhan";
                    cmbMaHocPhan.ValueMember = "MaLopHocPhan";
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

        private void LoadDangKy()
        {
            dgvDangKyMon.DataSource = BLL_DangKyMon.Instance.DanhSachTatCa();
        }

        // ================= ĐĂNG KÝ =================
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMaSinhVien.SelectedValue == null)
                {
                    MessageBox.Show("Chưa chọn sinh viên");
                    return;
                }

                if (cmbMaHocPhan.SelectedValue == null)
                {
                    MessageBox.Show("Chưa chọn lớp học phần");
                    return;
                }

                string maSV = cmbMaSinhVien.SelectedValue.ToString();
                string maLHP = cmbMaHocPhan.SelectedValue.ToString();

                bool ok = BLL_DangKyMon.Instance.DangKy(maSV, maLHP);

                if (!ok)
                {
                    MessageBox.Show("Sinh viên đã đăng ký lớp học phần này rồi");
                    return;
                }

                MessageBox.Show("Đăng ký môn thành công");

                // ✅ Load lại danh sách đăng ký
                LoadDanhSachDangKy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi đăng ký:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void LoadDanhSachDangKy()
        {
            dgvDangKyMon.DataSource =
                BLL_DangKyMon.Instance.DanhSachTatCa();
        }

        // ================= CHỌN SV =================
        private void cmbMaSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaSinhVien.SelectedValue == null) return;
            if (cmbMaSinhVien.SelectedValue is DataRowView) return;

            string maSV = cmbMaSinhVien.SelectedValue.ToString();
            LoadDangKy();
        }

        // ================= CLICK GRID =================
        private void dgvDangKyMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var row = dgvDangKyMon.Rows[e.RowIndex];

                // ✅ Kiểm tra null cho từng cell
                txbID.Text = row.Cells[0].Value?.ToString() ?? "";

                var maSV = row.Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(maSV))
                {
                    cmbMaSinhVien.SelectedValue = maSV;
                }

                var maLHP = row.Cells[3].Value?.ToString();
                if (!string.IsNullOrEmpty(maLHP))
                {
                    cmbMaHocPhan.SelectedValue = maLHP;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dòng:\n" + ex.Message, "Lỗi");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbMaHocPhan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học phần");
                return;
            }

            string maLHP = cmbMaHocPhan.SelectedValue.ToString();

            dgvDangKyMon.DataSource =
                BLL_DangKyMon.Instance.GetSinhVienByLopHocPhan(maLHP);
        }

        private void TenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TenLop.SelectedValue != null)
            {
                string MaMH = TenLop.SelectedValue.ToString();
                // dùng maMH để đăng ký
            }


            if (TenLop.SelectedValue == null)
                return;

            string maMH = TenLop.SelectedValue.ToString();

            DataTable dtLHP = BLL_LopHocPhan.Instance.GetByMonHoc(maMH);

            cmbMaHocPhan.DataSource = dtLHP;
            cmbMaHocPhan.DisplayMember = "TenLopHocPhan";
            cmbMaHocPhan.ValueMember = "MaLopHocPhan";
            cmbMaHocPhan.SelectedIndex = -1;

        }
        private void LoadMonHoc()
        {
            TenLop.DataSource = BLL_MonHoc.Instance.DanhSach();

            TenLop.DisplayMember = "TenMH"; // HIỂN THỊ
            TenLop.ValueMember = "MaMH";  // GIÁ TRỊ THẬT (lưu DB)

            TenLop.SelectedIndex = -1; // chưa chọn gì
        }

        private void DangKyMon_Load_1(object sender, EventArgs e)
        {
            LoadMonHoc();
            // Load sinh viên
            cmbMaSinhVien.DataSource = BLL_SinhVien.Instance.DanhSach();
            cmbMaSinhVien.DisplayMember = "TenSV";
            cmbMaSinhVien.ValueMember = "MaSV";

            // Load môn học
            TenLop.DataSource = BLL_MonHoc.Instance.DanhSach();
            TenLop.DisplayMember = "TenMH";
            TenLop.ValueMember = "MaMH";

            TenLop.SelectedIndex = -1;

            // Lớp học phần rỗng ban đầu
            cmbMaHocPhan.DataSource = null;
        }

        private void cmbMaHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaHocPhan.SelectedValue == null)
                return;

            string maLHP = cmbMaHocPhan.SelectedValue.ToString();

        }
    }
}