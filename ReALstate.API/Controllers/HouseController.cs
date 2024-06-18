using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.UseCases.Houses.Commands.CreateHouse;
using ReALstate.UseCases.Houses.Commands.DeleteHouse;
using ReALstate.UseCases.Houses.Dtos;
using ReALstate.UseCases.Houses.Querries.GetAllHouses;
using ReALstate.UseCases.Houses.Querries.GetHouseById;

namespace ReALstate.API.Controllers
{
    // The HouseController class is responsible for handling requests related to houses.
    [ApiController]
    [Route("api/house")]
    public class HouseController
        (IMediator mediator) : ControllerBase
    {
        // The GetAll method is responsible for returning all houses.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HouseDto>>> GetAll([FromQuery] GetAllHousesQuery query)
        {
            var dtos = await mediator.Send(query);
            return Ok(dtos);
        }

        // The GetById method is responsible for returning a specific house by its ID.
        [HttpGet("{Id}")]
        public async Task<ActionResult<HouseDto>> GetById([FromRoute] GetHouseByIdQuery query)
        {
            var dto = await mediator.Send(query);
            return Ok(dto);
        }

        // The Create method is responsible for creating a new house.
        [HttpPost]
        public async Task<IActionResult> Create(CreateHouseCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(id);
        }

        // The Delete method is responsible for deleting a house by its ID.
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteHouseCommand command)
        {
            await mediator.Send(command);
            return Ok();
        }


    }
}
