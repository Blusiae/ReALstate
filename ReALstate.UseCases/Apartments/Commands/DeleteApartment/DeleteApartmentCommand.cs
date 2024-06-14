using MediatR;

namespace ReALstate.UseCases.Apartments.Commands.DeleteApartment
{
    public class DeleteApartmentCommand : IRequest
    {
        public int Id { get; set; }
    }
}
