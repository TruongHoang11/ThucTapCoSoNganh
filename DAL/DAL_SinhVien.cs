using DocumentFormat.OpenXml.Spreadsheet;
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
        private static DAL_SinhVien instance; // ctr + r + e
        public static DAL_SinhVien Instance
        {
            get { if (instance == null) instance = new DAL_SinhVien(); return instance; }
            private set => instance = value;
        }
        private DAL_SinhVien() { }
        public bool Them(string masv, string tensv, string ngaysinh, string gioitinh, string quequan, string ngaynh, string malop,string makhoa , string macvht, string anh)
        {
            string sql = "insert into SinhVien(MaSV, TenSV, NgaySinh, GioiTinh,QueQuan,NgayNhapHoc, MaLop, MaKhoa, MaCVHT, Anh) values(@MaSV, @TenSV, @NgaySinh, @GioiTinh, @QueQuan, @NgayNhapHoc, @MaLop, @MaKhoa, @MaCVHT, @Anh)";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { masv, tensv, ngaysinh, gioitinh, quequan, ngaynh, malop, makhoa, macvht, anh });
        }
        public bool Sua(string masv, string tensv, string ngaysinh, string gioitinh,string quequan, string ngaynh, string malop, string makhoa, string macvht, string anh, int id)
        {
            string sql = "update SinhVien set MaSV = @MaSV , TenSV = @TenSV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, QueQuan = @QueQuan, NgayNhapHoc = @NgayNhapHoc, MaLop = @MaLop, MaKhoa = @MaKhoa, MaCVHT = @MaCVHT, Anh = @Anh   where id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { masv, tensv, ngaysinh, gioitinh, quequan, ngaynh, malop, makhoa, macvht, anh, id });
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
        //public DataTable TimKiem(string masv, string tensv)
        //{
        //    string sql =
        //        "SELECT * FROM SinhVien " +
        //        "WHERE MaSV LIKE @MaSV " +
        //        "AND TenSV LIKE @TenSV ";



        //    return DAL_KetNoi.Instance.ExcuteQuery(
        //        sql,
        //        new object[]
        //        {
        //    "%" + masv + "%",
        //    "%" + tensv + "%"

        //        }
        //    );
        //}
        public DataTable TimKiem(
    string masv,
    string tensv,
    string quequan,
    string malop,
    string makhoa,
    string macvht
)
        {
            string sql =
                "SELECT * FROM SinhVien WHERE 1 = 1 ";

            List<object> parameters = new List<object>();

            if (!string.IsNullOrWhiteSpace(masv))
            {
                sql += " AND MaSV LIKE @MaSV ";
                parameters.Add("%" + masv + "%");
            }

            if (!string.IsNullOrWhiteSpace(tensv))
            {
                sql += " AND TenSV LIKE @TenSV ";
                parameters.Add("%" + tensv + "%");
            }

            if (!string.IsNullOrWhiteSpace(quequan))
            {
                sql += " AND QueQuan LIKE @QueQuan ";
                parameters.Add("%" + quequan + "%");
            }

            if (!string.IsNullOrWhiteSpace(malop))
            {
                sql += " AND MaLop = @MaLop ";
                parameters.Add(malop);
            }

            if (!string.IsNullOrWhiteSpace(makhoa))
            {
                sql += " AND MaKhoa = @MaKhoa ";
                parameters.Add(makhoa);
            }

            if (!string.IsNullOrWhiteSpace(macvht))
            {
                sql += " AND MaCVHT = @MaCVHT ";
                parameters.Add(macvht);
            }

            return DAL_KetNoi.Instance.ExcuteQuery(sql, parameters.ToArray());
        }

        public bool TonTaiMaSV(string masv)
        {
            string sql = "SELECT COUNT(*) FROM SinhVien WHERE MaSV = @masv";
            return (int)DAL_KetNoi.Instance.ExecuteScalar(sql, new object[] { masv }) > 0;
        }

    }
}
