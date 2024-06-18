using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ReALstate.App.Data.Entities
{
    internal class Estate
    {
        [PrimaryKey, AutoIncrement]
        internal int Id { get; set; }
        internal string Description { get; set; } = default!;
        internal string ImageUrl { get; set; } = default!;
        internal double MetersSquared { get; set; }
        internal double Value { get; set; }
        internal State State { get; set; } = default!;
        [ForeignKey(typeof(Address))]
        internal int AddressId { get; set; }
        [OneToOne]
        internal Address Address { get; set; } = default!;
        [ForeignKey(typeof(Customer))]
        internal int OwnerId { get; set; }
        [ManyToOne]
        internal Customer Owner { get; set; } = default!;
        internal DateTime? YearBuilt { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        internal List<Offer> Offers { get; set; } = [];

        //Additional information
        internal int BedroomsCount { get; set; }
        internal int BathroomsCount { get; set; }
        internal bool IsFurnished { get; set; }
        internal bool HasBalcony { get; set; }
        internal bool HasAirConditioning { get; set; }
        internal bool HasHeating { get; set; }
    }
}
