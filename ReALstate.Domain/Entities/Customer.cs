namespace ReALstate.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public List<Estate> Estates = new();
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string Email { get; set; } = default!;
       
    }
}
