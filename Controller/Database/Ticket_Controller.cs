using TestDapper.Model;
using Dapper.Contrib.Extensions;

namespace TestDapper.Controller.Database
{
    public class Ticket_Controller
    {
        public Ticket_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Tickets = connection.GetAll<Ticket>() as List<Ticket>;
        }
        public void Add(Ticket obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            Tickets.Add(obj);
            connection.Insert<Ticket>(obj);
        }

        public Ticket this[int index]
        {
            get => Tickets[index];
            private set => Tickets[index] = value;
        }

        private List<Ticket> Tickets;
    }
}
