using TestDapper.Model;
using Dapper.Contrib.Extensions;

namespace TestDapper.Controller.Database
{
    public class Schedule_Controller
    {
        public Schedule_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Schedules = connection.GetAll<Schedule>() as List<Schedule>;
        }

        public void Add(Schedule obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            Schedules.Add(obj);
            connection.Insert<Schedule>(obj);
        }

        public Schedule this[int index]
        {
            get => Schedules[index];
            private set => Schedules[index] = value;
        }

        private List<Schedule> Schedules;
    }
}
