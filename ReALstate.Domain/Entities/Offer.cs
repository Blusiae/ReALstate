namespace ReALstate.Domain.Entities
{
    public class Offer
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = default!;
        public int EstateId { get; set; }
        public Estate Estate { get; set; } = default!;
        public double ProposedPrice { get; set; }
    }
}
