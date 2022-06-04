using TestDapper.Model;
using Dapper.Contrib.Extensions;

namespace TestDapper.Controller.Database
{
    public class Personal_data_Controller
    {
        public Personal_data_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Personal_Data = connection.GetAll<Personal_data>() as List<Personal_data>;
        }
        public void Add(Personal_data obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            Personal_Data.Add(obj);
            connection.Insert<Personal_data>(obj);
        }

        public Personal_data this[int index]
        {
            get => Personal_Data[index];
            private set => Personal_Data[index] = value;
        }

        private List<Personal_data> Personal_Data;
    }
}
