using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.UseCases.Apartments.Commands.CreateApartment;
using ReALstate.UseCases.Apartments.Commands.DeleteApartment;
using ReALstate.UseCases.Apartments.Querries;

namespace ReALstate.API.Controllers
{
    [ApiController]
    [Route("/api/apartment")]
    public class ApartmentController
        (IMediator mediator): ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllApartmentsQuery query)
        {
            var apartments = await mediator.Send(query);
            return Ok(apartments);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteApartmentCommand command)
        {
            await mediator.Send(command);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateApartmentCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(id);
        }

    }
}
