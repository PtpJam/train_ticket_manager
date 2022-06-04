using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Staff")]
    class StaffModel
    {
        public StaffModel()
        {}

        public StaffModel(int id, string Staff_type)
        {
            this.Id = id;
            this.Staff_type = Staff_type;
        }

        [Key] public int Id { get; set; }
        public string? Staff_type { get; set;}

        // TODO: Implement table data
    }
}