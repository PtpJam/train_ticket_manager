using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Trip")]
    class Trip
    {
        public Trip()
        {}
        
        public Trip(
            int Id, 
            string? Destination,
            string? From, 
            DateTime Time_in_trip, 
            int Train_id
        )
        {
            this.Id = Id;
            this.Destination = Destination;
            this.From = From;
            this.Time_in_trip = Time_in_trip;
            this.Train_id = Train_id;
        }

        [Key] public int Id { get; set; }
        public string? Destination { get; set; }
        public string? From { get; set; }
        public DateTime Time_in_trip { get; set;}
        public int Train_id { get; set;}

        // TODO: Implement table data
    }
}