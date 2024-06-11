using MediatR;
using ReALstate.UseCases.Houses.Dtos;

namespace ReALstate.UseCases.Houses.Querries.GetAllHouses
{
    public class GetAllHousesQuery(int ownerId) : IRequest<IEnumerable<HouseDto>>
    {
        public int OwnerId { get; set; } = ownerId;
    }
}
