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
    public partial class QuanLyKhoa : Form
    {
        public QuanLyKhoa()
        {
            InitializeComponent();
        }

        private void QuanLyKhoa_Load(object sender, EventArgs e)
        {
            btnTaiLai.PerformClick();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string makhoa = txbMaKhoa.Text;
            string tenkhoa = txbTenKhoa.Text;

            if (makhoa.Length == 0 || tenkhoa.Length == 0)
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    if (BLL_Khoa.Instance.Them(makhoa, tenkhoa) == true)
                    {
                        MessageBox.Show("Thêm khoa thành công.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnTaiLai.PerformClick();
                    }                        
                }
                catch
                {
                    MessageBox.Show("Mã khoa đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvKhoa.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaKhoa.Text = dgvKhoa.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenKhoa.Text = dgvKhoa.CurrentRow.Cells[2].Value.ToString().Trim();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string makhoa = txbMaKhoa.Text;
            string tenkhoa = txbTenKhoa.Text;

            if (makhoa.Length == 0 || tenkhoa.Length == 0)
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    if (BLL_Khoa.Instance.Sua(makhoa, tenkhoa, id) == true)
                    {
                        MessageBox.Show("Sửa khoa thành công.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnTaiLai.PerformClick();
                    }                      
                }
                catch
                {
                    bool trungMaKhoa = false;

                    foreach (DataGridViewRow row in dgvKhoa.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string maKhoaTrongGrid = row.Cells["Column2"].Value.ToString();
                        int idTrongGrid = Convert.ToInt32(row.Cells["Column1"].Value);

                        if (maKhoaTrongGrid == makhoa && idTrongGrid != id)
                        {
                            trungMaKhoa = true;
                            break;
                        }
                    }

                    if (trungMaKhoa) // Mã khoa mới sửa nó đã tồn tại trong DataGrid
                        MessageBox.Show("Mã khoa đã tồn tại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Bạn không thể sửa mã khoa này.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string tenkhoa = txbTenKhoa.Text;

            if (MessageBox.Show("Bạn có muốn xóa khoa " + tenkhoa + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_Khoa.Instance.Xoa(id) == true)
                    {
                        MessageBox.Show("Xóa khoa thành công.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnTaiLai.PerformClick();
                    }                       
                }
                catch
                {
                    MessageBox.Show("Khoa đang được sử dụng.", "THông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            ClearForm();
        }
        private void ClearForm()
        {
            txbID.Clear();
            txbMaKhoa.Clear();
            txbTenKhoa.Clear();

        }

        private void dgvKhoa_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvKhoa.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaKhoa.Text = dgvKhoa.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenKhoa.Text = dgvKhoa.CurrentRow.Cells[2].Value.ToString().Trim();
        }

        private void txbMaKhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
