using TestDapper.Model;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace TestDapper.Controller.Database
{
    public class Seller_Controller
    {
        public Seller_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Sellers = connection.GetAll<Seller>() as List<Seller>;
            connection.Close();
        }
        public void Add(Seller obj, SqlConnection connection)
        {
            Sellers.Add(obj);
            connection.Insert<Seller>(obj);
        }

        public Seller this[int index]
        {
            get => Sellers[index];
            private set => Sellers[index] = value;
        }

        public List<Seller> Sellers{ get; private set; }
    }
}
