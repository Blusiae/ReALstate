using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Customers.Commands.CreateCustomer
{
    // CreateCustomerCommandHandler class is for CQRS pattern to handle the CreateCustomerCommand. 
    // It implements IRequestHandler interface from MediatR.
    internal class CreateCustomerCommandHandler
        (ICustomerRepository repository, IMapper mapper) : IRequestHandler<CreateCustomerCommand, int>
    {
        // Handle method is used to handle the command and create a new Customer.
        async Task<int> IRequestHandler<CreateCustomerCommand, int>.Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var owner = mapper.Map<Customer>(request);

            int id = await repository.Create(owner);

            return id;
        }
    }
}
