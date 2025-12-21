using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.DAL
{
    public class DAL_Lop
    {
        private static DAL_Lop instance; // ctr + r + e
        public static DAL_Lop Instance
        {
            get { if (instance == null) instance = new DAL_Lop(); return instance; }
            private set => instance = value;
        }
        public DataTable GetDanhSachLop()
        {
            string sql = "SELECT MaLop, TenLop FROM Lop";
            return DAL_KetNoi.Instance.ExcuteQuery(sql);
        }

        public object DataProvider { get; private set; }

        private DAL_Lop() { }

        public bool Them(string malop, string tenlop, int soluong, string makhoa)
        {
            string sql = "insert into Lop(MaLop, TenLop, SoLuong, MaKhoa) values( @MaLop, @TenLop, @SoLuong, @MaKhoa)";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { malop, tenlop, soluong, makhoa });
        }

        public bool Sua(string malop, string tenlop, int soluong, string makhoa, int id)
        {
            string sql = "update Lop set MaLop = @MaLop , TenLop = @TenLop, SoLuong = @SoLuong, MaKhoa = @MaKhoa  where id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { malop, tenlop, soluong, makhoa, id });
        }

        public bool Xoa(int id)
        {
            string sql = "delete from Lop where id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            string sql = "select * from Lop";
            return DAL_KetNoi.Instance.ExcuteQuery(sql);
        }
    }
}
