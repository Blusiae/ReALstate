using MediatR;
using ReALstate.UseCases.Offer.Dtos;

namespace ReALstate.UseCases.Offer.Querries.GetOfferById
{
    // GetOfferByIdQuery class is used to get the offer by its id
    public class GetOfferByIdQuery : IRequest<OfferDto>
    {
        public int Id { get; set; }
        public Guid ResourceOwnerId { get; set; }
    }
}
