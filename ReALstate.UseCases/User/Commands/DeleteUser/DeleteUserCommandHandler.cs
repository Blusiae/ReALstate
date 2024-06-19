using MediatR;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.User.Commands.DeleteUser
{
    // DeleteUserCommandHandler class implements IRequestHandler interface
    internal class DeleteUserCommandHandler(IUserRepository userRepository) : IRequestHandler<DeleteUserCommand>
    {
        // Handle method deletes the user entity from the database
        public async Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var entity = await userRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                throw new NotFoundException(nameof(User), request.Id.ToString());
            }
            await userRepository.Delete(entity);
        }
    }
}
