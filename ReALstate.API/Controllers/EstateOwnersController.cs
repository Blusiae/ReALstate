using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.Domain.Entities;
using ReALstate.UseCases.EstateOwners.Commands.CreateOwner;
using ReALstate.UseCases.EstateOwners.Querries.GetAllOwners;

namespace ReALstate.API.Controllers
{
    [ApiController]
    [Route("/api/estateOwner")]
    public class EstateOwnersController(IMediator mediator) : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Create(CreateOwnerCommand command)
        {
            int id = await mediator.Send(command);
            return Ok(id);
        }

        
        [HttpGet]
        public async Task<ActionResult<EstateOwner>> GetAll()
        {
            var restult = await mediator.Send(new GetAllCustomersQuery());

            return Ok(restult);
        }

    }
}
