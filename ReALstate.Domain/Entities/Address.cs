namespace ReALstate.Domain.Entities
{
    public class Address
    {
        public string? Country { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string City { get; set; } = default!;
        public string? Voivodeship { get; set; } = default!;
        public string? PostalCode { get; set; } = default!;
        public string? District { get; set; }
        public int BuildingNumber { get; set; }
        public int? ApartmentNumber { get; set; }
        public int? Floor { get; set; }
    }
}