using MediatR;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Houses.Commands.DeleteHouse
{
    internal class DeleteHouseCommandHandler
        (IHouseRepository repository): IRequestHandler<DeleteHouseCommand>
    {
        public async Task Handle(DeleteHouseCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.GetByIdAsync(request.Id);
            
            if (entity == null)
            {
                throw new Exception("House not found");
            }
            await repository.Delete(entity);

        }
    }
}
