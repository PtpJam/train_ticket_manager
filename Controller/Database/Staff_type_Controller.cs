using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using TestDapper.Model;

namespace TestDapper.Controller.Database
{
    public class Staff_type_Controller
    {
        public Staff_type_Controller()
        {
            SqlConnection connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            StaffTypes = connection.GetAll<Staff_type>() as List<Staff_type>;
        }

        public void Add(Staff_type obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            StaffTypes.Add(obj);
            connection.Insert<Staff_type>(obj);
        }

        public Staff_type this[int index]
        {
            get => StaffTypes[index];
            private set => StaffTypes[index] = value;
        }

        private List<Staff_type> StaffTypes;
    }
}
