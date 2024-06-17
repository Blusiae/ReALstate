using MediatR;

namespace ReALstate.UseCases.Houses.Commands.DeleteHouse
{
    public class DeleteHouseCommand : IRequest
    {
        public int Id { get; set; }
    }
}
