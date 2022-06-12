using TestDapper.Controller.Database;
using TestDapper.Controller;
using TestDapper.Model;
using System.Threading;
using System.Data.SqlClient;

namespace TestDapper.TrainManager
{
    public class Manager
    {
        public void PrintTrainsTable()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            connection.Open();
            Trip_Controller trip = new Trip_Controller();
            foreach (var item in trip.Trips)
                System.Console.WriteLine(item.ToString(), -5);

            connection.Close();
        }

        public void BuyTicket(System.Data.SqlClient.SqlConnection connection)
        {
            Carriage_type carriage_Type = new Carriage_type(1, "TestDapper");
            Carriage_type_Controller carriage_TypeController = new Carriage_type_Controller();
            carriage_TypeController.Add(carriage_Type, connection);
            System.Console.WriteLine("Carriage type passed ✔️");

            Carriage carriage = new Carriage(1, 1, 1, 3);
            Carriage_Controller carriage_Controller = new Carriage_Controller();
            carriage_Controller.Add(carriage, connection);
            System.Console.WriteLine("Carriage passed ✔️");

            Client client = new Client(1, 3, 234, "emailTest");
            Client_Controller client_Controller = new Client_Controller();
            client_Controller.Add(client, connection);
            System.Console.WriteLine("Client passed ✔️");

            Passport passport = new Passport(1, "test", 23, "test", "test", "test", 7);
            Passport_Controller passport_Controller = new Passport_Controller();
            passport_Controller.Add(passport, connection);
            System.Console.WriteLine("Passport passed ✔️");

            Personal_data personal_Data = new Personal_data(1, "test", "test", "Test", 34);
            Personal_data_Controller personal_Data_Controller = new Personal_data_Controller();
            personal_Data_Controller.Add(personal_Data, connection);
            System.Console.WriteLine("Personal_data passed ✔️");

            Schedule schedule = new Schedule(1, 4, 1, 34, "test", "Test");
            Schedule_Controller schedule_Controller = new Schedule_Controller();
            schedule_Controller.Add(schedule, connection);
            System.Console.WriteLine("Schedule passed ✔️");

            Seller seller = new Seller(1, "test", "Test", "Test", 5);
            Seller_Controller seller_Controller = new Seller_Controller();
            seller_Controller.Add(seller, connection);
            System.Console.WriteLine("Seller passed ✔️");

            Staff staff = new Staff(1, "test");
            Staff_Controller staff_Controller = new Staff_Controller();
            staff_Controller.Add(staff, connection);
            System.Console.WriteLine("Staff passed ✔️");

            Ticket ticket = new Ticket(1, 4, 2);
            Ticket_Controller ticket_Controller = new Ticket_Controller();
            ticket_Controller.Add(ticket, connection);
            System.Console.WriteLine("Ticket passed ✔️");

            Train train = new Train(1, 2, 4, 5);
            Train_Controller train_Controller = new Train_Controller();
            train_Controller.Add(train, connection);
            System.Console.WriteLine("Train passed ✔️");

            Trip trip = new Trip(1, "test", "test", "test", 1);
            Trip_Controller trip_Controller = new Trip_Controller();
            trip_Controller.Add(trip, connection);
            System.Console.WriteLine("Trip passed ✔️");

            System.Console.WriteLine("New trip added!");

        }
    }
}