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
            string tendangnhap = txbTenDangNhap.Text;
            string matkhau = txbMatKhau.Text;

            if (BLL_TaiKhoan.Instance.DangNhap(tendangnhap, matkhau) == true)
            {
                txbMatKhau.Clear();
                SinhVien f = new SinhVien();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng...",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau();
            f.Show();

            
        }
    }
}
