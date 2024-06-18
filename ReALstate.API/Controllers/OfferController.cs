using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.UseCases.Offer.Commands.CreateOffer;
using ReALstate.UseCases.Offer.Commands.DeleteOffer;
using ReALstate.UseCases.Offer.Dtos;
using ReALstate.UseCases.Offer.Querries.GetAllOffers;
using ReALstate.UseCases.Offer.Querries.GetOfferById;

namespace ReALstate.API.Controllers
{
    // The OfferController class is responsible for handling requests related to offers.
    [ApiController]
    [Route("/api/offer")]
    public class OfferController(IMediator mediator) : ControllerBase
    {
        // The GetAll method is responsible for returning all offers.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OfferDto>>> GetAll([FromQuery] GetAllOffersQuery query)
        {
            var offers = await mediator.Send(query);
            return Ok(offers);
        }

        // The GetById method is responsible for returning a specific offer by its ID.
        [HttpGet("{Id}")]
        public async Task<ActionResult<OfferDto>> GetById([FromRoute] GetOfferByIdQuery query)
        {
            var offer = await mediator.Send(query);
            return Ok(offer);
        }

        // The Create method is responsible for creating a new offer.
        [HttpPost]
        public async Task<IActionResult> Create(CreateOfferCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(id);
        }

        //  The Delete method is responsible for deleting an offer by its ID.
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteOfferCommand command)
        {
            await mediator.Send(command);
            return NoContent();
        }
    }
}
