using MediatR;

namespace ReALstate.UseCases.Houses.Commands.DeleteHouse
{
    // DeleteHouseCommand class is used to delete a house from the database.
    public class DeleteHouseCommand : IRequest
    {
        public int Id { get; set; }
        public Guid ResourceOwnerId { get; set; }
    }
}
