using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarnavalSuits
{
    public static class Globals
    {
        public static Logic logic;
        public static int valueMember;
    }

    public class Logic
    {
        public Logic(string dataSource, string catalog)
        {
            var connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;",
                dataSource, catalog);
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
        }

        SqlConnection connection;
        SqlCommand cmd;

        public void loadDgv(ref DataGridView dgv, string query)
        {
            var result = getDataTable(query);

            dgv.DataSource = result;
            dgv.Columns[0].Visible = false;
        }

        public DataTable getDataTable(string query)
        {
            var dt = new DataTable();
            connection.Open();
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            connection.Close();
            return dt;
        }

        public void executeNonQuery(string query)
        {
            connection.Open();
            using (cmd = new SqlCommand(query, connection))
            {
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
