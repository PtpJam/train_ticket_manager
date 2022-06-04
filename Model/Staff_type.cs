using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Staff_type")]
    class Staff_type
    {
        public Staff_type()
        {}

        public Staff_type(
            int id, 
            string Staff_type
        )
        {
            this.Id = id;
            this.Name = Staff_type;
        }

        [Key] public int Id { get; set; }
        public string? Name { get; set;}

        // TODO: Implement table data
    }
}