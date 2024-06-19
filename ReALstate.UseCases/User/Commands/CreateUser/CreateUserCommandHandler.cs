using MediatR;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.User.Commands.CreateUser
{
    // CreateUserCommandHandler class inherits IRequestHandler interface and provides creating functionality
    internal class CreateUserCommandHandler(IUserRepository userRepository) : IRequestHandler<CreateUserCommand, Guid>
    {
        // Handle method creates a new user
        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            // small class so mapper is not needed
            var user = new Domain.Entities.User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            };
            return await userRepository.Create(user);
        }
    }
}
