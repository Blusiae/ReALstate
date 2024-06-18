using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Apartments.Commands.DeleteApartment
{
    // DeleteApartmentHandler is a class that will be used to handle the DeleteApartmentCommand. 
    // It inherits from IRequestHandler<DeleteApartmentCommand> interface, implementing CQRS pattern. 
    public class DeleteApartmentHandler
        (IApartmentRepository repository): IRequestHandler<DeleteApartmentCommand>
    {
        // The Handle method is used to handle the DeleteApartmentCommand. It deletes an apartment.
        public async Task Handle(DeleteApartmentCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                throw new NotFoundException(nameof(Apartment), request.Id.ToString());
            }

            if(entity.ResourceOwnerId != request.ResourceOwnerId)
            {
                throw new UnauthorizedAccessException();
            }
            
            await repository.Delete(entity);
        }
    }
}
