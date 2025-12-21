using Dayone.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.BLL
{
    public class BLL_Diem
    {
        private static BLL_Diem instance;
        public static BLL_Diem Instance
        {
            get { if (instance == null) instance = new BLL_Diem(); return BLL_Diem.instance; }
            private set => instance = value;
        }
        private BLL_Diem() { }

        public DataTable DanhSach()
        {
            return DAL.DAL_Diem.Instance.DanhSach();
        }

        public bool Them(string MaSV, string MaLopHocPhan, int PhanTramTrenLop, int PhanTramThi, float DiemTrenLop, float DiemThi, float DiemTB, string Loai)
        {
            return DAL_Diem.Instance.Them(MaSV, MaLopHocPhan, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai);
        }

        public bool Sua(string MaSV, string MaLopHocPhan, int PhanTramTrenLop, int PhanTramThi, float DiemTrenLop, float DiemThi, float DiemTB, string Loai, int id)
        {
            return DAL_Diem.Instance.Sua(MaSV, MaLopHocPhan, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai, id);
        }

        public bool Xoa(int id)
        {
            return DAL_Diem.Instance.Xoa(id);
        }

        // Method mới: Lấy danh sách sinh viên theo lớp học phần
        public DataTable LaySinhVienTheoLopHocPhan(string MaLopHocPhan)
        {
            return DAL_Diem.Instance.LaySinhVienTheoLopHocPhan(MaLopHocPhan);
        }

        // Method mới: Lấy danh sách điểm theo lớp học phần
        public DataTable LayDiemTheoLopHocPhan(string MaLopHocPhan)
        {
            return DAL_Diem.Instance.LayDiemTheoLopHocPhan(MaLopHocPhan);
        }

        // Method mới: Kiểm tra sinh viên đã đăng ký lớp học phần chưa
        public bool KiemTraSinhVienDaDangKy(string MaSV, string MaLopHocPhan)
        {
            return DAL_Diem.Instance.KiemTraSinhVienDaDangKy(MaSV, MaLopHocPhan);
        }
    }
}