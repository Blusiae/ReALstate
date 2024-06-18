using MediatR;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.UseCases.User.Dtos;
namespace ReALstate.UseCases.User.Querries.GetAllUsers
{
    // This class is used to handle the GetAllUsersQuery and return the IEnumerable<UserDto>
    internal class GetAllUsersQueryHandler(IUserRepository userRepository) : IRequestHandler<GetAllUsersQuery, IEnumerable<UserDto>>
    {
        // returns all users
        public async Task<IEnumerable<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var entities = await userRepository.GetAllAsync();

            var dtos = entities.Select(entity => new UserDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email
            });

            return dtos;
        }
    }
}
