using System.Net;

namespace ReALstate.Domain.Entities
{
    public class Estate
    {
        public int Id { get; set; }
        public string Description { get; set; } = default!;
        public decimal LandAreaInSquareMeters { get; set; }
        public decimal? AverageRoomHeightInMeters { get; set; }
        public decimal PriceFinal { get; set; }
        public decimal PriceCalculated { get; set; }
        public int NumberOfRooms { get; set; }
        public int? SuggestedTenantsQuantity { get; set; }
        public int? YearBuilt { get; set; }
        public Address Address { get; set; } = new();
        public string? EstateType { get; set; }
        public bool IsFurnished { get; set; }
        public string? ImageUrl { get; set; }
        public EstateOwner? Owner { get; set; } = default!;
        public int? OwnerId { get; set; } = default!;
    }
}
