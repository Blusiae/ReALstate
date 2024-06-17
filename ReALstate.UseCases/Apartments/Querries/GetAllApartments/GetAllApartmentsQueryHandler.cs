using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Apartments.Dtos;

namespace ReALstate.UseCases.Apartments.Querries.GetAllApartments
{
    public class GetAllApartmentsQueryHandler
        (IApartmentRepository repository,
        IMapper mapper) : IRequestHandler<GetAllApartmentsQuery, IEnumerable<ApartmentDto>>
    {
        public async Task<IEnumerable<ApartmentDto>> Handle(GetAllApartmentsQuery request, CancellationToken cancellationToken)
        {
            var apartments = await repository.GetAllAsync();

            var dtos = mapper.Map<IEnumerable<ApartmentDto>>(apartments);

            if (request.OwnerId != 0)
            {
                dtos = dtos.Where(a => a.OwnerId == request.OwnerId);
            }
            return dtos;
        }
    }
}
