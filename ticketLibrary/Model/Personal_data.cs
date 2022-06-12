using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Personal_data")]
    public class Personal_data
    {
        public Personal_data() {}
        public Personal_data(
            int Id,
            string Name,
            string Last_name,
            string Father_name,
            int Age
        )
        {
            this.Id = Id;
            this.Name = Name;
            this.Last_name = Last_name;
            this.Father_name = Father_name;
            this.Age = Age;
        }

        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Last_name { get; set; }
        public string Father_name { get; set; }
        public int Age { get; set; }

    }
}
