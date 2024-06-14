using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.UseCases.Houses.Commands.CreateHouse;
using ReALstate.UseCases.Houses.Commands.DeleteHouse;
using ReALstate.UseCases.Houses.Dtos;
using ReALstate.UseCases.Houses.Querries.GetAllHouses;
using ReALstate.UseCases.Houses.Querries.GetHouseById;

namespace ReALstate.API.Controllers
{
    [ApiController]
    [Route("api/house")]
    public class HouseController
        (IMediator mediator) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<HouseDto>> GetById([FromRoute] int id)
        {
            
            return await mediator.Send(new GetHouseByIdQuery(id) );
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HouseDto>>> GetAll([FromQuery] GetAllHousesQuery query)
        {
            var dtos = await mediator.Send(query);
            return Ok(dtos);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateHouseCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(id);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteHouseCommand command)
        {
            await mediator.Send(command);
            return Ok();
        }


    }
}
