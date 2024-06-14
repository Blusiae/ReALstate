using MediatR;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Offer.Commands.DeleteOffer
{
    internal class DeleteOfferCommandHandler
        (IOfferRepository repository): IRequestHandler<DeleteOfferCommand>
    {
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
