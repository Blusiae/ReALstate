using MediatR;

namespace ReALstate.UseCases.Offer.Commands.DeleteOffer
{
    // DeleteOfferCommand class is used to delete an offer by its id
    public class DeleteOfferCommand : IRequest
    {
        public int Id { get; set; }
    }
}
