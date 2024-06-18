using Microsoft.AspNetCore.Identity;

namespace ReALstate.Domain.Entities
{
    // The User class is responsible for defining the attributes of a user. 
    // It determines who owns data in the database and who can access it.
    public class User
    {
        public Guid Id { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;

        public virtual List<Estate> Estates { get; set; } = new();
        public virtual List<Offer> Offers { get; set; } = new();
        public virtual List<Customer> Customers { get; set; } = new();

    }

}
