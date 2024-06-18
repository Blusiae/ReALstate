using MediatR;
using ReALstate.UseCases.Offer.Dtos;

namespace ReALstate.UseCases.Offer.Querries.GetAllOffers
{
    // Get all offers query class that implements IRequest interface with returning type of IEnumerable of OfferDto
    public class GetAllOffersQuery : IRequest<IEnumerable<OfferDto>>
    {
        public Guid ResourceOwnerId { get; set; }
        public int CustomerId { get; set; }
        public int EstateId { get; set; }
    }
}
