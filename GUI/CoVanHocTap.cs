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
