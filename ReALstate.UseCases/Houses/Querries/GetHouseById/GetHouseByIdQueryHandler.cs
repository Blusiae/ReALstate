using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Houses.Dtos;

namespace ReALstate.UseCases.Houses.Querries.GetHouseById
{
    // This class is used to handle the GetHouseByIdQuery request.
    internal class GetHouseByIdQueryHandler
        (IHouseRepository repository, IMapper mapper) : IRequestHandler<GetHouseByIdQuery, HouseDto>
    {
        // Handle method is used to return a house by its id.
        public async Task<HouseDto> Handle(GetHouseByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await repository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                throw new NotFoundException(nameof(House), request.Id.ToString());
            }
            var dto = mapper.Map<HouseDto>(entity);
            return dto;
        }
    }
}
