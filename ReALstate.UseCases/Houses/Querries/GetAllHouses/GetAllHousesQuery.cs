using MediatR;
using ReALstate.UseCases.Houses.Dtos;

namespace ReALstate.UseCases.Houses.Querries.GetAllHouses
{
    public class GetAllHousesQuery: IRequest<IEnumerable<HouseDto>>
    {
        public int OwnerId { get; set; }
    }
}
