using System.Data;
using System.Data.SqlClient;

namespace Макет
{
    class DBConnect
    {
        static SqlConnection connection = new SqlConnection();

        static void openConnection()
        {
            connection.ConnectionString =
                "Data Source=DENIS-PC;Initial Catalog=HR_PI;User ID=den;Password=denis";
            connection.Open();
        }

        static void closeConnection()
        {
            connection.Close();
        }

        public static DataTable getTableAsDT(string query)
        {
            DataTable dt = new DataTable();
            using (connection)
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static void ExecuteNonQuery(string query)
        {
            openConnection();
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public static int ExecuteScalar(string query)
        {
            openConnection();
            int res = 0;
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                res = (int)cmd.ExecuteScalar();
            }
            connection.Close();
            return res;
        }
    }
}