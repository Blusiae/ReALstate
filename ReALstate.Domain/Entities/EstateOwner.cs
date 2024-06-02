namespace ReALstate.Domain.Entities
{
    public class EstateOwner
    {
        public int Id { get; set; }
        public List<Estate> Estates = new();
        public virtual string FirstName { get; set; } = default!;
        public virtual string LastName { get; set; } = default!;
        public virtual string? Nationality { get; set; }
        public virtual string PhoneNumber { get; set; } = default!;
        public virtual string Email { get; set; } = default!;

    }
}
