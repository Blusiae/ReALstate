using AutoMapper;
using MediatR;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Houses.Dtos;

namespace ReALstate.UseCases.Houses.Querries.GetAllHouses
{
    // GetAllHousesQueryHandler is a class that implements IRequestHandler interface with GetAllHousesQuery as a generic type and IEnumerable of HouseDto as a return type.
    // It is for handling the GetAllHousesQuery request.
    internal class GetAllHousesQueryHandler(IHouseRepository repository, IMapper mapper) : IRequestHandler<GetAllHousesQuery, IEnumerable<HouseDto>>
    {
        // Handle method is used to return all houses.
        public async Task<IEnumerable<HouseDto>> Handle(GetAllHousesQuery request, CancellationToken cancellationToken)
        {
            var entities = await repository.GetAllAsync();

            entities = entities.Where(c => c.ResourceOwnerId == request.ResourceOwnerId);

            if(request.Active != null)
                entities = entities.Where(c => c.Active == request.Active);

            var dtos = mapper.Map<IEnumerable<HouseDto>>(entities);

            if (request.OwnerId != 0)
            {
                dtos = dtos.Where(a => a.OwnerId == request.OwnerId);
            }
            return dtos;
        }
    }
}
