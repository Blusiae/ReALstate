using MediatR;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Estates.Commands.DeleteEstate
{
    public class DeleteEstateCommandHandler(IEstateRepository repository) : IRequestHandler<DeleteEstateCommand>
    {
        public async Task Handle(DeleteEstateCommand request, CancellationToken cancellationToken)
        {
            var estate = await repository.GetByIdAsync(request.Id);
            if (estate == null)
            {
                throw new Exception("Estate not found");
            }
            await repository.Delete(estate);

        }
    }
}
