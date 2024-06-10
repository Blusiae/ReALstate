using MediatR;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Apartments.Commands.DeleteApartment
{
    public class DeleteApartmentHandler
        (IApartmentRepository repository): IRequestHandler<DeleteApartmentCommand>
    {
        public async Task Handle(DeleteApartmentCommand request, CancellationToken cancellationToken)
        {
            var entity = await repository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                   throw new Exception("Apartment not found");
            }
            await repository.Delete(entity);
        }
    }
}
