using ReALstate.Domain.Entities;

namespace ReALstate.UseCases.Houses.Dtos
{
    public class HouseDto
    {

        public int Id { get; set; }
        public string Description { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public double MetersSquared { get; set; }
        public double Value { get; set; }
        public State State { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Voivodeship { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string PostalCode { get; set; } = default!;
        public string Number { get; set; } = default!;
        public string ApartmentNumber { get; set; } = default!;
        public int OwnerId { get; set; }
        public DateTime? YearBuilt { get; set; }

        //Additional information
        public int BedroomsCount { get; set; }
        public int BathroomsCount { get; set; }
        public bool IsFurnushed { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasAirConditioning { get; set; }
        public bool HasHeating { get; set; }
        public bool HasGarage { get; set; }
        public bool HasGarden { get; set; }
        public bool HasPool { get; set; }
        public bool HasTerrace { get; set; }
        public bool HasBasement { get; set; }
        public bool HasAttic { get; set; }
        public double LandInSquaredMeters { get; set; }
    }
}
