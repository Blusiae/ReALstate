using MediatR;
using ReALstate.UseCases.Customers.Dtos;

namespace ReALstate.UseCases.Customers.Querries.GetOwnerById
{
    public class GetCustomerByIdQuery : IRequest<CustomerDto>
    {
        public int Id {get; set;}
    }
}
