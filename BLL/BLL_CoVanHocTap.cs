using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.BLL
{
    public class BLL_CoVanHocTap
    {
        private static BLL_CoVanHocTap instance;
        public static BLL_CoVanHocTap Instance
        {
            get { if (instance == null) instance = new BLL_CoVanHocTap(); return BLL_CoVanHocTap.instance; }
            private set => instance = value;

        }
        private BLL_CoVanHocTap() { }
        public DataTable DanhSach()
        {
            return DAL.DAL_CoVanHocTap.Instance.DanhSach();
        }
        public bool Them(string macovan, string tencovan, string ngaysinh, string gioitinh, string makhoa, string malop)
        {
            return DAL.DAL_CoVanHocTap.Instance.Them(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop);
        }
        public bool Sua(string macovan, string tencovan, string ngaysinh, string gioitinh, string makhoa, string malop, int id)
        {
            return DAL.DAL_CoVanHocTap.Instance.Sua(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop, id);
        }
        public bool Xoa(int id)
        {
            return DAL.DAL_CoVanHocTap.Instance.Xoa(id);
        }
    }
}
