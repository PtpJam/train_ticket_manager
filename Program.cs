using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Dapper.Contrib;
using TestDapper;
using TestDapper.Controller;

namespace TestDapper // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControllerJson controller = new ControllerJson();
            SqlConnection connection = new DatabaseConnection(controller.jsonModel).connection;

            // do something

            connection.Close();
        }
    }
}