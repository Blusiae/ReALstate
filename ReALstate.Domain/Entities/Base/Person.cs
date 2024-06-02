namespace ReALstate.Domain.Entities.Base
{
    public abstract class Person
    {
        public virtual string FirstName { get; set; } = default!;
        public virtual string LastName { get; set; } = default!;
        public virtual string? Nationality { get; set; }
        public virtual string PhoneNumber { get; set; } = default!;
        public virtual string Email { get; set; } = default!;
    }
}
