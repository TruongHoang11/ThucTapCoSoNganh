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

        public bool Them(string MaSV, string MaLopHocPhan, int PhanTramTrenLop, int PhanTramThi, float DiemTrenLop, float DiemThi, float DiemTB, string Loai)
        {
            string sql = "insert into Diem(MaSV, MaLopHocPhan, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai)" +
                " values( @MaSV, @MaLopHocPhan, @PhanTramTrenLop, @PhanTramThi, @DiemTrenLop, @DiemThi, @DiemTB, @Loai)";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaSV, MaLopHocPhan, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai });
        }

        public bool Sua(string MaSV, string MaLopHocPhan, int PhanTramTrenLop, int PhanTramThi, float DiemTrenLop, float DiemThi, float DiemTB, string Loai, int id)
        {
            string sql = "update Diem set MaSV=@MaSV, MaLopHocPhan = @MaLopHocPhan, PhanTramTrenLop = @PhanTramTrenLop, PhanTramThi = @PhanTramThi, DiemTrenLop = @DiemTrenLop, DiemThi = @DiemThi, DiemTB = @DiemTB, Loai = @Loai  where  id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaSV, MaLopHocPhan, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai, id });
        }

        public bool Xoa(int id)
        {
            string sql = "delete from Diem where id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            string sql = @"SELECT d.Id, d.MaSV, sv.TenSV, d.MaLopHocPhan, 
                          lhp.TenLopHocPhan, mh.TenMH,
                          d.PhanTramTrenLop, d.PhanTramThi, 
                          d.DiemTrenLop, d.DiemThi, d.DiemTB, d.Loai
                          FROM Diem d
                          INNER JOIN SinhVien sv ON d.MaSV = sv.MaSV
                          INNER JOIN LopHocPhan lhp ON d.MaLopHocPhan = lhp.MaLopHocPhan
                          INNER JOIN MonHoc mh ON lhp.MaMH = mh.MaMH
                          ORDER BY d.Id";
            return DAL_KetNoi.Instance.ExcuteQuery(sql);
        }

        // Method mới: Lấy danh sách sinh viên đã đăng ký lớp học phần
        public DataTable LaySinhVienTheoLopHocPhan(string MaLopHocPhan)
        {
            string sql = @"SELECT DISTINCT sv.MaSV, sv.TenSV 
                          FROM SinhVien sv 
                          INNER JOIN DangKyMon dk ON sv.MaSV = dk.MaSV 
                          WHERE dk.MaLopHocPhan = @MaLopHocPhan
                          ORDER BY sv.MaSV";
            return DAL_KetNoi.Instance.ExcuteQuery(sql, new object[] { MaLopHocPhan });
        }

        // Method mới: Lấy danh sách điểm theo lớp học phần
        public DataTable LayDiemTheoLopHocPhan(string MaLopHocPhan)
        {
            string sql = @"SELECT d.Id, d.MaSV, sv.TenSV, d.MaLopHocPhan, 
                          lhp.TenLopHocPhan, mh.TenMH,
                          d.PhanTramTrenLop, d.PhanTramThi, 
                          d.DiemTrenLop, d.DiemThi, d.DiemTB, d.Loai
                          FROM Diem d
                          INNER JOIN SinhVien sv ON d.MaSV = sv.MaSV
                          INNER JOIN LopHocPhan lhp ON d.MaLopHocPhan = lhp.MaLopHocPhan
                          INNER JOIN MonHoc mh ON lhp.MaMH = mh.MaMH
                          WHERE d.MaLopHocPhan = @MaLopHocPhan 
                          ORDER BY d.MaSV";
            return DAL_KetNoi.Instance.ExcuteQuery(sql, new object[] { MaLopHocPhan });
        }

        // Method mới: Kiểm tra sinh viên đã đăng ký lớp học phần chưa
        public bool KiemTraSinhVienDaDangKy(string MaSV, string MaLopHocPhan)
        {
            string sql = @"SELECT COUNT(*) FROM DangKyMon 
                          WHERE MaSV = @MaSV AND MaLopHocPhan = @MaLopHocPhan";
            DataTable dt = DAL_KetNoi.Instance.ExcuteQuery(sql, new object[] { MaSV, MaLopHocPhan });

            if (dt != null && dt.Rows.Count > 0)
            {
                int count = Convert.ToInt32(dt.Rows[0][0]);
                return count > 0;
            }
            return false;
        }
    }
}