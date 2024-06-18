using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ReALstate.App.Data
{
    internal class Customer
    {
        [PrimaryKey, AutoIncrement]
        internal int Id { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        internal List<Estate> Estates { get; set; } = [];
        internal string FirstName { get; set; } = default!;
        internal string LastName { get; set; } = default!;
        internal string PhoneNumber { get; set; } = default!;
        internal string Email { get; set; } = default!;

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Offer> Offers { get; set; } = [];
    }
}
