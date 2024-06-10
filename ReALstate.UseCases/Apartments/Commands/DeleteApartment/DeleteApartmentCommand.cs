using MediatR;

namespace ReALstate.UseCases.Apartments.Commands.DeleteApartment
{
    public class DeleteApartmentCommand(int id) : IRequest
    {
        public int Id { get; set; } = id;
    }
}
