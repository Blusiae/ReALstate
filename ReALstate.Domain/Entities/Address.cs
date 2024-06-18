namespace ReALstate.Domain.Entities
{
    // The Address class is responsible for storing information about the address of a property.
    public class Address
    {
        public string City { get; set; } = default!;
        public string Voivodeship { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string PostalCode { get; set; } = default!;
        public string Number { get; set; } = default!;
        public string ApartmentNumber { get; set; } = default!;
    }
}