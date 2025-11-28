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
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tendangnhap = txbTenDangNhap.Text.Trim();
            string matkhau = txbMatKhau.Text.Trim();
            string loaiTK = cmbLoaiTaiKhoan.SelectedItem.ToString();

            if (tendangnhap.Length > 0 && matkhau.Length >= 6 && loaiTK.Length > 0)
            {
                try
                {
                    if (BLL_TaiKhoan.Instance.them(tendangnhap, matkhau, loaiTK) == true)
                        btnTaiLai.PerformClick(); //Bấm lại btnLamMoi
                }
                catch
                {
                    MessageBox.Show("Tên đăng nhập bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không được dưới 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string tendangnhap = txbTenDangNhap.Text.Trim();
            string matkhau = txbMatKhau.Text.Trim();
            string loaiTK = cmbLoaiTaiKhoan.SelectedItem.ToString();

            if (tendangnhap.Length > 0  && loaiTK.Length > 0)
            {
                try
                {   // khong sua mat khau
                    if(matkhau.Length ==0)
                    {
                        if (BLL_TaiKhoan.Instance.KhongSuaMatKhau(tendangnhap, loaiTK, id) == true)
                            btnTaiLai.PerformClick(); //Bấm lại btnLamMoi
                    }
                    // sua mat khau 
                    else
                    {
                        if (BLL_TaiKhoan.Instance.SuaHet(tendangnhap, matkhau, loaiTK, id) == true)
                            btnTaiLai.PerformClick(); //Bấm lại btnLamMoi
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Tên đăng nhập bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không được dưới 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString());
            string ten = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();

            if (MessageBox.Show("Bạn có muốn xóa tài khoản " + ten + " không?",
                                "Thông báo",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_TaiKhoan.Instance.Xoa(id) == true)
                        btnTaiLai.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Phát sinh lỗi khi xóa...",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = BLL_TaiKhoan.Instance.DanhSach();

        }

        private void cmbLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            btnTaiLai.PerformClick(); //Bấm lại btnLamMoi
            cmbLoaiTaiKhoan.SelectedIndex = 0;
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString().Trim();
            txbTenDangNhap.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();
            //txbMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString().Trim();
            cmbLoaiTaiKhoan.SelectedItem = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString().Trim();
        }
    }
}
