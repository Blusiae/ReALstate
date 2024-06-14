using MediatR;
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
                throw new Exception("Offer not found");
            }

            await repository.Delete(offer);
        }
    }
}
