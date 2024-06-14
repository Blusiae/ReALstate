using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.UseCases.Offer.Commands.CreateOffer;
using ReALstate.UseCases.Offer.Commands.DeleteOffer;

namespace ReALstate.API.Controllers
{
    [ApiController]
    [Route("/api/offer")]
    public class OfferController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateOfferCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(id);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteOfferCommand command)
        {
            await mediator.Send(command);
            return NoContent();
        }
    }
}
