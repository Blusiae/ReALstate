namespace ReALstate.Domain.Entities
{
    // The Offer class is responsible for defining the attributes of an offer. It contains the proposed price for an estate and the customer who made the offer.
    public class Offer
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
        public Guid? ResourceOwnerId { get; set; } = default!;
        public User? ResourceOwner { get; set; } = default!;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = default!;
        public int EstateId { get; set; }
        public Estate Estate { get; set; } = default!;
        public double ProposedPrice { get; set; }
    }
}
