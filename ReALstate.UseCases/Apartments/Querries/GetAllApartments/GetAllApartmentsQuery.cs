using MediatR;
using ReALstate.UseCases.Apartments.Dtos;

namespace ReALstate.UseCases.Apartments.Querries.GetAllApartments
{
    // The GetAllApartmentsQuery is a class that will be used to get all apartments. 
    // It will be used in the GetAllApartmentsHandler class. It inherits from IRequest<IEnumerable<ApartmentDto>> interface, implementing CQRS pattern.
    // <IEnumerable<ApartmentDto>> is the return type of the Handle method.
    public class GetAllApartmentsQuery : IRequest<IEnumerable<ApartmentDto>>
    {
        public int OwnerId { get; set; }
        public Guid ResourceOwnerId { get; set; }
        // Todo: Add more query parameters
    }
}
