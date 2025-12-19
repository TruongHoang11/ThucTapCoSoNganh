using Dayone.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.BLL
{
    public class BLL_Excel
    {
        DAL_Excel dalExcel = new DAL_Excel();

        //public bool ImportSinhVienToDatabase(string filepath)
        //{
        //    DataTable dt = dalExcel.ReadExcel(filepath);
        //    if (dt == null || dt.Rows.Count == 0)
        //        throw new Exception("Không có dữ liệu trong Excel!");

        //    bool result = true;

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        string masv = row["masv"].ToString();
        //        string tensv = row["tensv"].ToString();
        //        DateTime ngaysinh = Convert.ToDateTime(row["ngaysinh"]);
        //        string gioitinh = row["gioitinh"].ToString();
        //        string quequan = row["quequan"].ToString();
        //        DateTime ngaynhaphoc = Convert.ToDateTime(row["ngaynh"]);
        //        string malop = row["malop"].ToString().Trim();
        //        string makhoa = row["makhoa"].ToString().Trim();
        //        string macvht = row["macvht"].ToString().Trim();

        //        bool kq = BLL_SinhVien.Instance.Them(
        //            masv, tensv, ngaysinh, gioitinh, quequan, ngaynhaphoc, malop, makhoa, macvht
        //        );

        //        if (!kq) result = false;
        //    }
        //    return result;
        //}
        public ImportResult ImportSinhVienToDatabase(string filePath)
        {
            ImportResult result = new ImportResult();

            //DataTable dt = DAL_Excel.Instance.ReadExcel(filePath);
            DataTable dt = dalExcel.ReadExcel(filePath);

            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    string masv = row["masv"].ToString().Trim();
                    string tensv = row["tensv"].ToString().Trim();
                    DateTime ngaysinh = DateTime.Parse(row["ngaysinh"].ToString());
                    string gioitinh = row["gioitinh"].ToString().Trim();
                    string quequan = row["quequan"].ToString().Trim();
                    DateTime ngaynh = DateTime.Parse(row["ngaynh"].ToString());
                    string malop = row["malop"].ToString().Trim();
                    string makhoa = row["makhoa"].ToString().Trim();
                    string macvht = row["macvht"].ToString().Trim();

                    // Nếu trùng mã SV thì bỏ qua
                    if (DAL_SinhVien.Instance.TonTaiMaSV(masv))
                    {
                        result.ErrorCount++;
                        result.ErrorLines.Add($"Trùng maSV: {masv}");
                        continue;
                    }

                    bool ok = DAL_SinhVien.Instance.Them(masv, tensv, ngaysinh, gioitinh, quequan, ngaynh, malop, makhoa, macvht);

                    if (ok)
                        result.SuccessCount++;
                    else
                    {
                        result.ErrorCount++;
                        result.ErrorLines.Add($"Không thể thêm: {masv}");
                    }
                }
                catch (Exception ex)
                {
                    result.ErrorCount++;
                    result.ErrorLines.Add($"Lỗi dòng data: {ex.Message}");
                }
            }

            return result;
        }
    }
}
