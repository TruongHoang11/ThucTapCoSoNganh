using Dayone.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.BLL
{
    public class BLL_MonHoc
    {
        private static BLL_MonHoc instance;
        public static BLL_MonHoc Instance
        {
            get { if (instance == null) instance = new BLL_MonHoc(); return BLL_MonHoc.instance; }
            private set => instance = value;

        }
        private BLL_MonHoc() { }
        public DataTable DanhSach()
        {
            return DAL.DAL_MonHoc.Instance.DanhSach();
        }
        public bool Them(string MaMH, string TenMH, int SoTC, int TietLT, int TietTH)
        {
            return DAL.DAL_MonHoc.Instance.Them(MaMH, TenMH, SoTC, TietLT, TietTH);
        }
        public bool Sua(string MaMH, string TenMH, int SoTC, int TietLT, int TietTH, int id)
        {
            return DAL.DAL_MonHoc.Instance.Sua(MaMH, TenMH, SoTC, TietLT, TietTH, id);
        }
        public bool Xoa(int id)
        {
            return DAL.DAL_MonHoc.Instance.Xoa(id);
        }
       
    }
}
