using MediatR;
using ReALstate.UseCases.Offer.Dtos;

namespace ReALstate.UseCases.Offer.Querries.GetAllOffers
{
    public class GetAllOffersQuery : IRequest<IEnumerable<OfferDto>>
    {
        public int CustomerId { get; set; }
        public int EstateId { get; set; }
    }
}
