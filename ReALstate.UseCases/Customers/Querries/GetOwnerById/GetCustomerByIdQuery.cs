using MediatR;
using ReALstate.Domain.Entities;

namespace ReALstate.UseCases.Customers.Querries.GetOwnerById
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public int Id {get; set;}
    }
}
