using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("CarriageType")]
    class CarriageTypeModel
    {
        public CarriageTypeModel()
        {}

        public CarriageTypeModel(int Id, 
        string Type)
        {
            this.Id = Id;
            this.Type = Type;
        }

        [Key] public int Id { get; set; }
        public string? Type { get; set; }

        // TODO: Implement table data
    }
}