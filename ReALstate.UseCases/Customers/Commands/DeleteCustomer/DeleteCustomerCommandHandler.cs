using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Customers.Commands.DeleteCustomer
{
    internal class DeleteCustomerCommandHandler(ICustomerRepository repository) : IRequestHandler<DeleteCustomerCommand>
    {
        public async Task Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await repository.GetByIdAsync(request.Id);

            if (customer is null)
            {
                throw new NotFoundException(nameof(Customer), request.Id.ToString());
            }

            await repository.Delete(customer);

        }
    }
}
