using MediatR;

namespace ReALstate.UseCases.Apartments.Commands.DeleteApartment
{
    // DeleteApartmentCommand is a class that will be used to delete an apartment. It will be used in the DeleteApartmentHandler class.
    // It inherits from IRequest interface, implementing CQRS pattern.
    public class DeleteApartmentCommand : IRequest
    {
        public int Id { get; set; }
    }
}
