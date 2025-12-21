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
                    string ngaysinh = row["ngaysinh"].ToString();
                    string gioitinh = row["gioitinh"].ToString().Trim();
                    string quequan = row["quequan"].ToString().Trim();
                    string ngaynh = row["ngaynh"].ToString();
                    string malop = row["malop"].ToString().Trim();
                    string makhoa = row["makhoa"].ToString().Trim();
                    string macvht = row["macvht"].ToString().Trim();
                    string anh = row["anh"].ToString().Trim();



                    // Nếu trùng mã SV thì bỏ qua
                    if (DAL_SinhVien.Instance.TonTaiMaSV(masv))
                    {
                        result.ErrorCount++;
                        result.ErrorLines.Add($"Trùng maSV: {masv}");
                        continue;
                    }

                    bool ok = DAL_SinhVien.Instance.Them(masv, tensv, ngaysinh, gioitinh, quequan, ngaynh, malop, makhoa, macvht,anh);

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
