using Dayone.BLL;
using Dayone.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dayone.GUI.SinhVien;

namespace Dayone
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //string tendangnhap = txbTenDangNhap.Text;
            //string matkhau = txbMatKhau.Text;

            //if (BLL_TaiKhoan.Instance.DangNhap(tendangnhap, matkhau))
            //{
            //    HeThong.TENDANGNHAP = tendangnhap;
            //    HeThong.LOAITAIKHOAN = BLL_TaiKhoan.Instance.LayLoaiTaiKhoan(tendangnhap);

            //    SinhVien f = new SinhVien();
            //    this.Hide();
            //    f.ShowDialog();
            //    this.Show();
            //}

            //if (BLL_TaiKhoan.Instance.DangNhap(tendangnhap, matkhau) == true)
            //{
            //    txbMatKhau.Clear();
            //    SinhVien f = new SinhVien();
            //    this.Hide();
            //    f.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng...",
            //                    "Thông báo",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Warning);
            //}


            //commented 

            string tendangnhap = txbTenDangNhap.Text;
            string matkhau = txbMatKhau.Text;

            bool ok = BLL_TaiKhoan.Instance.DangNhap(tendangnhap, matkhau);

            if (ok)
            {
                // DangNhap() đã gán sẵn HeThong.LOAITAIKHOAN
                HeThong.TENDANGNHAP = tendangnhap;

                txbMatKhau.Clear();

                SinhVien f = new SinhVien();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show(
                    "Tên đăng nhập hoặc mật khẩu không đúng...",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            //đuôi

            // MessageBox.Show("ROLE = [" + HeThong.LOAITAIKHOAN + "]");


            //string tendangnhap = txbTenDangNhap.Text;
            //string matkhau = txbMatKhau.Text;

            //if (BLL_TaiKhoan.Instance.DangNhap(tendangnhap, matkhau) == true)
            //{
            //    txbMatKhau.Clear();
            //    SinhVien f = new SinhVien();
            //    this.Hide();
            //    f.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng...",
            //                    "Thông báo",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Warning);

            //}

            //            bool ok = BLL_TaiKhoan.Instance.DangNhap(
            //    txbTenDangNhap.Text,
            //    txbMatKhau.Text
            //);

            //            if (ok)
            //            {
            //                // Vai trò đã được gán sẵn trong BLL vào HeThong.LOAITAIKHOAN
            //                HeThong.TENDANGNHAP = txbTenDangNhap.Text;

            //                SinhVien frm = new SinhVien();
            //                frm.Show();
            //                this.Hide();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            //            }


            //SinhVien f = new SinhVien();
            //this.Hide();
            //f.ShowDialog();
            //this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau();
            f.Show();


        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}