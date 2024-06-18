using MediatR;
using ReALstate.UseCases.Customers.Dtos;

namespace ReALstate.UseCases.Customers.Querries.GetOwnerById
{
    // This class is responsible for handling the GetCustomerByIdQuery and returning the results. It implements IRequest interface from MediatR.
    public class GetCustomerByIdQuery : IRequest<CustomerDto>
    {
        public int Id { get; set; }
    }
}
