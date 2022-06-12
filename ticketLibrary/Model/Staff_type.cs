using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Staff_type")]
    public class Staff
    {
        public Staff()
        {}

        public Staff(
            int id, 
            string Staff_type
        )
        {
            this.Id = id;
            this.Name = Staff_type;
        }

        [Key] public int Id { get; set; }
        public string? Name { get; set;}

        public override string ToString()
        {
            return $"Id: {Id,  -5} Name: {Name}";
        }

        // TODO: Implement table data
    }
}