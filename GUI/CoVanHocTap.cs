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
   

    public partial class CoVanHocTap : Form
    {
        public CoVanHocTap()
        {
            InitializeComponent();
        }

        private void CoVanHocTap_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private string maCoVanGoc = "";

        //public object BLL_Khoa { get; private set; }

        private void fQuanLyCoVanHocTap_Load(object sender, EventArgs e)
        {
            btnTaiLai.PerformClick();
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvCoVanHocTap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCoVanHocTap.MultiSelect = false;

            dgvCoVanHocTap.DataSource = BLL_CoVanHocTap.Instance.DanhSach();
            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";
            cmbMaLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaLop.DisplayMember = "TenLop";
            cmbMaLop.ValueMember = "MaLop";
            ClearForm();
        }
        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    string macovan = txbMaCoVan.Text;
        //    string tencovan = txbTenCoVan.Text;
        //    DateTime ngaysinh = dtpkNgaySinh.Value;
        //    string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
        //    string makhoa = cmbMaKhoa.SelectedValue.ToString();
        //    string malop = cmbMaLop.SelectedValue.ToString();

        //    if (BLL_CoVanHocTap.Instance.Them(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop) == true)
        //    {
        //        btnTaiLai.PerformClick();

        //    }

        //}

        private void dgvCoVanHocTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvCoVanHocTap.CurrentRow.Cells[0].Value.ToString().Trim();
            

            txbMaCoVan.Text = dgvCoVanHocTap.CurrentRow.Cells[1].Value.ToString();
            txbTenCoVan.Text = dgvCoVanHocTap.CurrentRow.Cells[2].Value.ToString();
            maCoVanGoc = dgvCoVanHocTap.CurrentRow.Cells[1].Value.ToString().Trim(); // ⭐ LƯU MÃ GỐC
            txbMaCoVan.Text = maCoVanGoc;
            dtpkNgaySinh.Value = (DateTime)dgvCoVanHocTap.CurrentRow.Cells[3].Value;
            if (dgvCoVanHocTap.CurrentRow.Cells[4].Value.ToString().Trim() == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            cmbMaLop.SelectedValue = dgvCoVanHocTap.CurrentRow.Cells[6].Value.ToString().Trim();
            cmbMaKhoa.SelectedValue = dgvCoVanHocTap.CurrentRow.Cells[5].Value.ToString().Trim();
        }
   





        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbMaCoVan.Text) ||
      string.IsNullOrWhiteSpace(txbTenCoVan.Text) ||
      cmbMaKhoa.SelectedValue == null ||
      cmbMaLop.SelectedValue == null ||
      (!rdNam.Checked && !rdNu.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cố vấn!",
                                "Thiếu thông tin",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string macovan = txbMaCoVan.Text;
            string tencovan = txbTenCoVan.Text;
            DateTime ngaysinh = dtpkNgaySinh.Value;
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            string malop = cmbMaLop.SelectedValue.ToString();
            if (BLL_CoVanHocTap.Instance.KiemTraTrung(macovan))
            {
                MessageBox.Show("Cố vấn này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (BLL_CoVanHocTap.Instance.Them(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop) == true)
            {
                MessageBox.Show("Thêm cố vấn thành công!");
                btnTaiLai.PerformClick();

            }
          


        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (cmbMaKhoa.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn khoa!");
                return;
            }
            // ❌ KHÔNG CHO SỬA MÃ CỐ VẤN
            if (txbMaCoVan.Text.Trim() != maCoVanGoc)
            {
                MessageBox.Show(
                    "Không thể sửa mã cố vấn này!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txbMaCoVan.Text = maCoVanGoc; // trả lại mã cũ
                return;
            }

            if (cmbMaLop.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn lớp!");
                return;
            }

            //int id = int.Parse(txbID.Text);
            if (string.IsNullOrWhiteSpace(txbID.Text))
            {
                MessageBox.Show("Bạn chưa chọn cố vấn cần sửa!");
                return;
            }

            int id;
            if (!int.TryParse(txbID.Text, out id))
            {
                MessageBox.Show("ID không hợp lệ!");
                return;
            }

            string macovan = txbMaCoVan.Text;
            string tencovan = txbTenCoVan.Text;
            DateTime ngaysinh = dtpkNgaySinh.Value;
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            string malop = cmbMaLop.SelectedValue.ToString();
            if (BLL_CoVanHocTap.Instance.KiemTraTrungKhiSua(macovan, id))
            {
                MessageBox.Show("Mã cố vấn đã tồn tại!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (BLL_CoVanHocTap.Instance.Sua(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop, id) == true)
            {
                MessageBox.Show("Cập nhật thành công!");
                btnTaiLai.PerformClick();

            }
           

        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbID.Text))
            {
                MessageBox.Show("Bạn chưa chọn cố vấn cần xóa!");
                return;
            }

            int id = int.Parse(txbID.Text);
            string macovan = txbMaCoVan.Text;

            if (MessageBox.Show("Bạn có chắc muốn xóa cố vấn học tập có mã: " + macovan,
                "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool kq = BLL_CoVanHocTap.Instance.Xoa(id);

                if (kq)
                {
                    MessageBox.Show("Xóa cố vấn thành công!");
                    btnTaiLai.PerformClick();
                }
                else
                {
                    MessageBox.Show(
                        "Không thể xóa cố vấn này vì đang được sử dụng trong dữ liệu liên quan!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }
        private void ClearForm()
        {
            txbID.Clear();
            txbMaCoVan.Clear();
            txbTenCoVan.Clear();

            dtpkNgaySinh.Value = DateTime.Now;

            rdNam.Checked = false;
            rdNu.Checked = false;

            cmbMaKhoa.SelectedIndex = -1;
            cmbMaLop.SelectedIndex = -1;

            dgvCoVanHocTap.ClearSelection();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenCV = txbTenCoVan.Text.Trim();

                DateTime? ngaySinh = null;

                // Chỉ lọc ngày sinh nếu user có thay đổi ngày
                if (dtpkNgaySinh.Value.Date != DateTime.Now.Date)
                {
                    ngaySinh = dtpkNgaySinh.Value.Date;
                }


                string maLop = cmbMaLop.SelectedIndex != -1
                    ? cmbMaLop.SelectedValue.ToString()
                    : null;

                string maKhoa = cmbMaKhoa.SelectedIndex != -1
                    ? cmbMaKhoa.SelectedValue.ToString()
                    : null;

                if (string.IsNullOrEmpty(tenCV) &&
                    ngaySinh == null &&
                    maLop == null &&
                    maKhoa == null)
                {
                    MessageBox.Show(
                        "Vui lòng nhập ít nhất một điều kiện tìm kiếm!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                DataTable dt = BLL_CoVanHocTap.Instance.TimKiem(
                    tenCV,
                    ngaySinh,
                    maLop,
                    maKhoa
                );

                dgvCoVanHocTap.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Không tìm thấy cố vấn phù hợp!",
                        "Kết quả",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tìm kiếm: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void cmbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaKhoa.SelectedValue == null)
            {
                cmbMaLop.DataSource = null;
                return;
            }

            string maKhoa = cmbMaKhoa.SelectedValue.ToString();
            DataTable dsLop = BLL_Lop.Instance.TimTheoKhoa(maKhoa);

            cmbMaLop.DataSource = dsLop;
            cmbMaLop.DisplayMember = "TenLop";
            cmbMaLop.ValueMember = "MaLop";
            cmbMaLop.SelectedIndex = -1;
        }

        //private void btnXoa_Click_1(object sender, EventArgs e)
        //{
        //    int id = int.Parse(txbID.Text);
        //    string macovan = txbMaCoVan.Text;
        //    if (string.IsNullOrWhiteSpace(txbID.Text))
        //    {
        //        MessageBox.Show("Bạn chưa chọn cố vấn cần sửa!");
        //        return;
        //    }
        //    if (MessageBox.Show("Bạn có chắc muốn xóa cố vấn học tập có mã: " + macovan, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //    {
        //        if (BLL_CoVanHocTap.Instance.Xoa(id) == true)
        //        {
        //            MessageBox.Show("Xóa cố vấn thành công!");
        //            btnTaiLai.PerformClick();
        //        }
        //    }
        //}
    }
}
