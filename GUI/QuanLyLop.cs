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
    public partial class QuanLyLop : Form
    {
        public QuanLyLop()
        {
            InitializeComponent();
        }

        private void QuanLyLop_Load(object sender, EventArgs e)
        {
            btnTaiLai.PerformClick();
        }

        

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text;
            string tenlop = txbTenLop.Text;
            string makhoa = cmbMaKhoa.SelectedValue.ToString().Trim();
            int soluong = (int)numSoLuong.Value;
            if (malop.Length > 0 && tenlop.Length > 0)
            {
                try
                {
                    if (BLL_Lop.Instance.Them(malop, tenlop, soluong, makhoa) == true)
                        btnTaiLai.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã lớp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Vui lòng không bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txbID.Text = dgvLop.CurrentRow.Cells[0].Value.ToString().Trim();
        //    txbMaLop.Text = dgvLop.CurrentRow.Cells[1].Value.ToString().Trim();
        //    txbTenLop.Text = dgvLop.CurrentRow.Cells[2].Value.ToString().Trim();
        //    numSoLuong.Value = int.Parse(dgvLop.CurrentRow.Cells[3].Value.ToString());
        //    cmbMaKhoa.SelectedValue = dgvLop.CurrentRow.Cells[4].Value.ToString().Trim();
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text); 
            string malop = txbMaLop.Text; 
            string tenlop = txbTenLop.Text; 
            string makhoa = cmbMaKhoa.SelectedValue.ToString().Trim(); 
            int soluong = (int)numSoLuong.Value; 
            if (malop.Length > 0 && tenlop.Length > 0) 
            { 
                try 
                { 
                    if (BLL_Lop.Instance.Sua(malop, tenlop, soluong, makhoa, id) == true) btnTaiLai.PerformClick(); 
                } 
                catch { MessageBox.Show("Mã lớp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                } 
            } 
            else MessageBox.Show("Vui lòng không bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string tenlop = txbTenLop.Text;

            if (MessageBox.Show("Bạn có muốn xóa lop " + tenlop + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_Lop.Instance.Xoa(id) == true)
                        btnTaiLai.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Lớp đang được sử dụng.", "THông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvLop_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvLop.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaLop.Text = dgvLop.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenLop.Text = dgvLop.CurrentRow.Cells[2].Value.ToString().Trim();
            numSoLuong.Value = int.Parse(dgvLop.CurrentRow.Cells[3].Value.ToString());
            cmbMaKhoa.SelectedValue = dgvLop.CurrentRow.Cells[4].Value.ToString().Trim();
        }
    }
}
