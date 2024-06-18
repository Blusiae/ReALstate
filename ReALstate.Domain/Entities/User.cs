using Microsoft.AspNetCore.Identity;

namespace ReALstate.Domain.Entities
{
    // The User class is responsible for defining the attributes of a user. It inherits from the IdentityUser class.
    // IdentityUser is a class provided by ASP.NET Core Identity that contains the basic properties of a user, such as username and password.
    public class User : IdentityUser
    {
        public bool IsActive { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public DateOnly JoinedDate { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }

}
