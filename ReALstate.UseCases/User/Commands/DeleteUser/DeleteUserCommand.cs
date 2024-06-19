using MediatR;

namespace ReALstate.UseCases.User.Commands.DeleteUser
{
    // This class is used to delete a user
    public class DeleteUserCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
