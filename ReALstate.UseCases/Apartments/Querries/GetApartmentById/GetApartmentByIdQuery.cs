using MediatR;
using ReALstate.UseCases.Apartments.Dtos;

namespace ReALstate.UseCases.Apartments.Querries.GetApartmentById
{
    public class GetApartmentByIdQuery(int id) : IRequest<ApartmentDto>
    {
        public int Id { get; set; } = id;
    }
}
