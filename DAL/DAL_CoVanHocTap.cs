using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.DAL
{
    public class DAL_CoVanHocTap
    {
        //private static DAL_CoVanHocTap instance;
        //public static DAL_CoVanHocTap Instance
        //{
        //    get { if (instance == null) instance = new DAL_CoVanHocTap(); return instance; }
        //    private set => instance = value;
        //}
        //private DAL_CoVanHocTap() { }
        private static DAL_CoVanHocTap _Instance;
        public static DAL_CoVanHocTap Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_CoVanHocTap();
                return _Instance;
            }
        }

        private DAL_CoVanHocTap() { }

        public bool Them(string MaCoVan, string TenCoVan, DateTime NgaySinh, string GioiTinh, string MaKhoa, string MaLop)
        {
            string sql = "insert into CoVanHocTap(MaCVHT, TenCVHT, NgaySinh, GioiTinh, MaKhoa, MaLop) values(@MaCVHT, @TenCVHT, @NgaySinh, @GioiTinh, @MaKhoa, @MaLop)";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaCoVan, TenCoVan, NgaySinh, GioiTinh, MaKhoa, MaLop });
        }
        public bool Sua(string MaCoVan, string TenCoVan, DateTime NgaySinh, string GioiTinh, string MaKhoa, string MaLop, int id)
        {
            string sql = "update CoVanHocTap set MaCVHT=@MaCVHT, TenCVHT = @TenCVHT, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, MaKhoa = @MaKhoa, MaLop = @MaLop where  id = @id";
            return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { MaCoVan, TenCoVan, NgaySinh, GioiTinh, MaKhoa, MaLop, id });
        }
        //public bool Xoa(int id)
        //{
        //    string sql = "delete from CoVanHocTap where id = @id";
        //    return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        //}
        public bool Xoa(int id)
        {
            try
            {
                string sql = "DELETE FROM CoVanHocTap WHERE Id = @id";
                return DAL_KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
            }
            catch (SqlException ex)
            {
                // lỗi khóa ngoại (FK)
                if (ex.Number == 547)
                {
                    return false; // báo về rằng không thể xóa
                }

                throw; // các lỗi khác vứt ra ngoài
            }
        }


        public DataTable DanhSach()
        {
            return DAL_KetNoi.Instance.ExcuteQuery("select * from CoVanHocTap");
        }
        public bool KiemTraTrung(string maCVHT)
        {
            string sql = "select * from CoVanHocTap where MaCVHT = @MaCVHT";
            DataTable dt = DAL_KetNoi.Instance.ExcuteQuery(sql, new object[] { maCVHT });

            return dt.Rows.Count > 0; // Có dòng → trùng
        }
        public DataTable TimKiem(
          string tenCV,
          DateTime? ngaySinh,
          string maLop,
          string maKhoa
      )
        {
            string sql = @"
        SELECT cv.*
        FROM CoVanHocTap cv
        INNER JOIN Lop l ON cv.MaLop = l.MaLop
        INNER JOIN Khoa k ON cv.MaKhoa = k.MaKhoa
        WHERE 1 = 1
    ";

            List<object> param = new List<object>();

            if (!string.IsNullOrEmpty(tenCV))
            {
                sql += " AND cv.TenCVHT LIKE @TenCV";
                param.Add("%" + tenCV + "%");
            }

            if (ngaySinh.HasValue)
            {
                sql += " AND CONVERT(date, cv.NgaySinh) = @NgaySinh";
                param.Add(ngaySinh.Value.Date);
            }

            if (!string.IsNullOrEmpty(maLop))
            {
                sql += " AND cv.MaLop = @MaLop";
                param.Add(maLop);
            }

            if (!string.IsNullOrEmpty(maKhoa))
            {
                sql += " AND cv.MaKhoa = @MaKhoa";
                param.Add(maKhoa);
            }

            return DAL_KetNoi.Instance.ExcuteQuery(sql, param.ToArray());
        }


        public bool KiemTraTrungKhiSua(string maCVHT, int id)
        {
            string sql = "select * from CoVanHocTap where MaCVHT = @MaCVHT and Id <> @Id";
            DataTable dt = DAL_KetNoi.Instance.ExcuteQuery(sql, new object[] { maCVHT, id });
            return dt.Rows.Count > 0;
        }

    }
}
