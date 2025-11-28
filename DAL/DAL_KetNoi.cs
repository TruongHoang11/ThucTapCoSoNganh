using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.DAL
{
    public class DAL_KetNoi
    {
        //Chuỗi kết nối cơ sở dữ liệu
        private string connectionString =
            @"Data Source=LAPTOP-HSMJ4Q7E\MSSQLSERVER01; Initial Catalog=db_QLSV; Integrated Security=True;";

        private static DAL_KetNoi instance; // ctr + r + e
        public static DAL_KetNoi Instance
        {
            get { if (instance == null) instance = new DAL_KetNoi(); return instance; }
            private set => instance = value;
        }

        private DAL_KetNoi() { }

        // lấy danh sách 
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParams = query.Split(' ');

                    int i = 0;
                    foreach (string item in listParams)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }


        // thêm , sửa , xóa 
        public bool ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;

                    foreach (string item in listParams)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data > 0;
        }

    }

}