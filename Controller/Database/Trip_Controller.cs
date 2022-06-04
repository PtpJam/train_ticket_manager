using TestDapper.Model;
using Dapper.Contrib.Extensions;

namespace TestDapper.Controller.Database
{
    public class Trip_Controller
    {
        public Trip_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Trips = connection.GetAll<Trip>() as List<Trip>;
        }
        public void Add(Trip obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            Trips.Add(obj);
            connection.Insert<Trip>(obj);
        }

        public Trip this[int index]
        {
            get => Trips[index];
            private set => Trips[index] = value;
        }

        private List<Trip> Trips;
    }
}
