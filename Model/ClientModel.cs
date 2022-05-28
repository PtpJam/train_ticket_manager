using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Client")]
    class ClientModel
    {
        public ClientModel()
        {}

        public ClientModel(int Id, 
        int Passport,
        int PhoneNumber,
        string Email)
        {
            this.Id = Id;
            this.Passport = Passport;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }

        [Key] public int Id { get; set; }
        public int Passport { get; set; }
        public int PhoneNumber { get; set; }
        public string? Email { get; set; }

        // TODO: Implement table data
    }
}