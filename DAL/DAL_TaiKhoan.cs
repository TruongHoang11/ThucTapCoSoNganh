using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.DAL
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance; // ctr + r + e
        public static DAL_TaiKhoan Instance
        {
            get
            {
                if (instance == null) instance = new DAL_TaiKhoan();
                return instance;
            }
            //get { if (instance == null) instance = new DAL_TaiKhoan(); return instance; }
            //private set => instance = value;
        }

        //public object DataProvider { get; private set; }

        private DAL_TaiKhoan() { }
       

        public bool Them(string ten, string matkhau, string loai)
        {
            string sql = "insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTaiKhoan) values( @TenDangNhap , @MatKhau , @LoaiTaiKhoan )";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { ten, matkhau, loai });
        }

        public bool Sua_Het(string ten, string matkhau, string loai, int id)
        {
            string sql = "update TaiKhoan set TenDangNhap = @TenDangNhap , MatKhau = @MatKhau , LoaiTaiKhoan = @LoaiTaiKhoan where id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { ten, matkhau, loai, id });
        }
        public bool KhongSuaMatKhau(string ten, string loai, int id)
        {
            string sql = "update TaiKhoan set TenDangNhap = @TenDangNhap , LoaiTaiKhoan = @LoaiTaiKhoan where id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { ten, loai, id });
        }
        public bool Xoa(int id)
        {
            string sql = "delete from TaiKhoan where id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }
        public string LayLoaiTaiKhoan(string tenDangNhap)
        {
            string query = "SELECT LoaiTaiKhoan FROM TaiKhoan WHERE TenDangNhap = @ten";
            DataTable dt = DAL_KetNoi.Instance.ExcuteQuery(query, new object[] { tenDangNhap });

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["LoaiTaiKhoan"].ToString();

            return "";
        }


        public DataTable DanhSach()
        {
            string sql = "select * from TaiKhoan";
            return DAL_KetNoi.Instance.ExcuteQuery(sql);
        }

        //public DataTable DangNhap(string ten, string matkhau)
        //{
        //    string sql = "select * from TaiKhoan where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau";
        //    return KetNoi.Instance.ExcuteQuery(sql, new object[] { ten, matkhau });
        //}
        //public DataTable DangNhap(string ten, string matkhau)
        //{
        //    string sql = @"SELECT * FROM TaiKhoan 
        //                   WHERE TenDangNhap = @TenDangNhap 
        //                     AND MatKhau = @MatKhau";

        //    // Use DAL_KetNoi.Instance.ExcuteQuery instead of DataProvider.ExecuteQuery
        //    return DAL_KetNoi.Instance.ExcuteQuery(sql, new object[] { ten, matkhau });
        //}
        public DataTable DangNhap(string tenDangNhap, string matKhau)
        {
            string query = "SELECT LoaiTaiKhoan " +
                           "FROM TaiKhoan " +
                           "WHERE TenDangNhap = @ten AND MatKhau = @mk";

            return DAL_KetNoi.Instance.ExcuteQuery(
                query,
                new object[] { tenDangNhap, matKhau });
        }
        public bool KiemTraMatKhau(string tenDangNhap, string matKhau)
        {
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @ten AND MatKhau = @mk";
            DataTable dt = DAL_KetNoi.Instance.ExcuteQuery(sql, new object[] { tenDangNhap, matKhau });

            return dt.Rows[0][0].ToString() == "1";
        }

        public bool DoiMatKhau(string tenDangNhap, string matKhauMoi, string matKhauCu)
        {
            string sql = "UPDATE TaiKhoan SET MatKhau = @mkMoi WHERE TenDangNhap = @ten AND MatKhau = @mkCu";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { matKhauMoi, tenDangNhap, matKhauCu });
        }
    }
}
