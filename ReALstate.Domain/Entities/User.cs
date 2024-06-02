using Microsoft.AspNetCore.Identity;

namespace ReALstate.Domain.Entities
{
    public class User : IdentityUser
    {
        public bool IsActive { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public DateOnly JoinedDate { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string? Nationality { get; set; }
    }

}
