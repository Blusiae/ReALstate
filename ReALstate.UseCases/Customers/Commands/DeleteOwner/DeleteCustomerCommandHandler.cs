using MediatR;
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
                throw new Exception("Customer not found");
            }

            await repository.Delete(customer);

        }
    }
}
