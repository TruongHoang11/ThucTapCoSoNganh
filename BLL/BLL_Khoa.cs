using Dayone.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.BLL
{
    public class BLL_Khoa
    {
        private static BLL_Khoa instance; // ctr + r + e
        public static BLL_Khoa Instance
        {
            get { if (instance == null) instance = new BLL_Khoa(); return instance; }
            private set => instance = value;
        }

        private BLL_Khoa() { }

        public DataTable DanhSach()
        {
            return DAL_Khoa.Instance.DanhSach();
        }

        public bool Them(string makhoa, string tenkhoa)
        {

            return DAL_Khoa.Instance.Them(makhoa, tenkhoa);
            //return true;
            // return DAL_TaiKhoan.Instance.Them(ten, matkhau, loai);
        }

        public bool Sua(string makhoa, string tenkhoa, int id)
        {
            return DAL_Khoa.Instance.Sua(makhoa, tenkhoa, id);
        }

        public bool Xoa(int id)
        {
            return DAL_Khoa.Instance.Xoa(id);
        }
    }
}
