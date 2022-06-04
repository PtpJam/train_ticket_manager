using TestDapper.Model;
using Dapper.Contrib.Extensions;

namespace TestDapper.Controller.Database
{
    public class Carriage_Controller
    {
        public Carriage_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Carriages = connection.GetAll<Carriage>() as List<Carriage>;
        }

        public void Add(Carriage obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            Carriages.Add(obj);
            connection.Insert<Carriage>(obj);
        }

        public Carriage this[int index]
        {
            get => Carriages[index];
            private set => Carriages[index] = value;
        }

        private List<Carriage> Carriages;
    }
}
