using AutoMapper;
using MediatR;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Offer.Dtos;

namespace ReALstate.UseCases.Offer.Querries.GetAllOffers
{
    // This class is responsible for handling the GetAllOffersQuery and returning the result
    internal class GetAllOffersQueryHandler(IOfferRepository repository, IMapper mapper) : IRequestHandler<GetAllOffersQuery, IEnumerable<OfferDto>>
    {
        // Handle method is responsible for handling the request and returning the results as an IEnumerable of OfferDto
        public async Task<IEnumerable<OfferDto>> Handle(GetAllOffersQuery request, CancellationToken cancellationToken)
        {
            var offers = await repository.GetAllAsync();

            if(request.CustomerId != 0)
            {
                offers = offers.Where(a => a.CustomerId == request.CustomerId);
            }
            if(request.EstateId != 0)
            {
                offers = offers.Where(a => a.EstateId == request.EstateId);
            }

            var dtos = mapper.Map<IEnumerable<OfferDto>>(offers);

            return dtos;
        }
    }
}
