using System.Data;
namespace Dayone.DAL
{
    public class DAL_LopHocPhan
    {
        private static DAL_LopHocPhan instance;
        public static DAL_LopHocPhan Instance
        {
            get { if (instance == null) instance = new DAL_LopHocPhan(); return instance; }
            private set => instance = value;
        }
        private DAL_LopHocPhan() { }

        public DataTable DanhSach()
        {
            // JOIN với MonHoc để lấy TenMH
            string sql = @"SELECT lhp.Id, 
                                  lhp.MaLopHocPhan, 
                                  lhp.TenLopHocPhan, 
                                  lhp.SoLuong,
                                  lhp.NamHoc,
                                  lhp.MaMH,
                                  mh.TenMH
                           FROM LopHocPhan lhp
                           INNER JOIN MonHoc mh ON lhp.MaMH = mh.MaMH
                           ORDER BY lhp.Id";
            return DAL_KetNoi.Instance.ExcuteQuery(sql);
        }

        public bool Them(string MaLopHocPhan, string MaMH, string TenLopHocPhan, int NamHoc, int SoLuong)
        {
            string sql = @"INSERT INTO LopHocPhan(MaLopHocPhan, MaMH, TenLopHocPhan, NamHoc, SoLuong)
                           VALUES(@MaLopHocPhan, @MaMH, @TenLopHocPhan, @NamHoc, @SoLuong)";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaLopHocPhan, MaMH, TenLopHocPhan, NamHoc, SoLuong });
        }

        public bool Sua(string MaLopHocPhan, string MaMH, string TenLopHocPhan, int NamHoc, int SoLuong, int id)
        {
            string sql = @"UPDATE LopHocPhan 
                           SET MaLopHocPhan=@MaLopHocPhan, MaMH=@MaMH, TenLopHocPhan=@TenLopHocPhan, 
                               NamHoc=@NamHoc, SoLuong=@SoLuong 
                           WHERE Id=@id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaLopHocPhan, MaMH, TenLopHocPhan, NamHoc, SoLuong, id });
        }

        public bool Xoa(int id)
        {
            string sql = "DELETE FROM LopHocPhan WHERE Id=@id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }
    }
}