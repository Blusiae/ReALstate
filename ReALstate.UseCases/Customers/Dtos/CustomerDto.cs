using ReALstate.Domain.Entities;

namespace ReALstate.UseCases.Customers.Dtos
{
    // This class is used to transfer data between the application and the database
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
