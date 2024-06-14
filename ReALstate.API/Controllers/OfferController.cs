using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.UseCases.Offer.Commands.CreateOffer;

namespace ReALstate.API.Controllers
{
    [ApiController]
    [Route("/api/offer")]
    public class OfferController(Mediator mediator) : ControllerBase
    {
        public async Task<IActionResult> CreateOffer(CreateOfferCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(id);
        }
    }
}
