using ReALstate.Domain.Entities.Base;

namespace ReALstate.Domain.Entities
{
    public class EstateOwner : Person
    {
        public int Id { get; set; }
        public List<Estate> Estates = new();

    }
}
