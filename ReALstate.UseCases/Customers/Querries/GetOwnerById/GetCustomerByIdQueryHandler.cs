using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Customers.Dtos;

namespace ReALstate.UseCases.Customers.Querries.GetOwnerById
{
    internal class GetCustomerByIdQueryHandler
        (ICustomerRepository repository, IMapper mapper) : IRequestHandler<GetCustomerByIdQuery, CustomerDto>
    {
        public async Task<CustomerDto> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await repository.GetByIdAsync(request.Id);
            
            if (customer is null)
            {
                throw new Exception("Customer not found");
            }

            var dto = mapper.Map<CustomerDto>(customer);

            return dto;
        }
    }
}
