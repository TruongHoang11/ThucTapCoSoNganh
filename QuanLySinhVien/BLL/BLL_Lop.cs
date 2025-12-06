using QuanLySinhVien.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    public class BLL_Lop
    {
        private static BLL_Lop instance; // ctr + r + e
        public static BLL_Lop Instance
        {
            get { if (instance == null) instance = new BLL_Lop(); return instance; }
            private set => instance = value;
        }

        private BLL_Lop() { }

        public DataTable DanhSach()
        {
            return DAL_Lop.Instance.DanhSach();
        }

        public bool Them(string malop, string tenlop, int soluong, string makhoa)
        {
            return DAL_Lop.Instance.Them(malop, tenlop, soluong, makhoa);
        }

        public bool Sua(string malop, string tenlop, int soluong, string makhoa, int id)
        {
            return DAL_Lop.Instance.Sua(malop, tenlop, soluong, makhoa, id);
        }

        public bool Xoa(int id)
        {
            return DAL_Lop.Instance.Xoa(id);
        }
    }
}
