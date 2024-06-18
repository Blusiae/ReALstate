namespace ReALstate.UseCases.Offer.Dtos
{
    // This class is used to transfer data between the application and the database
    public class OfferDto
    { 
        public int Id { get; set; }
        public Guid? ResourceOwnerId { get; set; }
        public double ProposedPrice { get; set; }
        public int CustomerId { get; set; }
        public int EstateId { get; set; }
    }
}
