using SQLite;

namespace ReALstate.App.Data.Entities
{
    public class Address
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string City { get; set; } = default!;
        public string Voivodeship { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string PostalCode { get; set; } = default!;
        public string Number { get; set; } = default!;
        public string ApartmentNumber { get; set; } = default!;
    }
}
