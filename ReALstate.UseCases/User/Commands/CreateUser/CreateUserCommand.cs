using MediatR;

namespace ReALstate.UseCases.User.Commands.CreateUser
{
    // This class is used to create a new user
    public class CreateUserCommand : IRequest<Guid>
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
    }
}
