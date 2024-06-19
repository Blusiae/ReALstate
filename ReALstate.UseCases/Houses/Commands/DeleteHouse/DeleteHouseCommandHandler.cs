using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Houses.Commands.DeleteHouse
{
    // DeleteHouseCommandHandler class implements IRequestHandler<DeleteHouseCommand> and it is used to handle the DeleteHouseCommand using CQRS pattern.
    internal class DeleteHouseCommandHandler
        (IHouseRepository repository): IRequestHandler<DeleteHouseCommand>
    {
        // Handle method is used to execute the DeleteHouseCommand.
        public async Task Handle(DeleteHouseCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.GetByIdAsync(request.Id);
            
            if (entity == null)
            {
                throw new NotFoundException(nameof(House), request.Id.ToString());
            }

            if (entity.ResourceOwnerId != request.ResourceOwnerId)
            {
                throw new UnauthorizedAccessException();
            }

            await repository.Delete(entity);

        }
    }
}
