using MediatR;
using ReALstate.Domain.Entities;

namespace ReALstate.UseCases.Customers.Querries.GetAllOwners
{
    public class GetAllCustomersQuery : IRequest<IEnumerable<Customer>>
    {
    }
}
