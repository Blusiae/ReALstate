using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ReALstate.App.Data
{
    internal class Offer
    {
        [PrimaryKey, AutoIncrement]
        internal int Id { get; set; }
        [ForeignKey(typeof(Customer))]
        internal int CustomerId { get; set; }
        [ManyToOne]
        internal Customer Customer { get; set; } = default!;
        [ForeignKey(typeof(Estate))]
        internal int EstateId { get; set; }
        [ManyToOne]
        internal Estate Estate { get; set; } = default!;
        internal double ProposedPrice { get; set; }
    }
}
