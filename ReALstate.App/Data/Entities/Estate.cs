using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ReALstate.App.Data.Entities
{
    public class Estate
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Description { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public double MetersSquared { get; set; }
        public double Value { get; set; }
        public bool IsActive { get; set; } = true;
        public State State { get; set; } = default!;
        [ForeignKey(typeof(Address))]
        public int AddressId { get; set; }
        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Address Address { get; set; } = default!;
        [ForeignKey(typeof(Customer))]
        public int OwnerId { get; set; }
        [ManyToOne(CascadeOperations = CascadeOperation.All)]
        public Customer Owner { get; set; } = default!;
        public DateTime? YearBuilt { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Offer> Offers { get; set; } = [];

        //Additional information
        public int BedroomsCount { get; set; }
        public int BathroomsCount { get; set; }
        public bool IsFurnished { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasAirConditioning { get; set; }
        public bool HasHeating { get; set; }
    }
}
