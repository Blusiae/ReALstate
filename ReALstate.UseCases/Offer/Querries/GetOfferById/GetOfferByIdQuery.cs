using MediatR;
using ReALstate.UseCases.Offer.Dtos;

namespace ReALstate.UseCases.Offer.Querries.GetOfferById
{
    public class GetOfferByIdQuery : IRequest<OfferDto>
    {
        public int Id { get; set; }
    }
}
