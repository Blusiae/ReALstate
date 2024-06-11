using AutoMapper;
using MediatR;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Houses.Dtos;

namespace ReALstate.UseCases.Houses.Querries.GetAllHouses
{
    internal class GetAllHousesQueryHandler(IHouseRepository repository, IMapper mapper) : IRequestHandler<GetAllHousesQuery, IEnumerable<HouseDto>>
    {
        public async Task<IEnumerable<HouseDto>> Handle(GetAllHousesQuery request, CancellationToken cancellationToken)
        {
            var entities = await repository.GetAllAsync();

            var dtos = mapper.Map<IEnumerable<HouseDto>>(entities);

            if (request.OwnerId != 0)
            {
                dtos = dtos.Where(a => a.OwnerId == request.OwnerId);
            }
            return dtos;
        }
    }
}
