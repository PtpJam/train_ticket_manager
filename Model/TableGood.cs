using Dapper.Contrib.Extensions;

namespace TestDapper
{
    [Table ("Good")]
    public class TableGood
    {
        public TableGood()
        {
            
        }

        [Key]
        public int Id { get; set; }
        public int Price { get; set; }
        public string? Name { get; set;}
        public int Discount { get; set; }
        public string? Vendor { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Prce: {Price}, Name: {Name}, Discount: {Discount}, Vendor: {Vendor}";
        }
    }
}