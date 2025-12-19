using Dayone.BLL;
using Dayone.DAL;
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
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            ////if(HeThong.LOAITAIKHOAN!="Quản trị")
            ////    btnQuanLy.Visible=false;
            ////else
            ////    btnQuanLy.Visible = true;
            LoadSinhVien();
            //btnLamMoi.PerformClick();
            var loai = (HeThong.LOAITAIKHOAN ?? "").Trim();

            // Debug xem form nhận được gì
            // MessageBox.Show("Form SinhVien nhận: '" + loai + "'");

            btnQuanLy.Visible = loai.Equals("Quản trị", StringComparison.OrdinalIgnoreCase);

            //if (HeThong.LOAITAIKHOAN != "Quản trị")
            //    btnQuanly.Visible = false;
            //else
            //    btnQuanly.Visible = true;
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLop f = new QuanLyLop();
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

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Load SinhVien
                var dsSV = BLL_SinhVien.Instance.DanhSach();
                dgvSinhVien.DataSource = dsSV ?? throw new Exception("Không tải được danh sách sinh viên");

                // Load Lớp
                var dsLop = BLL_Lop.Instance.DanhSach();
                if (dsLop == null)
                    throw new Exception("Không tải được danh sách lớp");

                cbbMaLop.DataSource = dsLop;
                cbbMaLop.DisplayMember = "TenLop";
                cbbMaLop.ValueMember = "MaLop";

                // Load Khoa
                var dsKhoa = BLL_Khoa.Instance.DanhSach();
                if (dsKhoa == null)
                    throw new Exception("Không tải được danh sách khoa");

                cbbMaKhoa.DataSource = dsKhoa;
                cbbMaKhoa.DisplayMember = "TenKhoa";
                cbbMaKhoa.ValueMember = "MaKhoa";

                // Load Cố Vấn
                var dsCoVan = BLL_CoVanHocTap.Instance.DanhSach();
                if (dsCoVan == null)
                    throw new Exception("Không tải được danh sách cố vấn");

                cbbMaCoVan.DataSource = dsCoVan;
                cbbMaCoVan.DisplayMember = "TenCVHT";
                cbbMaCoVan.ValueMember = "MaCVHT";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu:\n" + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                rbNu.Checked = false;
            txbQueQuan.Text = dgvSinhVien.CurrentRow.Cells[5].Value.ToString();
            dtpkNhapHoc.Value = (DateTime)dgvSinhVien.CurrentRow.Cells[6].Value;
            cbbMaLop.SelectedValue = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
            cbbMaKhoa.SelectedValue = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
            cbbMaCoVan.SelectedValue = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
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
                DateTime ngaysinh = dtpkNgaySinh.Value;
                string gioitinh = rbNam.Checked ? "Nam" : "Nữ";
                string quequan = txbQueQuan.Text.Trim();
                DateTime ngaynhaphoc = dtpkNhapHoc.Value;
                string malop = cbbMaLop.SelectedValue.ToString();
                string makhoa = cbbMaKhoa.SelectedValue.ToString();
                string macvht = cbbMaCoVan.SelectedValue.ToString();

                bool kq = BLL_SinhVien.Instance.Them(masv, tensv, ngaysinh, gioitinh, quequan, ngaynhaphoc, malop, makhoa, macvht);

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
                if (string.IsNullOrWhiteSpace(txbID.Text))
                    throw new Exception("Không xác định được ID sinh viên cần sửa.");

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
                DateTime ngaysinh = dtpkNgaySinh.Value;
                string gioitinh = rbNam.Checked ? "Nam" : "Nữ";
                string quequan = txbQueQuan.Text.Trim();
                DateTime ngaynhaphoc = dtpkNhapHoc.Value;
                string malop = cbbMaLop.SelectedValue.ToString();
                string makhoa = cbbMaKhoa.SelectedValue.ToString();
                string macvht = cbbMaCoVan.SelectedValue.ToString();

                int id = int.Parse(txbID.Text);

                bool kq = BLL_SinhVien.Instance.Sua(masv, tensv, ngaysinh, gioitinh, quequan, ngaynhaphoc, malop, makhoa, macvht, id);

                if (kq)
                {
                    MessageBox.Show("Sửa sinh viên thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadSinhVien();
                }
                else
                {
                    throw new Exception("Không sửa được sinh viên. Có thể mã sinh viên bị trùng hoặc dữ liệu không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = txbMaSV.Text.Trim();
                string tensv = txbTenSV.Text.Trim();

                // ❗ Kiểm tra nếu tất cả ô tìm kiếm rỗng
                if (string.IsNullOrWhiteSpace(masv) &&
                    string.IsNullOrWhiteSpace(tensv))
                {
                    MessageBox.Show(
                        "Vui lòng nhập ít nhất một thông tin để tìm kiếm!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // ❗ Gọi BLL tìm kiếm (nếu bỏ trống giá trị nào thì truyền null)
                DataTable dt = BLL_SinhVien.Instance.TimKiem(
                    string.IsNullOrWhiteSpace(masv) ? null : masv,
                    string.IsNullOrWhiteSpace(tensv) ? null : tensv
                );

                // ❗ Kiểm tra kết quả null
                if (dt == null)
                {
                    MessageBox.Show("Không thể tải dữ liệu tìm kiếm!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dgvSinhVien.DataSource = dt;

                // ❗ Không tìm thấy sinh viên
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
           
                //    OpenFileDialog of = new OpenFileDialog();
                //    of.Filter = "Excel Files|*.xlsx;*.xls";
                //    if (of.ShowDialog() == DialogResult.OK)
                //    {
                //        BLL_Excel bllExcel = new BLL_Excel();
                //        bool kq = bllExcel.ImportSinhVienToDatabase(of.FileName);

                //        if (kq)
                //        {
                //            MessageBox.Show("Import thành công!", "Thông báo",
                //                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //            LoadSinhVien(); // load lại DGV
                //        }
                //        else
                //        {
                //            MessageBox.Show("Một số dòng không thêm được!", "Cảnh báo",
                //                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //            LoadSinhVien();
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Lỗi import: " + ex.Message,
                //        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
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
    }
}