using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dayone.DAL
{
    public class DAL_Diem
    {
        private static DAL_Diem instance;
        public static DAL_Diem Instance
        {
            get { if (instance == null) instance = new DAL_Diem(); return instance; }
            private set => instance = value;
        }
        private DAL_Diem() { }
        public bool Them(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramThi, float DiemTrenLop, float DiemThi, float DiemTB, string Loai, int namhoc)
        {
            string sql = "insert into Diem(MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai, NamHoc)" +
                " values( @MaSV, @MaMH, @PhanTramTrenLop, @PhanTramThi, @DiemTrenLop, @DiemThi, @DiemTB, @Loai, @NamHoc)";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai, namhoc });
        }
        public bool Sua(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramThi, float DiemTrenLop, float DiemThi, float DiemTB, string Loai, int namhoc, int id)
        {
            string sql = "update Diem set MaSV=@MaSV, MaMH = @MaMH, PhanTramTrenLop = @PhanTramTrenLop, PhanTramThi = @PhanTramThi, DiemTrenLop = @DiemTrenLop, DiemThi = @DiemThi, DiemTB = @DiemTB, Loai = @Loai, namhoc = @namhoc where  id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai, namhoc, id });
        }
        public bool Xoa(int id)
        {
            string sql = "delete from Diem where id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }
        public DataTable DanhSach()
        {
            return DAL_KetNoi.Instance.ExcuteQuery("select * from Diem");
        }
    }

}
