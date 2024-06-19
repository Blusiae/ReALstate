using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ReALstate.App.Data.Entities
{
    public class Offer
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(Customer))]
        public int CustomerId { get; set; }
        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public Customer Customer { get; set; } = default!;
        [ForeignKey(typeof(Estate))]
        public int EstateId { get; set; }
        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public Estate Estate { get; set; } = default!;
        public double ProposedPrice { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
