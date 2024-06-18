using AutoMapper;
using MediatR;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Offer.Dtos;

namespace ReALstate.UseCases.Offer.Querries.GetOfferById
{
    // This class is used to handle the GetOfferByIdQuery
    internal class GetOfferByIdQueryHandler(IOfferRepository repository, IMapper mapper) : IRequestHandler<GetOfferByIdQuery, OfferDto>
    {
        // Handle method is used to return the offer by id
        public async Task<OfferDto> Handle(GetOfferByIdQuery request, CancellationToken cancellationToken)
        {
            var offer = await repository.GetByIdAsync(request.Id);
            if (offer == null)
            {
                throw new NotFoundException(nameof(Offer), request.Id.ToString());
            }
            return mapper.Map<OfferDto>(offer);
        }
    }
}
