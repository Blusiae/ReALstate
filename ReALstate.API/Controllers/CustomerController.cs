using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.Domain.Entities;
using ReALstate.UseCases.Customers.Commands.CreateCustomer;
using ReALstate.UseCases.Customers.Querries.GetAllOwners;

namespace ReALstate.API.Controllers
{
    [ApiController]
    [Route("/api/customer")]
    public class CustomerController(IMediator mediator) : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerCommand command)
        {
            int id = await mediator.Send(command);
            return Ok(id);
        }

        
        [HttpGet]
        public async Task<ActionResult<Customer>> GetAll()
        {
            var restult = await mediator.Send(new GetAllCustomersQuery());

            return Ok(restult);
        }

    }
}
