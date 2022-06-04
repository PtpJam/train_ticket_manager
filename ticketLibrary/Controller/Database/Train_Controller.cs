using TestDapper.Model;
using Dapper.Contrib.Extensions;

namespace TestDapper.Controller.Database
{
    public class Train_Controller
    {
        public Train_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Trains = connection.GetAll<Train>() as List<Train>;
        }
        public void Add(Train obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            Trains.Add(obj);
            connection.Insert<Train>(obj);
        }

        public Train this[int index]
        {
            get => Trains[index];
            private set => Trains[index] = value;
        }

        private List<Train> Trains;
    }
}
