using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.UseCases.User.Commands.CreateUser;
using ReALstate.UseCases.User.Commands.DeleteUser;
using ReALstate.UseCases.User.Dtos;
using ReALstate.UseCases.User.Querries.GetAllUsers;
using ReALstate.UseCases.User.Querries.GetUserById;

namespace ReALstate.API.Controllers
{
    // The UserController class is responsible for handling requests related to users.
    [ApiController]
    [Route("/api/user")]
    public class UserController (IMediator mediator) : ControllerBase
    {
        // The GetAll method is responsible for returning all users.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAll()
        {
            var dtos = await mediator.Send(new GetAllUsersQuery());
            return Ok(dtos);
        }

        // The GetById method is responsible for returning a specific user by its ID.
        [HttpGet("{Id}")]
        public async Task<ActionResult<UserDto>> GetById([FromRoute] GetUserByIdQuery query)
        {
            var dto = await mediator.Send(query);
            return Ok(dto);
        }

        // The Create method is responsible for creating a new user.
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(id);
        }

        // The Delete method is responsible for deleting a user by its ID.
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteUserCommand command)
        {
            await mediator.Send(command);
            return Ok();
        }
    }
}
