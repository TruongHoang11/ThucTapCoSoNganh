using System;
using System.Data;

namespace Dayone.DAL
{
    public class DAL_DangKyMon
    {
        private static DAL_DangKyMon instance;
        public static DAL_DangKyMon Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_DangKyMon();
                return instance;
            }
        }

        // ================= ĐĂNG KÝ MÔN =================
        public bool DangKy(string MaSV, string MaLopHocPhan, DateTime NgayDangKy)
        {
            string sql = @"INSERT INTO DangKyMon(MaSV, MaLopHocPhan, NgayDangKy)
                           VALUES (@MaSV, @MaLopHocPhan, @NgayDangKy)";

            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaSV, MaLopHocPhan , NgayDangKy });
        }

        // ================= KIỂM TRA TRÙNG =================
        public bool DaDangKy(string maSV, string maLopHocPhan)
        {
            string sql = @"SELECT COUNT(*)
                           FROM DangKyMon
                           WHERE MaSV = @MaSV
                             AND MaLopHocPhan = @MaLopHocPhan";

            int count = Convert.ToInt32(
                DAL_KetNoi.Instance.ExecuteScalar(
                    sql,
                    new object[] { maSV, maLopHocPhan }
                )
            );

            return count > 0;
        }

        // ================= DANH SÁCH ĐĂNG KÝ =================
        public DataTable DanhSachTheoSV()
        {
            string sql = @"SELECT dk.Id,
                                  dk.MaSV,
                                  sv.TenSV,
                                  lhp.MaLopHocPhan,
                                  lhp.TenLopHocPhan,
                                  mh.TenMH,
                                  dk.NgayDangKy
                           FROM DangKyMon dk
                           JOIN SinhVien sv ON dk.MaSV = sv.MaSV
                           JOIN LopHocPhan lhp ON dk.MaLopHocPhan = lhp.MaLopHocPhan
                           JOIN MonHoc mh ON lhp.MaMH = mh.MaMH;
                           ";
            //WHERE dk.MaSV = @MaSV

            return DAL_KetNoi.Instance.ExcuteQuery(
                sql,
                new object[] {  }
            );
        }

        // ================= LOAD LỚP HỌC PHẦN =================
        public DataTable GetLopHocPhan()
        {
            string sql = @"SELECT MaLopHocPhan, TenLopHocPhan
                           FROM LopHocPhan";

            return DAL_KetNoi.Instance.ExcuteQuery(sql);
        }
        // ================= DANH SÁCH TẤT CẢ ĐĂNG KÝ =================
        public DataTable DanhSachTatCa()
        {
            string sql = @"SELECT dk.Id,
                          dk.MaSV,
                          sv.TenSV,
                          lhp.MaLopHocPhan,
                          lhp.TenLopHocPhan,
                          mh.TenMH,
                          dk.NgayDangKy
                   FROM DangKyMon dk
                   LEFT JOIN SinhVien sv ON dk.MaSV = sv.MaSV
                   LEFT JOIN LopHocPhan lhp ON dk.MaLopHocPhan = lhp.MaLopHocPhan
                   LEFT JOIN MonHoc mh ON lhp.MaMH = mh.MaMH
                   ORDER BY dk.Id DESC";
            return DAL_KetNoi.Instance.ExcuteQuery(sql);
        }
    }
}
