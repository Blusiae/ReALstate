namespace ReALstate.Domain.Entities
{
    // The Estate class is responsible for defining the attributes of an estate. It is an abstract class that is inherited by the Apartment and House classes.
    public abstract class Estate
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid? ResourceOwnerId { get; set; } = default!;
        public User? ResourceOwner { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public double MetersSquared { get; set; }
        public double Value { get; set; }
        public State State { get; set; } = default!;
        public Address Address { get; set; } = default!;
        public Customer Owner { get; set; } = default!;
        public int OwnerId { get; set; }
        public DateTime? YearBuilt { get; set; }

        //Additional information
        public int BedroomsCount { get; set; }
        public int BathroomsCount { get; set; }
        public bool IsFurnushed { get; set; }    
        public bool HasBalcony { get; set; }
        public bool HasAirConditioning { get; set; }
        public bool HasHeating { get; set; }
        
    }
}
