using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Ticket")]
    public class Ticket
    {
        public Ticket()
        {}

        public Ticket(int Id, 
            int Schedule, 
            int Carriage
        )
        {
            this.Id = Id;
            this.Schedule = Schedule;
            this.Carriage = Carriage;
        }

        [Key] public int Id { get; set; }
        public int Schedule { get; set; }
        public int Carriage { get; set; }

        // TODO: Implement table data
    }
}