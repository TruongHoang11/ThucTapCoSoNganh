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
    public partial class ThongTinChiTiet : Form
    {
        public ThongTinChiTiet()
        {
            InitializeComponent();

        }
        public ThongTinChiTiet(string tenDangNhap, string matKhau, string loaiTaiKhoan)
        {
            InitializeComponent();
            txbTenDangNhap.ReadOnly = true;   // Chỉ khóa, không vô hiệu hóa
            txbTenDangNhap.Text = tenDangNhap;

            txbMatKhau.ReadOnly = true;
            txbMatKhau.Text = matKhau;

            txbLoaiTaiKhoan.ReadOnly = true;
            txbTenDangNhap.ForeColor = Color.Black;
            txbTenDangNhap.BackColor = Color.White;

            txbLoaiTaiKhoan.Text = loaiTaiKhoan;
        }

        private void ThongTinChiTiet_Load(object sender, EventArgs e)
        {
            //txbTenDangNhap.Text = HeThong.TENDANGNHAP;
            //txbLoaiTaiKhoan.Text = HeThong.LOAITAIKHOAN;
            ////string username = dgvTaiKhoan.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            ////string matkhau = dgvTaiKhoan.CurrentRow.Cells["MatKhau"].Value.ToString();
            ////string loaiTK = dgvTaiKhoan.CurrentRow.Cells["LoaiTaiKhoan"].Value.ToString();

            ////ThongTinChiTiet f = new ThongTinChiTiet(username, matkhau, loaiTK);
            ////f.ShowDialog();
        }

        private void txbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbLoaiTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
