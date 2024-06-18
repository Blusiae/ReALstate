using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.Customers.Dtos;

namespace ReALstate.UseCases.Customers.Querries.GetOwnerById
{
    // This class is responsible for handling the GetCustomerByIdQuery and returning the results. It implements IRequestHandler interface from MediatR.
    internal class GetCustomerByIdQueryHandler
        (ICustomerRepository repository, IMapper mapper) : IRequestHandler<GetCustomerByIdQuery, CustomerDto>
    {
        // The Handle method is responsible returning the results.
        public async Task<CustomerDto> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await repository.GetByIdAsync(request.Id);
            
            if (customer is null)
            {
                throw new NotFoundException(nameof(Customer), request.Id.ToString());
            }

            var dto = mapper.Map<CustomerDto>(customer);

            return dto;
        }
    }
}
