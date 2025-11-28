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
            new ThongTinChiTiet().ShowDialog();
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
    }
}
