namespace ReALstate.Domain.Entities
{
    public class EstateOwner
    {
        public int Id { get; set; }
        public List<Estate> Estates = new();
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string? Nationality { get; set; }
        public string PhoneNumber { get; set; } = default!;
        public string Email { get; set; } = default!;

    }
}
