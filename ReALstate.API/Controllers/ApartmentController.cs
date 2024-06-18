using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.UseCases.Apartments.Commands.CreateApartment;
using ReALstate.UseCases.Apartments.Commands.DeleteApartment;
using ReALstate.UseCases.Apartments.Dtos;
using ReALstate.UseCases.Apartments.Querries.GetAllApartments;
using ReALstate.UseCases.Apartments.Querries.GetApartmentById;

namespace ReALstate.API.Controllers
{
    // The ApartmentController class is responsible for handling requests related to apartments.
    [ApiController]
    [Route("/api/apartment")]
    public class ApartmentController
        (IMediator mediator): ControllerBase
    {
        // The GetAll method is responsible for returning all apartments.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApartmentDto>>> GetAll([FromQuery] GetAllApartmentsQuery query)
        {
            var apartments = await mediator.Send(query);
            return Ok(apartments);
        }

        // The GetById method is responsible for returning a specific apartment by its ID.
        [HttpGet("{Id}")]
        public async Task<ActionResult<ApartmentDto>> GetById([FromRoute] GetApartmentByIdQuery query, [FromQuery] Guid resourceOwnerId)
        {
            query.ResourceOwnerId = resourceOwnerId;
            var apartment = await mediator.Send(query);
            return Ok(apartment);
        }

        // The Create method is responsible for creating a new apartment.
        [HttpPost]
        public async Task<IActionResult> Create(CreateApartmentCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(id);
        }

        // The Delete method is responsible for deleting an apartment by its ID.
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] DeleteApartmentCommand command)
        {
            await mediator.Send(command);
            return Ok();
        }

        

        

    }
}
