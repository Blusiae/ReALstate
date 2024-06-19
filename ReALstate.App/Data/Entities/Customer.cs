using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ReALstate.App.Data.Entities
{
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Estate> Estates { get; set; } = [];
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string Email { get; set; } = default!;

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Offer> Offers { get; set; } = [];
    }
}
