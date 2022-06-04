using Dapper.Contrib.Extensions;

namespace TestDapper.Model
{
    [Table("Train")]
    class Train
    {
        public Train()
        {}
        
        public Train(int Id, 
            int Carriage_id,
            int Amount_of_carriage, 
            int Staff_id
        )
        {
            this.Id = Id;
            this.Carriage_id = Carriage_id;
            this.Amount_of_carriage = Amount_of_carriage;
            this.Staff_id = Staff_id;
        }

        [Key] public int Id { get; set; }
        public int Carriage_id { get; set; }
        public int Amount_of_carriage { get; set; }
        public int Staff_id { get; set; }

        // TODO: Implement table data
    }
}