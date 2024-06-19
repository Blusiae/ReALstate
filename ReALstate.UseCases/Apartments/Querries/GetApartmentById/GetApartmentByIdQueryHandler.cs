using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Apartments.Dtos;
using System.Linq;
namespace ReALstate.UseCases.Apartments.Querries.GetApartmentById
{
    // GetApartmentByIdQueryHandler is a class that implements IRequestHandler interface with GetApartmentByIdQuery and ApartmentDto as parameters.
    // It is responsible for handling the GetApartmentByIdQuery and implements the CQRS pattern.
    internal class GetApartmentByIdQueryHandler
        (IApartmentRepository repository, IMapper mapper) : IRequestHandler<GetApartmentByIdQuery, ApartmentDto>
    {
        // The Handle method is responsible for handling the GetApartmentByIdQuery and returning the result.
        public async Task<ApartmentDto> Handle(GetApartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await repository.GetByIdAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Apartment), request.Id.ToString());
            }

            entity = entity.ResourceOwnerId == request.ResourceOwnerId ? entity : null;

            if (entity == null)
            {
                throw new UnauthorizedAccessException();
            }

            var dto = mapper.Map<ApartmentDto>(entity);
            return dto;
        }
    }
}
