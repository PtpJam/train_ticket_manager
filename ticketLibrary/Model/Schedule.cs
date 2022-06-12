using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Schedule")]
    public class Schedule
    {
        public Schedule()
        {}

        public Schedule(int Id, 
            int Trip, 
            int Train, 
            int Track,
            string Departure, 
            string Arrival
        )
        {
            this.Id = Id;
            this.Trip = Trip;
            this.Train = Train;
            this.Track = Track;
            this.Departure = Departure;
            this.Arrival = Arrival;
        }

        [Key] public int Id { get; set; }
        public int Trip { get; set; }
        public int Train { get; set; }
        public int Track { get; set; }
        public string? Departure { get; set; }
        public string? Arrival { get; set; }


        // TODO: Implement table data
    }
}