using Dayone.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.BLL
{
    public class BLL_TaiKhoan
    {
        private static BLL_TaiKhoan instance; // ctr + r + e
        public static BLL_TaiKhoan Instance
        {
            get { if (instance == null) instance = new BLL_TaiKhoan(); return instance; }
            private set => instance = value;
        }

        private BLL_TaiKhoan() { }

        public DataTable DanhSach()
        {
            return DAL_TaiKhoan.Instance.DanhSach();
        }

        public bool them(string ten, string matkhau, string loai)
        {

            matkhau = HeThong.Hash(matkhau);
            return DAL_TaiKhoan.Instance.Them(ten, matkhau, loai);
            //return true;
            // return DAL_TaiKhoan.Instance.Them(ten, matkhau, loai);
        }

        public bool SuaHet(string ten, string matkhau, string loai,int id)
        {
            matkhau = HeThong.Hash(matkhau);
            return DAL_TaiKhoan.Instance.Sua_Het(ten, matkhau, loai, id);
        }

        public bool KhongSuaMatKhau(string ten, string loai, int id)
        {
            return DAL_TaiKhoan.Instance.KhongSuaMatKhau(ten, loai, id);
        }

        public bool Xoa( int id)
        {
            return DAL_TaiKhoan.Instance.Xoa( id);
        }

        public bool DangNhap(string ten, string matkhau)
        {
            matkhau = HeThong.Hash(matkhau);

            DataTable dulieu = DAL_TaiKhoan.Instance.DangNhap(ten, matkhau);

            if (dulieu.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                HeThong.TENDANGNHAP = ten;
                HeThong.LOAITAIKHOAN = dulieu.Rows[0]["LoaiTaiKhoan"].ToString().Trim();
            }

            return true;
        }


    }
}
