using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.UseCases.Customers.Commands.CreateCustomer;
using ReALstate.UseCases.Customers.Commands.DeleteCustomer;
using ReALstate.UseCases.Customers.Dtos;
using ReALstate.UseCases.Customers.Querries.GetAllOwners;
using ReALstate.UseCases.Customers.Querries.GetOwnerById;

namespace ReALstate.API.Controllers
{
    [ApiController]
    [Route("/api/customer")]
    public class CustomerController(IMediator mediator) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetAll()
        {
            var restult = await mediator.Send(new GetAllCustomersQuery());

            return Ok(restult);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerCommand command)
        {
            int id = await mediator.Send(command);
            return Ok(id);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<CustomerDto>> GetById([FromRoute] GetCustomerByIdQuery query)
        {
            var customer = await mediator.Send(query );
            return Ok(customer);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteCustomerCommand command)
        {
            await mediator.Send(command);
            return Ok();
        }
    }
}
