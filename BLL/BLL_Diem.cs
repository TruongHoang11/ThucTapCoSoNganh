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
        public bool Them(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramThi, float DiemTrenLop, float DiemThi, float DiemTB, string Loai, int namhoc)
        {
            return DAL_Diem.Instance.Them(MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai, namhoc);
        }
        public bool Sua(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramThi, float DiemTrenLop, float DiemThi, float DiemTB, string Loai, int namhoc, int id)
        {
            return DAL_Diem.Instance.Sua(MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai, namhoc, id);
        }
        public bool Xoa(int id)
        {
            return DAL_Diem.Instance.Xoa(id);
        }
    }

}
