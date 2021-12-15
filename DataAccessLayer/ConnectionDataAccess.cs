using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ConnectionDataAccess
    {
        string _connecitonstring = "Server=(localdb)\\MSSQLLocalDB;Database=TicaretUygulamasiDB;Trusted_Connection=true";
        public ConnectionDataAccess(string query)
        {
            _conn = new SqlConnection(_connecitonstring);
            _cmd = _conn.CreateCommand();
            _cmd.CommandText = query;
        }

        public SqlCommand _cmd { get; set; }
        public SqlConnection _cnnacs { get; set; }
        public SqlConnection _conn;


    }
}
