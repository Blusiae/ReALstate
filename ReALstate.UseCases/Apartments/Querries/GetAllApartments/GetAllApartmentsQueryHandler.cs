using AutoMapper;
using MediatR;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Apartments.Dtos;

namespace ReALstate.UseCases.Apartments.Querries.GetAllApartments
{
    // This class is responsible for handling the GetAllApartmentsQuery. It implements the IRequestHandler interface.
    // It inherits from IRequestHandler<GetAllApartmentsQuery, IEnumerable<ApartmentDto>> interface, implementing CQRS pattern.
    public class GetAllApartmentsQueryHandler
        (IApartmentRepository repository,
        IMapper mapper) : IRequestHandler<GetAllApartmentsQuery, IEnumerable<ApartmentDto>>
    {
        // The Handle method is used to handle the GetAllApartmentsQuery. It returns all apartments as DTOs.
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
