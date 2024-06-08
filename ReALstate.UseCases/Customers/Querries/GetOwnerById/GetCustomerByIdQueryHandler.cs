using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Customers.Querries.GetOwnerById
{
    internal class GetCustomerByIdQueryHandler
        (ICustomerRepository repository, IMapper mapper) : IRequestHandler<GetCustomerByIdQuery, Customer>
    {
        public async Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var owner = await repository.GetByIdAsync(request.Id);
            
            return owner;
        }
    }
}
