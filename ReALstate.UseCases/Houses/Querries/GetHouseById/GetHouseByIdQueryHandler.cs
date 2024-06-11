using AutoMapper;
using MediatR;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Houses.Dtos;

namespace ReALstate.UseCases.Houses.Querries.GetHouseById
{
    internal class GetHouseByIdQueryHandler
        (IHouseRepository repository, IMapper mapper) : IRequestHandler<GetHouseByIdQuery, HouseDto>
    {
        public async Task<HouseDto> Handle(GetHouseByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await repository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                throw new Exception("House not found");
            }
            var dto = mapper.Map<HouseDto>(entity);
            return dto;
        }
    }
}
