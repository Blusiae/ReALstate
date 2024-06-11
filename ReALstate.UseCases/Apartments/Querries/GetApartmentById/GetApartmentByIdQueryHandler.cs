using AutoMapper;
using MediatR;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Apartments.Dtos;

namespace ReALstate.UseCases.Apartments.Querries.GetApartmentById
{
    internal class GetApartmentByIdQueryHandler
        (IApartmentRepository repository, IMapper mapper) : IRequestHandler<GetApartmentByIdQuery, ApartmentDto>
    {
        public async Task<ApartmentDto> Handle(GetApartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await repository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                throw new Exception("Apartment not found");
            }
            var dto = mapper.Map<ApartmentDto>(entity);
            return dto;
        }
    }
}
