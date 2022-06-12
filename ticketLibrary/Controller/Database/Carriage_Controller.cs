using TestDapper.Model;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data.SqlClient;

namespace TestDapper.Controller.Database
{
    public class Carriage_Controller
    {
        public Carriage_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Carriages = connection.GetAll<Carriage>() as List<Carriage>;
            connection.Close();
        }

        public void Add(Carriage obj, SqlConnection connection)
        {
            Carriages.Add(obj);
            connection.Insert<Carriage>(obj);
        }

        public Carriage this[int index]
        {
            get => Carriages[index];
            private set => Carriages[index] = value;
        }

        public List<Carriage> Carriages { get; private set; }
    }
}
