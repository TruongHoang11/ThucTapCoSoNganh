using Dayone.BLL;
using DocumentFormat.OpenXml.Wordprocessing;
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

        private void LoadLopHocPhanByMon(string maMH)
        {
            var dt = BLL_LopHocPhan.Instance.GetLopHocPhanByMon(maMH);

            cmbMaHocPhan.DataSource = dt;
            cmbMaHocPhan.DisplayMember = "TenLopHocPhan";   // HIỆN TÊN
            cmbMaHocPhan.ValueMember = "MaLopHocPhan";    // GIỮ MÃ ĐỂ XỬ LÝ
            cmbMaHocPhan.SelectedIndex = -1;
        }

        private void TenLop_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (TenLop.SelectedValue == null)
            {
                cmbMaHocPhan.DataSource = null;
                return;
            }

            string maMH = TenLop.SelectedValue.ToString();
            LoadLopHocPhanByMon(maMH);


            //if (dgvDangKyMon.CurrentRow == null) return;

            //var r = dgvDangKyMon.CurrentRow;

            //txbID.Text = r.Cells["ID"].Value.ToString();

            //cmbMaSinhVien.SelectedValue = r.Cells["MA SV"].Value.ToString();
            //cmbMaHocPhan.SelectedValue = r.Cells["MA H.PHAN"].Value.ToString();

            //dtpkDangKy.Value = Convert.ToDateTime(r.Cells["NGAY DK"].Value);

            //if (cmbTenMon.SelectedValue != null)
            //{
            //    string MaMH = cmbTenMon.SelectedValue.ToString();
            //    // dùng maMH để đăng ký
            //}

            //if (cmbTenMon.SelectedValue == null)
            //    return;

            //string maMH = cmbTenMon.SelectedValue.ToString();

            //DataTable dtLHP = BLL_LopHocPhan.Instance.GetByMonHoc(maMH);

            //cmbMaHocPhan.DataSource = dtLHP;
            //cmbMaHocPhan.DisplayMember = "TenLopHocPhan";
            //cmbMaHocPhan.ValueMember = "MaLopHocPhan";
            //cmbMaHocPhan.SelectedIndex = -1;


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

            var dt = BLL_MonHoc.Instance.DanhSach();

            TenLop.DataSource = dt;
            TenLop.DisplayMember = "TenMH";
            TenLop.ValueMember = "MaMH";
            TenLop.SelectedIndex = -1;

            cmbMaHocPhan.DataSource = null; // ban đầu chưa chọn môn
        }
        private void LoadLopHocPhan()
        {
            var dt = BLL_LopHocPhan.Instance.DanhSach(); // bạn đang có hàm này trả DataTable

            cmbMaHocPhan.DataSource = dt;
            cmbMaHocPhan.DisplayMember = "MaLopHocPhan"; // hoặc "TenLopHocPhan" nếu có
            cmbMaHocPhan.ValueMember = "MaLopHocPhan";
            cmbMaHocPhan.SelectedIndex = -1;

            TenLop.DataSource = BLL_MonHoc.Instance.DanhSach();

            TenLop.DisplayMember = "TenMH"; // HIỂN THỊ
            TenLop.ValueMember = "MaMH";  // GIÁ TRỊ THẬT (lưu DB)

            TenLop.SelectedIndex = -1; // chưa chọn gì

        }

        private void DangKyMon_Load_1(object sender, EventArgs e)
        {
            LoadMonHoc();

            LoadLopCoDinh();
            LoadLopHocPhan();


            cmbMaHocPhan.DataSource = BLL_LopHocPhan.Instance.DanhSach();
            cmbMaHocPhan.DisplayMember = "MaLopHocPhan"; // hoặc "TenLopHocPhan" nếu có
            cmbMaHocPhan.ValueMember = "MaLopHocPhan";
            cmbMaHocPhan.SelectedIndex = -1;


            cmbLopCodinh.DataSource = BLL_Lop.Instance.GetDanhSachLop();
            cmbLopCodinh.DisplayMember = "TenLop";
            cmbLopCodinh.ValueMember = "MaLop";
            cmbLopCodinh.SelectedIndex = -1;




            // Load sinh viên
            cmbMaSinhVien.DataSource = BLL_SinhVien.Instance.DanhSach();
            cmbMaSinhVien.DisplayMember = "TenSV";
            cmbMaSinhVien.ValueMember = "MaSV";

            // Load môn học
            TenLop.DataSource = BLL_MonHoc.Instance.DanhSach();
            TenLop.DisplayMember = "TenMH";
            TenLop.ValueMember = "MaMH";


            cmbTenMon.DataSource = BLL_MonHoc.Instance.DanhSach();
            cmbTenMon.DisplayMember = "TenMH";
            cmbTenMon.ValueMember = "MaMH";

            TenLop.SelectedIndex = -1;

            // Lớp học phần rỗng ban đầu
            cmbMaHocPhan.DataSource = null;

            TenLop.SelectedIndexChanged += TenLop_SelectedIndexChanged;

            cmbTenMon.SelectedIndexChanged += TenLop_SelectedIndexChanged;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbID.Text))
            {
                MessageBox.Show("Chưa chọn dòng để sửa");
                return;
            }

            int id = int.Parse(txbID.Text);
            string maSV = cmbMaSinhVien.SelectedValue.ToString();
            string maLHP = cmbMaHocPhan.SelectedValue.ToString();
            DateTime ngayDK = dtpkDangKy.Value;

            bool ok = BLL_DangKyMon.Instance.Sua(id, maSV, maLHP, ngayDK);

            if (ok)
            {
                MessageBox.Show("Sửa thành công");
                dgvDangKyMon.DataSource = BLL_DangKyMon.Instance.DanhSachTatCa();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDangKyMon.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn dòng để xóa");
                return;
            }

            int id = Convert.ToInt32(dgvDangKyMon.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Bạn có chắc muốn xóa?",
                "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BLL_DangKyMon.Instance.Xoa(id))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvDangKyMon.DataSource = BLL_DangKyMon.Instance.DanhSachTatCa();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }

        }
        private void LoadLopCoDinh()
        {
            cmbLopCodinh.DataSource = BLL_Lop.Instance.GetDanhSachLop();
            cmbLopCodinh.DisplayMember = "TenLop";
            cmbLopCodinh.ValueMember = "MaLop";
            cmbLopCodinh.SelectedIndex = -1;
        }


        private void cmbLopCodinh_SelectedIndexChanged(object sender, EventArgs e)
        {       



            if (cmbLopCodinh.SelectedIndex == -1) return;

            string maLop = cmbLopCodinh.SelectedValue.ToString();

            cmbMaSinhVien.DataSource =
                BLL_SinhVien.Instance.GetSinhVienTheoLop(maLop);

            cmbMaSinhVien.DisplayMember = "TenSV";
            cmbMaSinhVien.ValueMember = "MaSV";
            cmbMaSinhVien.SelectedIndex = -1;
        }

        private void dgvDangKyMon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDangKyMon.CurrentRow == null) return;

            var a = dgvDangKyMon.CurrentRow;

            txbID.Text = a.Cells[0].Value?.ToString();               // ID
            cmbMaSinhVien.SelectedValue = a.Cells[1].Value?.ToString(); // MaSV
            cmbMaHocPhan.SelectedValue = a.Cells[3].Value?.ToString(); // MaLHP


            if (DateTime.TryParse(a.Cells[6].Value?.ToString(), out DateTime ngayDK))
                dtpkDangKy.Value = ngayDK;
        }

        private void cmbMaHocPhan_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}