using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Schedule")]
    class Schedule
    {
        public Schedule()
        {}

        public Schedule(int Id, 
            int Trip, 
            int Train, 
            int Track,
            DateTime Departure, 
            DateTime Arrival
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
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }


        // TODO: Implement table data
    }
}