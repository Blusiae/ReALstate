using MediatR;

namespace ReALstate.UseCases.Estates.Commands.DeleteEstate
{
    public class DeleteEstateCommand(int id) : IRequest
    {
        public int Id { get; set; } = id;
    }
}
