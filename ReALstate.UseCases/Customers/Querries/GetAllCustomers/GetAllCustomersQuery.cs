using MediatR;
using ReALstate.UseCases.Customers.Dtos;

namespace ReALstate.UseCases.Customers.Querries.GetAllOwners
{
    // Query to get all customers
    public class GetAllCustomersQuery : IRequest<IEnumerable<CustomerDto>>
    {
        public Guid ResourceOwnerId { get; set; }
    }
}
