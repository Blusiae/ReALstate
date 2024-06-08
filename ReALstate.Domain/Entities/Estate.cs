using System.Net;

namespace ReALstate.Domain.Entities
{
    public class Estate
    {
        public int Id { get; set; }
        public string Description { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public double MetersSquared { get; set; }
        public double Value { get; set; }
        public Enum State { get; set; } = default!;
        public Address Address { get; set; } = default!;
        public Customer Owner { get; set; } = default!;
        public int OwnerId { get; set; }
        public DateOnly YearBuilt { get; set; }

        //Additional information
        public int BedroomsCount { get; set; }
        public int BathroomsCount { get; set; }
        public bool IsFurnushed { get; set; }    
        public bool HasBalcony { get; set; }
        public bool HasAirConditioning { get; set; }
        public bool HasHeating { get; set; }
        
    }
}
