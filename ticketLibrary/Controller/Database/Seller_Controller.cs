using TestDapper.Model;
using Dapper.Contrib.Extensions;

namespace TestDapper.Controller.Database
{
    public class Seller_Controller
    {
        public Seller_Controller()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Sellers = connection.GetAll<Seller>() as List<Seller>;
        }
        public void Add(Seller obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            Sellers.Add(obj);
            connection.Insert<Seller>(obj);
        }

        public Seller this[int index]
        {
            get => Sellers[index];
            private set => Sellers[index] = value;
        }

        private List<Seller> Sellers;
    }
}
