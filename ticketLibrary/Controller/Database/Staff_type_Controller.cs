using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using TestDapper.Model;
using System.Data.SqlClient;

namespace TestDapper.Controller.Database
{
    public class Staff_Controller
    {
        public Staff_Controller()
        {
            SqlConnection connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            StaffTypes = connection.GetAll<Staff>() as List<Staff>;
            connection.Close();
        }

        public void Add(Staff obj, SqlConnection connection)
        {
            StaffTypes.Add(obj);
            connection.Insert<Staff>(obj);
        }

        public Staff this[int index]
        {
            get => StaffTypes[index];
            private set => StaffTypes[index] = value;
        }

        public List<Staff> StaffTypes { get; private set; }
        
    }
}
