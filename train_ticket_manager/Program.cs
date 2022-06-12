using System.Data.SqlClient;
using TestDapper.Controller;
using TestDapper.Model;
using TestDapper.TrainManager;
using TestDapper.Controller.Database;

namespace TestDapper // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Manager manager = new Manager();
            manager.BuyTicket(connection);
            //manager.PrintTrainsTable();

            // Carriage_type type = new Carriage_type(1, "drive_Test");
            // Carriage_type_Controller _Controller = new Carriage_type_Controller();
            // _Controller.Add(type);

            // do something

            connection.Close();
        }
    }
}