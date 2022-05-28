using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Ticket")]
    class TicketModel
    {
        public TicketModel()
        {}

        public TicketModel(int Id, 
        int Schedule, 
        int Carriage, 
        int CarriageType)
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