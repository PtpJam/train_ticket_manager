using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Carriage")]
    class CarriageModel
    {
        public CarriageModel()
        {}

        public CarriageModel(int Id, 
        int Capacity, 
        int Mass, 
        int CarriageType)
        {
            this.Id = Id;
            this.Capacity = Capacity;
            this.Mass = Mass;
            this.CarriageType = CarriageType;
        }

        [Key] public int Id { get; set; }
        public int Capacity { get; set; }
        public int Mass { get; set; }
        public int CarriageType { get; set; }

        // TODO: Implement table data
    }
}