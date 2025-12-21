using Dayone.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.BLL
{
    public class BLL_SinhVien
    {
        private static BLL_SinhVien instance;
        public static BLL_SinhVien Instance
        {
            get { if (instance == null) instance = new BLL_SinhVien(); return BLL_SinhVien.instance; }
            private set => instance = value;

        }
        private BLL_SinhVien() { }
        public DataTable DanhSach()
        {
            return DAL.DAL_SinhVien.Instance.DanhSach();
        }
        public bool Them(string masv, string tensv, DateTime ngaysinh, string gioitinh, string quequan, DateTime ngaynh, string makhoa, string malop, string macvht)
        {
            return DAL.DAL_SinhVien.Instance.Them(masv, tensv, ngaysinh, gioitinh,quequan, ngaynh, makhoa, malop, macvht);
        }
        public bool Sua(string masv, string tensv, DateTime ngaysinh, string gioitinh, string quequan, DateTime ngaynh, string makhoa, string malop, string macvht, int id)
        {
            return DAL.DAL_SinhVien.Instance.Sua(masv, tensv, ngaysinh, gioitinh, quequan, ngaynh, makhoa, malop, macvht, id);
        }
        public bool Xoa(int id)
        {
            return DAL.DAL_SinhVien.Instance.Xoa(id);
        }







    }
}
