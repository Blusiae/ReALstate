﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.UseCases.Apartments.Commands.CreateApartment;
using ReALstate.UseCases.Apartments.Commands.DeleteApartment;
using ReALstate.UseCases.Apartments.Dtos;
using ReALstate.UseCases.Apartments.Querries.GetAllApartments;
using ReALstate.UseCases.Apartments.Querries.GetApartmentById;

namespace ReALstate.API.Controllers
{
    [ApiController]
    [Route("/api/apartment")]
    public class ApartmentController
        (IMediator mediator): ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApartmentDto>>> GetAll([FromQuery] GetAllApartmentsQuery query)
        {
            var apartments = await mediator.Send(query);
            return Ok(apartments);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ApartmentDto>> GetById([FromRoute] GetApartmentByIdQuery query)
        {
            var apartment = await mediator.Send(query);
            return Ok(apartment);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateApartmentCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(id);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteApartmentCommand command)
        {
            await mediator.Send(command);
            return Ok();
        }

        

        

    }
}