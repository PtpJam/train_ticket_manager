using System.Data.SqlClient;
using TestDapper.Controller;

namespace TestDapper // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            // do something

            connection.Close();
        }
    }
}