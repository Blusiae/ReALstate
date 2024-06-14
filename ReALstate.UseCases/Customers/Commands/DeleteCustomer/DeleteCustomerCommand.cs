using MediatR;

namespace ReALstate.UseCases.Customers.Commands.DeleteCustomer
{
    public class DeleteCustomerCommand(int id) : IRequest
    {
        public int Id { get; set; } = id;
    }
}
