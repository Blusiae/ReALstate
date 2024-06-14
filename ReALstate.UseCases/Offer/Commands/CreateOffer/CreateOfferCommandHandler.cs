using AutoMapper;
using MediatR;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Offer.Commands.CreateOffer
{
    internal class CreateOfferCommandHandler(IOfferRepository repository, IMapper mapper) : IRequestHandler<CreateOfferCommand, int>
    {
        public async Task<int> Handle(CreateOfferCommand request, CancellationToken cancellationToken)
        {

            var offer = mapper.Map<Domain.Entities.Offer>(request);

            int id = await repository.Create(offer);

            return id;
        }
    }
}
