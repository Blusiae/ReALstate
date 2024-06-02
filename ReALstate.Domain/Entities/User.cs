using ReALstate.Domain.Entities.Base;

namespace ReALstate.Domain.Entities
{
    public class User : Person/*: IdentityUser*/
    {
        public bool IsActive { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public DateOnly JoinedDate { get; set; }
    }

}
