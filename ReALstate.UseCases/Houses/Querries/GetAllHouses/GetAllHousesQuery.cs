using MediatR;
using ReALstate.UseCases.Houses.Dtos;

namespace ReALstate.UseCases.Houses.Querries.GetAllHouses
{
    // GetAllHousesQuery is a class that implements IRequest interface with IEnumerable of HouseDto as a generic type.
    public class GetAllHousesQuery: IRequest<IEnumerable<HouseDto>>
    {
        public int OwnerId { get; set; }
        public Guid ResourceOwnerId { get; set; }
        public bool? Active { get; set; }
    }
}
