using Dayone.BLL;
using DocumentFormat.OpenXml.Office2010.Excel;
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

        private void ClearForm()
        {
            txbID.Clear();

            txbMaLop.Clear();
            txbTenLop.Clear();
            numSoLuong.Text = "";
            cmbMaKhoa.SelectedValue = -1;

        }


        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";
            ClearForm();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text;
            string tenlop = txbTenLop.Text;
            string makhoa = cmbMaKhoa.SelectedValue.ToString().Trim();
            int soluong = (int)numSoLuong.Value;
            if (malop.Length == 0 || tenlop.Length == 0 || makhoa.Length == 0 || soluong == 0)
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    if (BLL_Lop.Instance.Them(malop, tenlop, soluong, makhoa) == true)
                    {
                        MessageBox.Show("Thêm lớp thành công.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnTaiLai.PerformClick();                      
                    }
                        
                }
                catch
                {
                    MessageBox.Show("Mã lớp  đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


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
            if (malop.Length == 0 || tenlop.Length == 0 || makhoa.Length == 0 || soluong == 0)
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    if (BLL_Lop.Instance.Sua(malop, tenlop, soluong,makhoa,id) == true)
                    {
                        btnTaiLai.PerformClick();
                        MessageBox.Show("Sửa lớp thành công.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                        
                }
                catch
                {
                    bool trungMaLop = false;
                    bool trungTenLop = false;
                    bool trungMaVaTen = false;

                    foreach (DataGridViewRow row in dgvLop.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int idTrongGrid = Convert.ToInt32(row.Cells[0].Value);

                        string maLopTrongGrid = row.Cells[1].Value?.ToString();
                        string tenLopTrongGrid = row.Cells[2].Value?.ToString();

                        if (maLopTrongGrid == null || tenLopTrongGrid == null) continue;
                        if (idTrongGrid == id) continue;

                        if (maLopTrongGrid == malop && tenLopTrongGrid == tenlop)
                        {
                            trungMaVaTen = true;
                            break;
                        }

                        if (maLopTrongGrid == malop)
                        {
                            trungMaLop = true;
                        }

                        if (tenLopTrongGrid == tenlop)
                        {
                            trungTenLop = true;
                        }
                    }

                    if (trungMaVaTen)
                        MessageBox.Show("Mã lớp và tên lớp đã tồn tại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (trungMaLop)
                        MessageBox.Show("Mã lớp đã tồn tại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (trungTenLop)
                        MessageBox.Show("Tên lớp đã tồn tại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Bạn không thể sửa lớp này.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
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
                    {
                        MessageBox.Show("Xóa lớp thành công.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnTaiLai.PerformClick();
                    }                        
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn khoa hay chưa
            if (cmbMaKhoa.SelectedValue == null || string.IsNullOrEmpty(cmbMaKhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn tên khoa.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string maKhoa = cmbMaKhoa.SelectedValue.ToString().Trim();

            // Lấy toàn bộ danh sách lớp
            DataTable dt = BLL_Lop.Instance.DanhSach();

            // Lọc theo mã khoa
            DataView dv = dt.DefaultView;
            dv.RowFilter = $"MaKhoa = '{maKhoa}'";

            // Hiển thị lên DataGridView
            dgvLop.DataSource = dv.ToTable();
        }

        private void QuanLyLop_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}
