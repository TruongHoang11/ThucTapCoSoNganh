using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.DAL
{
    public class DAL_Khoa
    {
        private static DAL_Khoa instance; // ctr + r + e
        public static DAL_Khoa Instance
        {
            get { if (instance == null) instance = new DAL_Khoa(); return instance; }
            private set => instance = value;
        }

        public object DataProvider { get; private set; }

        private DAL_Khoa() { }

        public bool Them(string makhoa, string tenkhoa)
        {
            string sql = "insert into Khoa(MaKhoa, TenKhoa) values( @MaKhoa, @TenKhoa)";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { makhoa, tenkhoa });
        }

        public bool Sua(string makhoa, string tenkhoa, int id)
        {
            string sql = "update Khoa set MaKhoa = @MaKhoa , TenKhoa = @TenKhoa  where id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { makhoa, tenkhoa, id });
        }

        public bool Xoa(int id)
        {
            string sql = "delete from Khoa where id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            string sql = "select * from Khoa";
            return DAL_KetNoi.Instance.ExcuteQuery(sql);
        }
    }
}
