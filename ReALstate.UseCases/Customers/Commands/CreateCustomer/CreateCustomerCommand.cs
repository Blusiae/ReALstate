using MediatR;

namespace ReALstate.UseCases.Customers.Commands.CreateCustomer
{
    // CreateCustomerCommand class is for CQRS pattern to create a new customer.
    public class CreateCustomerCommand : IRequest<int>
    {
        public int Id { get; set; }
        public Guid ResourceOwnerId { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string? Nationality { get; set; }
        public string PhoneNumber { get; set; } = default!;
        public string Email { get; set; } = default!;

    }
}
