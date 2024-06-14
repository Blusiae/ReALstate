using AutoMapper;
using MediatR;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Offer.Dtos;

namespace ReALstate.UseCases.Offer.Querries.GetOfferById
{
    internal class GetOfferByIdQueryHandler(IOfferRepository repository, IMapper mapper) : IRequestHandler<GetOfferByIdQuery, OfferDto>
    {
        public async Task<OfferDto> Handle(GetOfferByIdQuery request, CancellationToken cancellationToken)
        {
            var offer = await repository.GetByIdAsync(request.Id);
            if (offer == null)
            {
                throw new Exception("Offer not found");
            }
            return mapper.Map<OfferDto>(offer);
        }
    }
}
