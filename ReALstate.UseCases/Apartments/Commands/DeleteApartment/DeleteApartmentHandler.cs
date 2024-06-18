using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Exceptions;
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
                throw new NotFoundException(nameof(Apartment), request.Id.ToString());
            }
            await repository.Delete(entity);
        }
    }
}
