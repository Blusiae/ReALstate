using MediatR;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Offer.Commands.DeleteOffer
{
    // DeleteOfferCommandHandler class is used to handle the DeleteOfferCommand and delete an offer by its id
    internal class DeleteOfferCommandHandler
        (IOfferRepository repository): IRequestHandler<DeleteOfferCommand>
    {
        // Handle method executes the delete operation
        public async Task Handle(DeleteOfferCommand request, CancellationToken cancellationToken)
        {
            var offer = await repository.GetByIdAsync(request.Id);

            if (offer == null)
            {
                throw new NotFoundException(nameof(Offer), request.Id.ToString());
            }

            await repository.Delete(offer);
        }
    }
}
