using AutoMapper;
using MediatR;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Customers.Dtos;

namespace ReALstate.UseCases.Customers.Querries.GetAllOwners
{
    // This class is responsible for handling the GetAllCustomersQuery and returning the results. It implements IRequestHandler interface from MediatR.
    // It provides usage of CQRS pattern.
    internal class GetAllCustomersQueryHandler
        (ICustomerRepository repository, IMapper mapper) : IRequestHandler<GetAllCustomersQuery, IEnumerable<CustomerDto>>
    {
        // Handle method is responsible for handling the request and returning the results
        public async Task<IEnumerable<CustomerDto>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = await repository.GetAllAsync();
            var dtos = mapper.Map<IEnumerable<CustomerDto>>(customers);
            return dtos;
        }
    }
}
