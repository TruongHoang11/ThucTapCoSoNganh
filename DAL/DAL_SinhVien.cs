using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.DAL
{
    public class DAL_SinhVien
    {
        private static DAL_SinhVien instance;
        public static DAL_SinhVien Instance
        {
            get { if (instance == null) instance = new DAL_SinhVien(); return instance; }
            private set => instance = value;
        }
        private DAL_SinhVien() { }
        public bool Them(string masv, string tensv, DateTime ngaysinh, string gioitinh, string quequan, DateTime ngaynh, string makhoa, string malop, string macvht)
        {
            string sql = "insert into SinhVien(MaSV, TenSV, NgaySinh, GioiTinh,QueQuan,NgayNhapHoc, MaLop, MaKhoa, MaCVHT) values(@MaSV, @TenSV, @NgaySinh, @GioiTinh, @QueQuan, @NgayNhapHoc, @MaLop, @MaKhoa, @MaCVHT)";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { masv, tensv, ngaysinh, gioitinh, quequan, ngaynh, makhoa, malop, macvht });
        }
        public bool Sua(string masv, string tensv, DateTime ngaysinh, string gioitinh, string quequan, DateTime ngaynh, string makhoa, string malop, string macvht, int id)
        {
            string sql = "update SinhVien set MaSV=@MaSV, TenSV = @TenSV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, QueQuan = @QueQuan, NgayNhapHoc = @NgayNhapHoc, MaLop = @MaLop, MaKhoa = @MaKhoa, MaCVHT = @MaCVHT where  id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { masv, tensv, ngaysinh, gioitinh, quequan, ngaynh, makhoa, malop, macvht, id });
        }
        public bool Xoa(int id)
        {
            string sql = "delete from SinhVien where id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }
        public DataTable DanhSach()
        {
            return DAL_KetNoi.Instance.ExcuteQuery("select * from SinhVien");
        }
    }
}
