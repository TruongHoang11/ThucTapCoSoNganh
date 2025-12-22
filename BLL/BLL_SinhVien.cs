using Dayone.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public DataTable GetSinhVienTheoLop(string maLop)
        {
            return DAL_SinhVien.Instance.GetSinhVienTheoLop(maLop);
        }

        private BLL_SinhVien() { }
        public DataTable DanhSach()
        {
            return DAL.DAL_SinhVien.Instance.DanhSach();
        }
        public bool Them(string masv, string tensv, string ngaysinh, string gioitinh, string quequan, string ngaynh, string malop,string makhoa, string macvht, string anh)
        {
            return DAL.DAL_SinhVien.Instance.Them(masv, tensv, ngaysinh, gioitinh,quequan, ngaynh, malop,makhoa , macvht, anh);
        }
        public bool Sua(string masv, string tensv, string ngaysinh, string gioitinh, string quequan, string ngaynh, string malop,string makhoa,  string macvht,string anh, int id)
        {
            return DAL.DAL_SinhVien.Instance.Sua(masv, tensv, ngaysinh, gioitinh, quequan, ngaynh, malop,makhoa, macvht,anh, id);
        }
        public bool Xoa(int id)
        {
            return DAL.DAL_SinhVien.Instance.Xoa(id);
        }

        //public DataTable TimKiem(string masv, string tensv)
        //{
        //    return DAL_SinhVien.Instance.TimKiem(masv, tensv);
        //}
        public DataTable TimKiem(
    string masv,
    string tensv,
    string quequan,
    string malop,
    string makhoa,
    string macvht
)
        {
            return DAL_SinhVien.Instance.TimKiem(
                masv,
                tensv,
                quequan,
                malop,
                makhoa,
                macvht
            );
        }

        //BLL_SinhVien bllSV = new BLL_SinhVien();
        


    }
}
