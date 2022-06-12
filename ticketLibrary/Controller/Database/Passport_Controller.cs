using TestDapper.Model;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace TestDapper.Controller.Database
{
    public class Passport_Controller
    {
        public Passport_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Passports = connection.GetAll<Passport>() as List<Passport>;
            connection.Close();
        }
        public void Add(Passport obj, SqlConnection connection)
        {
            Passports.Add(obj);
            connection.Insert<Passport>(obj);
            // string sqlExpression = $"INSERT INTO Passport (Issue_place, Serial_number, Surname, Father_name, Name, Staff_id) VALUES (\'{obj.Issue_place}\', {obj.Serial_number}, \'{obj.Surname}\', \'{obj.Father_name}\', \'{obj.Name}\', {obj.Staff_id});";
            // connection.Open();
            // SqlCommand command = new SqlCommand(sqlExpression, connection);
            // command.ExecuteNonQuery();
        }

        public Passport this[int index]
        {
            get => Passports[index];
            private set => Passports[index] = value;
        }

        public List<Passport> Passports{ get; private set; }
    }
}
