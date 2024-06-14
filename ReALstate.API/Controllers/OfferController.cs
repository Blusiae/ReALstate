using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.UseCases.Offer.Commands.CreateOffer;
using ReALstate.UseCases.Offer.Commands.DeleteOffer;
using ReALstate.UseCases.Offer.Dtos;
using ReALstate.UseCases.Offer.Querries.GetAllOffers;

namespace ReALstate.API.Controllers
{
    [ApiController]
    [Route("/api/offer")]
    public class OfferController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OfferDto>>> GetAll([FromQuery] GetAllOffersQuery query)
        {
            var offers = await mediator.Send(query);
            return Ok(offers);
        }

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
