using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Dayone.DAL
{
    public class DAL_KetNoi
    {
        private static DAL_KetNoi instance;
        public static DAL_KetNoi Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_KetNoi();
                return instance;
            }
        }

        private string connectionString =




            @"Data Source=HUY-TIEN\SQLEXPRESS;Initial Catalog=QL_SVNEW1111;Integrated Security=True";
        //jkfjasljasl



        public string ConnectionString
        {
            get { return connectionString; }
        }

        private DAL_KetNoi() { }

        // =====================================================
        // ==================== QUERY ==========================
        // =====================================================

        // 👉 CÁCH CŨ (object[])
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    var matches = Regex.Matches(query, @"@\w+");
                    int i = 0;
                    foreach (Match m in matches)
                    {
                        cmd.Parameters.AddWithValue(m.Value, parameter[i]);
                        i++;
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
            }

            return data;
        }

        // 👉 CÁCH MỚI (Dictionary)
        //public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters)
        //{
        //    DataTable data = new DataTable();

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(query, conn);

        //        foreach (var p in parameters)
        //        {
        //            cmd.Parameters.AddWithValue(p.Key, p.Value);
        //        }

        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        adapter.Fill(data);
        //    }

        //    return data;
        //}
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            DataTable data = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
            }

            return data;
        }


        // =====================================================
        // ================= NON QUERY =========================
        // =====================================================

        public bool ExecuteNonQuery(string query, object[] parameter = null)
        {
            int result;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    var matches = Regex.Matches(query, @"@\w+");
                    int i = 0;
                    foreach (Match m in matches)
                    {
                        cmd.Parameters.AddWithValue(m.Value, parameter[i]);
                        i++;
                    }
                }

                result = cmd.ExecuteNonQuery();
            }

            return result > 0;
        }

        public bool ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            int result;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                foreach (var p in parameters)
                {
                    cmd.Parameters.AddWithValue(p.Key, p.Value);
                }

                result = cmd.ExecuteNonQuery();
            }

            return result > 0;
        }

        // =====================================================
        // =================== SCALAR ==========================
        // =====================================================

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object result;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    var matches = Regex.Matches(query, @"@\w+");
                    int i = 0;
                    foreach (Match m in matches)
                    {
                        cmd.Parameters.AddWithValue(m.Value, parameter[i]);
                        i++;
                    }
                }

                result = cmd.ExecuteScalar();
            }

            return result;
        }

        public object ExecuteScalar(string query, Dictionary<string, object> parameters)
        {
            object result;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                foreach (var p in parameters)
                {
                    cmd.Parameters.AddWithValue(p.Key, p.Value);
                }

                result = cmd.ExecuteScalar();
            }

            return result;
        }
    }
}
