using MediatR;

namespace ReALstate.UseCases.Offer.Commands.CreateOffer
{
    // Command to create an offer
    public class CreateOfferCommand : IRequest<int>
    {
        public int CustomerId { get; set; }
        public int EstateId { get; set; }
        public double ProposedPrice { get; set; }
    }
}
