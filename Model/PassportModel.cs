using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Passport")]
    class PassportModel
    {
        public PassportModel()
        {}

        public PassportModel(int Id, 
        string Issue_place, 
        int Serial_number, 
        string Name,
        string Father_name,
        string Surname, int Staff_id)
        {
            this.Id = Id;
            this.Issue_place = Issue_place;
            this.Serial_number = Serial_number;
            this.Father_name = Father_name;
            this.Surname = Surname;
            this.Name = Name;
            this.Staff_id = Staff_id;
        }

        [Key] public int Id { get; set; }
        public string? Issue_place { get; set; }
        public int Serial_number { get; set; }
        public string? Surname { get; set; }
        public string? Father_name { get; set; }
        public string? Name { get; set; }
        public int Staff_id { get; set; }


        // TODO: Implement table data
    }
}