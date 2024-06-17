using MediatR;

namespace ReALstate.UseCases.Customers.Commands.DeleteCustomer
{
    internal class DeleteCustomerCommand(int id) : IRequest
    {
        public int Id { get; set; } = id;
    }
}
