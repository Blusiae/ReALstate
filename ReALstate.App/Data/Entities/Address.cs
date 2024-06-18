using SQLite;

namespace ReALstate.App.Data.Entities
{
    internal class Address
    {
        [PrimaryKey, AutoIncrement]
        internal int Id { get; set; }
        internal string City { get; set; } = default!;
        internal string Voivodeship { get; set; } = default!;
        internal string Street { get; set; } = default!;
        internal string PostalCode { get; set; } = default!;
        internal string Number { get; set; } = default!;
        internal string ApartmentNumber { get; set; } = default!;
    }
}
