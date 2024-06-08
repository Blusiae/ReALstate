using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Customers.Commands.CreateCustomer
{
    internal class CreateOwnerCommandHandler
        (ICustomerRepository repository, IMapper mapper) : IRequestHandler<CreateCustomerCommand, int>
    {

        async Task<int> IRequestHandler<CreateCustomerCommand, int>.Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var owner = mapper.Map<Customer>(request);

            int id = await repository.Create(owner);

            return id;
        }
    }
}
