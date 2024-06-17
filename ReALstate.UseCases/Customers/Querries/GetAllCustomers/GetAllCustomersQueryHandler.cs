using AutoMapper;
using MediatR;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Customers.Dtos;

namespace ReALstate.UseCases.Customers.Querries.GetAllOwners
{
    internal class GetAllCustomersQueryHandler
        (ICustomerRepository repository, IMapper mapper) : IRequestHandler<GetAllCustomersQuery, IEnumerable<CustomerDto>>
    {
        public async Task<IEnumerable<CustomerDto>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = await repository.GetAllAsync();
            var dtos = mapper.Map<IEnumerable<CustomerDto>>(customers);
            return dtos;
        }
    }
}
