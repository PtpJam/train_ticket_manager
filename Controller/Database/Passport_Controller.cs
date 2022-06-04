using TestDapper.Model;
using Dapper.Contrib.Extensions;

namespace TestDapper.Controller.Database
{
    public class Passport_Controller
    {
        public Passport_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Passports = connection.GetAll<Passport>() as List<Passport>;
        }
        public void Add(Passport obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            Passports.Add(obj);
            connection.Insert<Passport>(obj);
        }

        public Passport this[int index]
        {
            get => Passports[index];
            private set => Passports[index] = value;
        }

        private List<Passport> Passports;
    }
}
