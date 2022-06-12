using TestDapper.Model;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace TestDapper.Controller.Database
{
    public class Schedule_Controller
    {
        public Schedule_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Schedules = connection.GetAll<Schedule>() as List<Schedule>;
            connection.Close();
        }

        public void Add(Schedule obj, SqlConnection connection)
        {  
            Schedules.Add(obj);
            connection.Insert<Schedule>(obj);
        }

        public Schedule this[int index]
        {
            get => Schedules[index];
            private set => Schedules[index] = value;
        }

        public  List<Schedule> Schedules{ get; private set; }
    }
}
