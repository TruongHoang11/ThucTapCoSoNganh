using Dayone.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.BLL
{
    public class BLL_LopHocPhan
    {
        private static BLL_LopHocPhan instance; // ctr + r + e
        public static BLL_LopHocPhan Instance
        {
            get { if (instance == null) instance = new BLL_LopHocPhan(); return instance; }
            private set => instance = value;
        }

        private BLL_LopHocPhan() { }

        public DataTable DanhSach()
        {
            return DAL_LopHocPhan.Instance.DanhSach();
        }

        public bool Them(string MaLopHocPhan, string MaMH, string TenLopHocPhan, int NamHoc, int SoLuong)
        {
            return DAL_LopHocPhan.Instance.Them( MaLopHocPhan,  MaMH,  TenLopHocPhan,  NamHoc,  SoLuong);
        }

        public bool Sua(string MaLopHocPhan, string MaMH, string TenLopHocPhan, int NamHoc, int SoLuong, int id)
        {
            return DAL_LopHocPhan.Instance.Sua( MaLopHocPhan,  MaMH,  TenLopHocPhan,  NamHoc,  SoLuong, id);
        }

        public bool Xoa(int id)
        {
            return DAL_LopHocPhan.Instance.Xoa(id);
        }
    }
}
