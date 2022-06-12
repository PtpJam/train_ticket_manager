using System;
using TestDapper.Model;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace TestDapper.Controller.Database
{
    public class Trip_Controller
    {
        public Trip_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Trips = connection.GetAll<Trip>() as List<Trip>;
            connection.Close();
        }

        public void Add(Trip obj, SqlConnection connection)
        {
            Trips.Add(obj);
            connection.Insert<Trip>(obj);
            // string sqlExpression = $"INSERT INTO Trip ([Destination], [From], Time_in_trip, [Train_id]) VALUES (\'{obj.Destination}\', \'{obj.From}\', \'{obj.Time_in_trip}\', {obj.Train_id});";
            // connection.Open();
            // SqlCommand command = new SqlCommand(sqlExpression, connection);
            // command.ExecuteNonQuery();
        }

        public Trip this[int index]
        {
            get => Trips[index];
            private set => Trips[index] = value;
        }

        public List<Trip> Trips { get; private set; }
    }
}
