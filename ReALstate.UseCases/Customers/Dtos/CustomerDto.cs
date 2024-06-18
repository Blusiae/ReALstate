using ReALstate.Domain.Entities;

namespace ReALstate.UseCases.Customers.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public List<Estate> Estates = new();
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string Email { get; set; } = default!;
        public List<Domain.Entities.Offer> Offers = new();
    }
}
