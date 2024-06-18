using MediatR;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.User.Dtos;

namespace ReALstate.UseCases.User.Querries.GetUserById
{
    // This class is used to handle the GetUserByIdQuery and return the UserDto
    internal class GetUserByIdQueryHandler(IUserRepository userRepository) : IRequestHandler<GetUserByIdQuery, UserDto>
    {
        // returns the user by id
        public async Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await userRepository.GetByIdAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(User), request.Id.ToString());
            }

            var userDto = new UserDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email,
            };
            return userDto;
        }
    }
}
