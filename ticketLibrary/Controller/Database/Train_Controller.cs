using TestDapper.Model;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace TestDapper.Controller.Database
{
    public class Train_Controller
    {
        public Train_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Trains = connection.GetAll<Train>() as List<Train>;

            connection.Close();
        }
        public void Add(Train obj, SqlConnection connection)
        {
            Trains.Add(obj);
            connection.Insert<Train>(obj);
        }

        public Train this[int index]
        {
            get => Trains[index];
            private set => Trains[index] = value;
        }

        public List<Train> Trains{ get; private set; }
    }
}
