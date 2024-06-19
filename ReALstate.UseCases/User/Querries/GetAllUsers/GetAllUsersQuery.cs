using MediatR;
using ReALstate.UseCases.User.Dtos;

namespace ReALstate.UseCases.User.Querries.GetAllUsers
{
    // This class is used to return the IEnumerable<UserDto> when the GetAllUsersQuery is called
    public class GetAllUsersQuery : IRequest<IEnumerable<UserDto>>
    {
    }
}
