using MediatR;
using ReALstate.UseCases.Houses.Dtos;

namespace ReALstate.UseCases.Houses.Querries.GetHouseById
{
    public class GetHouseByIdQuery(int id) : IRequest<HouseDto>
    {
        public int Id { get; set; } = id;
    }
}
