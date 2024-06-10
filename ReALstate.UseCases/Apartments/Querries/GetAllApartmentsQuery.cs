using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.UseCases.Apartments.Dtos;

namespace ReALstate.UseCases.Apartments.Querries
{
    public class GetAllApartmentsQuery : IRequest<IEnumerable<ApartmentDto>>
    {
        public int OwnerId { get; set; }
        // Todo: Add more query parameters
    }
}
