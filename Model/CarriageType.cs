using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("CarriageType")]
    class CarriageType
    {
        public CarriageType()
        {}

        public CarriageType(
            int Id, 
            string Type
        )
        {
            this.Id = Id;
            this.Type = Type;
        }

        [Key] public int Id { get; set; }
        public string? Type { get; set; }

        // TODO: Implement table data
    }
}