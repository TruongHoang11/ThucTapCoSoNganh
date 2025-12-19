using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.DAL
{
    public class DAL_Excel
    {
        public DataTable ReadExcel(string filepath)
        {
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filepath, FileMode.Open, FileAccess.Read))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                });

                return result.Tables[0]; // sheet 1
            }
        }

        
    }
}
