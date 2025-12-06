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
            //if(HeThong.LOAITAIKHOAN!="Quản trị")
            //    btnQuanLy.Visible=false;
            //else
            //    btnQuanLy.Visible = true;

            btnLamMoi.PerformClick();
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = BLL_SinhVien.Instance.DanhSach();
            //cbbMaLop.DataSource = BLL_Lop.Instance.DanhSach();
            cbbMaKhoa.DisplayMember = "TenLop";
            cbbMaKhoa.ValueMember = "MaLop";
            //cbbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cbbMaKhoa.DisplayMember = "TenKhoa";
            cbbMaKhoa.ValueMember = "MaKhoa";
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
            txbMaSV.Text = dgvSinhVien.CurrentRow.Cells[1].Value.ToString();
            txbTenSV.Text = dgvSinhVien.CurrentRow.Cells[2].Value.ToString();
            dtpkNgaySinh.Value = (DateTime)dgvSinhVien.CurrentRow.Cells [3].Value;
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
            string masv = txbMaSV.Text;
            string tensv = txbTenSV.Text;
            DateTime ngaysinh = (DateTime)dtpkNgaySinh.Value;
            string gioitinh = (rbNam.Checked==true) ? "Nam" : "Nữ";
            string quequan = txbQueQuan.Text;
            DateTime ngaynhaphoc = (DateTime)dtpkNgaySinh.Value;
            //string malop = cbbMaLop.SelectedValue.ToString();
            //string makhoa = cbbMaKhoa.SelectedValue.ToString();
            //string macvht = cbbMaCoVan.SelectedValue.ToString();
            string malop = "1";
            string makhoa = "1";
            string macvht = "1";
            

            if (BLL_SinhVien.Instance.Them(masv, tensv, ngaysinh, gioitinh, quequan, ngaynhaphoc, malop, makhoa, macvht) == true)
                btnLamMoi.PerformClick();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string masv = txbMaSV.Text;
            string tensv = txbTenSV.Text;
            DateTime ngaysinh = (DateTime)dtpkNgaySinh.Value;
            string gioitinh = (rbNam.Checked == true) ? "Nam" : "Nữ";
            string quequan = txbQueQuan.Text;
            DateTime ngaynhaphoc = (DateTime)dtpkNgaySinh.Value;
            string malop = cbbMaLop.SelectedValue.ToString();
            string makhoa = cbbMaKhoa.SelectedValue.ToString();
            string macvht = cbbMaCoVan.SelectedValue.ToString();
            int id = int.Parse(txbID.Text);

            if (BLL_SinhVien.Instance.Sua(masv, tensv, ngaysinh, gioitinh, quequan, ngaynhaphoc, malop, makhoa, macvht, id) == true)
                btnLamMoi.PerformClick();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            if (MessageBox.Show($"Bạn có muốn xoá sinh viên có ID: {id}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BLL_SinhVien.Instance.Xoa(id) == true)
                    btnLamMoi.PerformClick();
            }
        }
    }
}
