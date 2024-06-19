using MediatR;
using ReALstate.UseCases.User.Dtos;

namespace ReALstate.UseCases.User.Querries.GetUserById
{
    public class GetUserByIdQuery : IRequest<UserDto>
    {
        public Guid Id { get; set; }
    }
}
