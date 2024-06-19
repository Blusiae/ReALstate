namespace ReALstate.Domain.Entities
{
    // The Customer class is responsible for defining the attributes of a customer. It contains a list of estates and offers. Customer can be a buyer or a seller.
    public class Customer
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid? ResourceOwnerId { get; set; } = default!;
        public User? ResourceOwner { get; set; } = default!;
        public List<Estate> Estates = new();
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string Email { get; set; } = default!;
        public List<Offer> Offers = new();
       
    }
}
