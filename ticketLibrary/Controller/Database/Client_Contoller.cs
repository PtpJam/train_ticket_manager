using TestDapper.Model;
using Dapper.Contrib.Extensions;

namespace TestDapper.Controller.Database
{
    public class Client_Controller
    {
        public Client_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Clients = connection.GetAll<Client>() as List<Client>;
        }
        public void Add(Client obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            Clients.Add(obj);
            connection.Insert<Client>(obj);
        }

        public Client this[int index]
        {
            get => Clients[index];
            private set => Clients[index] = value;
        }

        private List<Client> Clients;
    }
}
