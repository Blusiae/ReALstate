using MediatR;
using ReALstate.UseCases.Houses.Dtos;

namespace ReALstate.UseCases.Houses.Querries.GetHouseById
{
    // GetHouseByIdQuery is a class that implements IRequest interface with HouseDto as a generic type.
    // It is for getting a house by its id.
    public class GetHouseByIdQuery : IRequest<HouseDto>
    {
        public int Id { get; set; } 
    }
}
