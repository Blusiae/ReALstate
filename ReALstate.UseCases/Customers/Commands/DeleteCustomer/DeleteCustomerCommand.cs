using MediatR;

namespace ReALstate.UseCases.Customers.Commands.DeleteCustomer
{
    // DeleteCustomerCommand is a request that contains the Id of the customer that needs to be deleted
    public class DeleteCustomerCommand : IRequest
    {
        public int Id { get; set; }
        public Guid ResourceOwnerId { get; set; }
    }
}
