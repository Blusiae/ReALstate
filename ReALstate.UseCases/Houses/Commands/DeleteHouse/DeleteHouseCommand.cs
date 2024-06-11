using MediatR;

namespace ReALstate.UseCases.Houses.Commands.DeleteHouse
{
    public class DeleteHouseCommand(int id) : IRequest
    {
        public int Id { get; set; } = id;
    }
}
