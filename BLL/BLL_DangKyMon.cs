using Dayone.DAL;
using System;
using System.Data;

namespace Dayone.BLL
{
    public class BLL_DangKyMon
    {
        private static BLL_DangKyMon instance;
        public static BLL_DangKyMon Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLL_DangKyMon();
                return instance;
            }
        }

        // ================= ĐĂNG KÝ MÔN =================
        public bool DangKy(string maSV, string maLopHocPhan)
        {
            if (DAL_DangKyMon.Instance.DaDangKy(maSV, maLopHocPhan))
                return false;

            return DAL_DangKyMon.Instance.DangKy(
                maSV,
                maLopHocPhan,
                DateTime.Now
            );
        }


        // ================= DANH SÁCH =================
        //public DataTable DanhSachTheoSV(string maSV)
        //{
        //    return DAL_DangKyMon.Instance.DanhSachTheoSV(maSV);
        //}
        public DataTable GetSinhVienByLopHocPhan(string maLopHP)
        {
            return DAL_DangKyMon.Instance.GetSinhVienByLopHocPhan(maLopHP);
        }

        public DataTable GetLopHocPhan()
        {
            return DAL_DangKyMon.Instance.GetLopHocPhan();
        }
        // ================= DANH SÁCH TẤT CẢ =================
        public DataTable DanhSachTatCa()
        {
            return DAL_DangKyMon.Instance.DanhSachTatCa();
        }
    }
}
