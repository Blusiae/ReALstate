using MediatR;
using ReALstate.UseCases.Customers.Dtos;

namespace ReALstate.UseCases.Customers.Querries.GetOwnerById
{
    public class GetCustomerByIdQuery(int id) : IRequest<CustomerDto>
    {
        public int Id { get; set; } = id;
    }
}
