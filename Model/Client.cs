using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Client")]
    class Client
    {
        public Client()
        {}

        public Client(int Id, 
            int Passport,
            int Phone_number,
            string Email
        )
        {
            this.Id = Id;
            this.Passport = Passport;
            this.Phone_number = Phone_number;
            this.Email = Email;
        }

        [Key] public int Id { get; set; }
        public int Passport { get; set; }
        public int Phone_number { get; set; }
        public string? Email { get; set; }

        // TODO: Implement table data
    }
}