using Npgsql;
using System.Data;

namespace Arkanoid.Controller
{
    public static class DataBaseConnection
    {
        private static readonly string host = "127.0.0.1";
        private static readonly string database = "Arkanoid_PH";
        private static readonly string userId = "postgres";
        private static readonly string password = "081416171819";
        private static readonly string sConnection =
            $"Server={host};Port=5432;User Id={userId};Password={password};Database={database};";

        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();

            connection.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);

            connection.Close();

            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }

    }
}
