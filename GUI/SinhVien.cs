using ClosedXML.Excel;
using Dayone.BLL;
using Dayone.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dayone.GUI
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {

            btnLamMoi.PerformClick();
        }

        string duongDanAnh = "";
        string tenAnh = "";

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            dgvSinhVien.DataSource = BLL_SinhVien.Instance.DanhSach();
            cbbMaCoVan.DataSource = BLL_CoVanHocTap.Instance.DanhSach();
            cbbMaCoVan.DisplayMember = "TenCVHT";
            cbbMaCoVan.ValueMember = "MaCVHT";
            cbbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();///Hien thi danh sach khoa len combobox
            cbbMaKhoa.DisplayMember = "TenKhoa";
            cbbMaKhoa.ValueMember = "MaKhoa";
            cbbMaLop.DataSource = BLL_Lop.Instance.DanhSach();
            cbbMaLop.DisplayMember = "TenLop";
            cbbMaLop.ValueMember = "MaLop";
            ClearForm();
        }
        private void ClearForm()
        {
            txbID.Clear();
            txbMaSV.Clear();
            txbTenSV.Clear();
            txbQueQuan.Clear();

            dtpkNgaySinh.Value = DateTime.Now;
            dtpkNhapHoc.Value = DateTime.Now;

            rbNam.Checked = false;
            rbNu.Checked = false;

            cbbMaLop.SelectedIndex = -1;
            cbbMaKhoa.SelectedIndex = -1;
            cbbMaCoVan.SelectedIndex = -1;

            dgvSinhVien.ClearSelection();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
            txbMaSV.Text = dgvSinhVien.CurrentRow.Cells[1].Value.ToString();
            txbTenSV.Text = dgvSinhVien.CurrentRow.Cells[2].Value.ToString();
            dtpkNgaySinh.Value = (DateTime)dgvSinhVien.CurrentRow.Cells[3].Value;
            if (dgvSinhVien.CurrentRow.Cells[4].Value.ToString().Trim() == "Nam")
                rbNam.Checked = true;
            else
                rbNu.Checked = true;
            txbQueQuan.Text = dgvSinhVien.CurrentRow.Cells[5].Value.ToString();
            dtpkNhapHoc.Value = (DateTime)dgvSinhVien.CurrentRow.Cells[6].Value;
            cbbMaLop.SelectedValue = dgvSinhVien.CurrentRow.Cells[7].Value.ToString();
            cbbMaKhoa.SelectedValue = dgvSinhVien.CurrentRow.Cells[8].Value.ToString();
            cbbMaCoVan.SelectedValue = dgvSinhVien.CurrentRow.Cells[9].Value.ToString();

            //Chon anh
            //string anh = dgvSinhVien.CurrentRow.Cells[10].Value?.ToString().Trim();


            //if (!string.IsNullOrEmpty(anh))
            //{
            //    string path = Application.StartupPath + @"\Images\SinhVien\" + anh;

            //    if (File.Exists(path))
            //    {
            //        if (picAnh.Image != null)
            //        {
            //            picAnh.Image.Dispose();
            //            picAnh.Image = null;
            //        }
            //        LoadImage(path);
            //    }

            //    else
            //        picAnh.Image = null;
            //}

            string anh = dgvSinhVien.CurrentRow.Cells[10].Value?.ToString() ?? "";

            // xử lý sạch chuỗi
            anh = anh.Trim()
                     .Replace("\"", "")
                     .Replace("\n", "")
                     .Replace("\r", "");

            // nếu rỗng → clear
            if (string.IsNullOrWhiteSpace(anh))
            {
                ShowImage(null);
                return;
            }

            // full path hay file name?
            string fullPath = anh;

            // nếu không phải root path → coi như tên file
            if (!Path.IsPathRooted(anh))
                fullPath = Path.Combine(Application.StartupPath, @"Images\SinhVien", anh);

            // debug thử
            // MessageBox.Show(fullPath);

            // nếu file tồn tại → show
            if (File.Exists(fullPath))
                ShowImage(fullPath);
            else
                ShowImage(null);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbMaSV.Text))
                    throw new Exception("Mã sinh viên không được để trống.");

                if (string.IsNullOrWhiteSpace(txbTenSV.Text))
                    throw new Exception("Tên sinh viên không được để trống.");

                if (string.IsNullOrWhiteSpace(txbQueQuan.Text))
                    throw new Exception("Quê quán không được để trống.");

                if (cbbMaLop.SelectedValue == null)
                    throw new Exception("Vui lòng chọn mã lớp.");

                if (cbbMaKhoa.SelectedValue == null)
                    throw new Exception("Vui lòng chọn mã khoa.");

                if (cbbMaCoVan.SelectedValue == null)
                    throw new Exception("Vui lòng chọn mã cố vấn.");

                string masv = txbMaSV.Text.Trim();
                string tensv = txbTenSV.Text.Trim();
                string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
                string gioitinh = rbNam.Checked ? "Nam" : "Nữ";
                string quequan = txbQueQuan.Text.Trim();
                string ngaynhaphoc = dtpkNhapHoc.Value.ToShortDateString();
                string malop = cbbMaLop.SelectedValue.ToString();
                string makhoa = cbbMaKhoa.SelectedValue.ToString();
                string macvht = cbbMaCoVan.SelectedValue.ToString();

                if (!string.IsNullOrEmpty(duongDanAnh))
                {
                    string folder = Application.StartupPath + @"\Images\SinhVien\";

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    File.Copy(duongDanAnh, folder + tenAnh, true);
                }

                bool kq = BLL_SinhVien.Instance.Them(masv, tensv, ngaysinh, gioitinh, quequan, ngaynhaphoc, malop, makhoa, macvht, tenAnh);

                if (kq)
                {
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    throw new Exception("Không thể thêm sinh viên. Có thể mã sinh viên đã tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                // ==== KIỂM TRA THIẾU DỮ LIỆU ====

                if (string.IsNullOrWhiteSpace(txbID.Text))
                {
                    MessageBox.Show("ID không được để trống!");
                    txbID.Focus();
                    return;
                }

                if (!int.TryParse(txbID.Text, out int id))
                {
                    MessageBox.Show("ID phải là số!");
                    txbID.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbMaSV.Text))
                {
                    MessageBox.Show("Mã sinh viên không được để trống!");
                    txbMaSV.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbTenSV.Text))
                {
                    MessageBox.Show("Tên sinh viên không được để trống!");
                    txbTenSV.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbQueQuan.Text))
                {
                    MessageBox.Show("Quê quán không được để trống!");
                    txbQueQuan.Focus();
                    return;
                }

                if (cbbMaLop.SelectedValue == null)
                {
                    MessageBox.Show("Chưa chọn Mã lớp!");
                    cbbMaLop.Focus();
                    return;
                }

                if (cbbMaKhoa.SelectedValue == null)
                {
                    MessageBox.Show("Chưa chọn Mã khoa!");
                    cbbMaKhoa.Focus();
                    return;
                }

                if (cbbMaCoVan.SelectedValue == null)
                {
                    MessageBox.Show("Chưa chọn Cố vấn!");
                    cbbMaCoVan.Focus();
                    return;
                }

                // ==== LẤY GIÁ TRỊ ====
                string masv = txbMaSV.Text.Trim();
                string tensv = txbTenSV.Text.Trim();
                string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
                string gioitinh = rbNam.Checked ? "Nam" : "Nữ";
                string quequan = txbQueQuan.Text.Trim();
                string ngaynhaphoc = dtpkNhapHoc.Value.ToShortDateString();
                string malop = cbbMaLop.SelectedValue.ToString();
                string makhoa = cbbMaKhoa.SelectedValue.ToString();
                string macovan = cbbMaCoVan.SelectedValue.ToString();
                string anh;

                if (!string.IsNullOrEmpty(tenAnh))
                {
                    anh = tenAnh;

                }
                else
                {
                    // Lấy ảnh cũ từ DataGridView
                    anh = dgvSinhVien.CurrentRow.Cells["Anh"].Value?.ToString();

                    if (anh == "\"\"" || string.IsNullOrWhiteSpace(anh))
                        anh = ""; // hoặc NULL
                }

                // ==== GỌI BLL ====
                bool result = BLL_SinhVien.Instance.Sua(
                    masv, tensv, ngaysinh, gioitinh, quequan,
                    ngaynhaphoc, malop, makhoa, macovan, anh, id
                );

                if (result)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    btnLamMoi.PerformClick();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Sai định dạng dữ liệu!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Thiếu dữ liệu hoặc chưa chọn dòng trong bảng!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }

            // Nếu đã chọn ảnh mới
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbID.Text))
                    throw new Exception("Vui lòng chọn sinh viên cần xoá.");

                int id;
                if (!int.TryParse(txbID.Text, out id))
                    throw new Exception("ID sinh viên không hợp lệ.");

                DialogResult dr = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xoá sinh viên có ID: {id}?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dr != DialogResult.Yes)
                    return;

                bool kq = BLL_SinhVien.Instance.Xoa(id);

                if (kq)
                {
                    MessageBox.Show("Xoá sinh viên thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadSinhVien();
                }
                else
                {
                    throw new Exception("Không thể xoá sinh viên. Có thể đang tồn tại dữ liệu liên quan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không thể xoá sinh viên. Có thể đang tồn tại dữ liệu liên quan",
                    "Lỗi xoá sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = txbMaSV.Text.Trim();
                string tensv = txbTenSV.Text.Trim();
                string quequan = txbQueQuan.Text.Trim();

                string malop = cbbMaLop.SelectedValue == null
                    ? null
                    : cbbMaLop.SelectedValue.ToString();

                string makhoa = cbbMaKhoa.SelectedValue == null
                    ? null
                    : cbbMaKhoa.SelectedValue.ToString();

                string macvht = cbbMaCoVan.SelectedValue == null
                    ? null
                    : cbbMaCoVan.SelectedValue.ToString();

                // ❗ Kiểm tra nếu TẤT CẢ điều kiện đều rỗng
                if (string.IsNullOrWhiteSpace(masv) &&
                    string.IsNullOrWhiteSpace(tensv) &&
                    string.IsNullOrWhiteSpace(quequan) &&
                    malop == null &&
                    makhoa == null &&
                    macvht == null)
                {
                    MessageBox.Show(
                        "Vui lòng nhập hoặc chọn ít nhất một điều kiện tìm kiếm!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // ❗ Gọi BLL tìm kiếm
                DataTable dt = BLL_SinhVien.Instance.TimKiem(
                    string.IsNullOrWhiteSpace(masv) ? null : masv,
                    string.IsNullOrWhiteSpace(tensv) ? null : tensv,
                    string.IsNullOrWhiteSpace(quequan) ? null : quequan,
                    malop,
                    makhoa,
                    macvht
                );

                if (dt == null)
                {
                    MessageBox.Show("Không thể tải dữ liệu tìm kiếm!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dgvSinhVien.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên phù hợp.",
                        "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadSinhVien()
        {
            try
            {
                dgvSinhVien.DataSource = BLL_SinhVien.Instance.DanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Excel Files|*.xlsx;*.xls";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    BLL_Excel bllExcel = new BLL_Excel();
                    var ketqua = bllExcel.ImportSinhVienToDatabase(of.FileName);

                    LoadSinhVien(); // reload DGV

                    string msg = $"✔ Thêm thành công: {ketqua.SuccessCount} dòng\n" +
                                 $"❌ Lỗi: {ketqua.ErrorCount} dòng\n\n";

                    if (ketqua.ErrorLines.Count > 0)
                        msg += "🔎 Chi tiết lỗi:\n" + string.Join("\n", ketqua.ErrorLines);

                    MessageBox.Show(msg, "Kết quả Import");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi import: " + ex.Message);
            }


        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSinhVien.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel File (*.xlsx)|*.xlsx";
                sfd.FileName = "DanhSachSinhVien.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("SinhVien");

                        int colExcel = 1;

                        // ===== HEADER (BỎ ID) =====
                        for (int i = 0; i < dgvSinhVien.Columns.Count; i++)
                        {
                            if (i == 0) continue; // ❌ Bỏ cột ID

                            ws.Cell(1, colExcel).Value = dgvSinhVien.Columns[i].HeaderText;
                            ws.Cell(1, colExcel).Style.Font.Bold = true;
                            colExcel++;
                        }

                        // ===== DATA (BỎ ID) =====
                        int rowExcel = 2;
                        for (int i = 0; i < dgvSinhVien.Rows.Count; i++)
                        {
                            if (dgvSinhVien.Rows[i].IsNewRow) continue;

                            colExcel = 1;
                            for (int j = 0; j < dgvSinhVien.Columns.Count; j++)
                            {
                                if (j == 0) continue; // ❌ Bỏ ID

                                ws.Cell(rowExcel, colExcel).Value =
                                    dgvSinhVien.Rows[i].Cells[j].Value?.ToString();
                                colExcel++;
                            }
                            rowExcel++;
                        }

                        ws.Columns().AdjustToContents();
                        wb.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Xuất Excel thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowImage(string path)
        {
            try
            {
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    picAnh.Image = Image.FromFile(path);
                    picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picAnh.Image = null; // hoặc ảnh mặc định
                }
            }
            catch
            {
                picAnh.Image = null;
            }
        }


        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ảnh (*.jpg;*.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                duongDanAnh = ofd.FileName;
                tenAnh = Path.GetFileName(duongDanAnh);

                if (picAnh.Image != null)
                {
                    picAnh.Image.Dispose();
                    picAnh.Image = null;
                }
                LoadImage(duongDanAnh);
                picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void LoadImage(string path)
        {
            if (!File.Exists(path))
            {
                picAnh.Image = null;
                return;
            }

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                Image img = Image.FromStream(fs);
                picAnh.Image = (Image)img.Clone(); // 🔥 DÒNG QUYẾT ĐỊNH
            }

            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLop f = new QuanLyLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }



        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinChiTiet f = new ThongTinChiTiet(
       HeThong.TENDANGNHAP,
       "********",              // hoặc để mật khẩu thật nếu bạn muốn hiển thị
       HeThong.LOAITAIKHOAN
   );
            f.ShowDialog();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan f = new QuanLyTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhoa f = new QuanLyKhoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýCốVấnHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoVanHocTap f = new CoVanHocTap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyMonHoc f = new QuanLyMonHoc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDiem f = new QuanLyDiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DoimatkhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau(HeThong.TENDANGNHAP);
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        private void đăngKýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKyMon f = new DangKyMon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýLớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LopHocPhan f = new LopHocPhan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        //private void btnXuatExcel_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (dgvSinhVien.Rows.Count == 0)
        //        {
        //            MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
        //            return;
        //        }

        //        SaveFileDialog sfd = new SaveFileDialog();
        //        sfd.Filter = "Excel File (*.xlsx)|*.xlsx";
        //        sfd.FileName = "DanhSachSinhVien.xlsx";

        //        if (sfd.ShowDialog() == DialogResult.OK)
        //        {
        //            using (XLWorkbook wb = new XLWorkbook())
        //            {
        //                var ws = wb.Worksheets.Add("SinhVien");

        //                // ===== HEADER =====
        //                for (int i = 0; i < dgvSinhVien.Columns.Count; i++)
        //                {
        //                    ws.Cell(1, i + 1).Value = dgvSinhVien.Columns[i].HeaderText;
        //                    ws.Cell(1, i + 1).Style.Font.Bold = true;
        //                }

        //                // ===== DATA =====
        //                for (int i = 0; i < dgvSinhVien.Rows.Count; i++)
        //                {
        //                    for (int j = 0; j < dgvSinhVien.Columns.Count; j++)
        //                    {
        //                        ws.Cell(i + 2, j + 1).Value =
        //                            dgvSinhVien.Rows[i].Cells[j].Value?.ToString();
        //                    }
        //                }

        //                ws.Columns().AdjustToContents();
        //                wb.SaveAs(sfd.FileName);
        //            }

        //            MessageBox.Show("Xuất Excel thành công!", "Thông báo",
        //                MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi xuất Excel:\n" + ex.Message,
        //            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //Comment trong file SinhVien


    }
}