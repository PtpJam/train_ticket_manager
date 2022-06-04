using TestDapper.Model;
using Dapper.Contrib.Extensions;

namespace TestDapper.Controller.Database
{
    public class Carriage_type_Controller
    {
        public Carriage_type_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Carriage_types = connection.GetAll<Carriage_type>() as List<Carriage_type>;
        }
        public void Add(Carriage_type obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            Carriage_types.Add(obj);
            connection.Insert<Carriage_type>(obj);
        }

        public Carriage_type this[int index]
        {
            get => Carriage_types[index];
            private set => Carriage_types[index] = value;
        }

        private List<Carriage_type> Carriage_types;
    }
}
