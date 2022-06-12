using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Threading;
//using TestDapper.Controller.Json;

namespace TestDapper.Controller
{
    public class DatabaseConnection
    {
        public DatabaseConnection(JsonModel json)
        {
            connection = new SqlConnection($"Data Source={json.Source},{json.Port};Initial Catalog={json.DatabaseName};User Id={json.UserId};Password={json.Password}");
        }

        public SqlConnection connection { get; set; }

        private static DatabaseConnection? _DatabaseConnection;

        private static readonly object _lock = new object();

        public static DatabaseConnection GetInstance(JsonModel json)
        {
            if (_DatabaseConnection == null)
            {
                lock(_lock)
                {
                    if (_DatabaseConnection == null)
                    {
                        _DatabaseConnection = new DatabaseConnection(json);
                    }
                }
            }
            return _DatabaseConnection;
        }
    }
}