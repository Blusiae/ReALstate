using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Customers.Querries.GetAllOwners
{
    internal class GetAllCustomersQueryHandler
        (ICustomerRepository repository, IMapper mapper) : IRequestHandler<GetAllCustomersQuery, IEnumerable<Customer>>
    {
        public async Task<IEnumerable<Customer>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            var owners = await repository.GetAllAsync();
            return owners;
        }
    }
}
