using MediatR;
using ReALstate.UseCases.Apartments.Dtos;

namespace ReALstate.UseCases.Apartments.Querries.GetApartmentById
{
    // GetApartmentByIdQuery is a class that implements IRequest interface with a type of ApartmentDto. 
    // It is responsible for getting the apartment by its id and will be used in the GetApartmentByIdHandler class.

    public class GetApartmentByIdQuery : IRequest<ApartmentDto>
    {
        public int Id { get; set; }
        public Guid ResourceOwnerId { get; set; }
    }
}
