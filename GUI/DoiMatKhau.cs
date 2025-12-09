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
    public partial class DoiMatKhau : Form
    {
        private string tenDangNhap;

        public DoiMatKhau(string username)
        {
            InitializeComponent();
            tenDangNhap = username;
            txbTenDangNhap.Text = username;
            txbTenDangNhap.ReadOnly = true;
        }
        public DoiMatKhau()
        {
            InitializeComponent();
            txbMatKhauCu.Focus();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            txbMatKhauCu.Focus();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string mkCu = txbMatKhauCu.Text.Trim();
            string mkMoi = txbMatKhauMoi.Text.Trim();
            string mkNhapLai = txbXacNhanMatKhauMoi.Text.Trim();

            // 1. Kiểm tra nhập đủ thông tin
            if (mkCu == "" || mkMoi == "" || mkNhapLai == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Mật khẩu mới phải khác mật khẩu cũ
            if (mkCu == mkMoi)
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Kiểm tra nhập lại mật khẩu mới
            if (mkMoi != mkNhapLai)
            {
                MessageBox.Show("Xác nhận mật khẩu mới không khớp.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Gọi BLL đổi mật khẩu
            if (BLL_TaiKhoan.Instance.DoiMatKhau(tenDangNhap, mkMoi, mkCu))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            string mkCu = txbMatKhauCu.Text.Trim();
            string mkMoi = txbMatKhauMoi.Text.Trim();
            string mkNhapLai = txbXacNhanMatKhauMoi.Text.Trim();

            // 1. Kiểm tra nhập đủ thông tin
            if (mkCu == "" || mkMoi == "" || mkNhapLai == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Mật khẩu mới phải khác mật khẩu cũ
            if (mkCu == mkMoi)
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Kiểm tra nhập lại mật khẩu mới
            if (mkMoi != mkNhapLai)
            {
                MessageBox.Show("Xác nhận mật khẩu mới không khớp.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Gọi BLL đổi mật khẩu
            if (BLL_TaiKhoan.Instance.DoiMatKhau(tenDangNhap, mkMoi, mkCu))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
