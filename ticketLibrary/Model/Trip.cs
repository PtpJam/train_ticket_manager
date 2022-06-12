using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Trip")]
    public class Trip
    {
        public Trip()
        {}
        
        public Trip(
            int Id, 
            string? Destination,
            string? From, 
            string? Time_in_trip, 
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
        public string? Time_in_trip { get; set; }
        public int? Train_id { get; set; }

        public override string ToString()
        {
            if (Train_id is not null)
                return $"{Id,-20} {Destination,-5} {From,-5} {Time_in_trip,-5} {Train_id,-5}";
            else 
                return "Class Train is null!";
        }
    }
}