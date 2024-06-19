using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReALstate.UseCases.Customers.Commands.CreateCustomer;
using ReALstate.UseCases.Customers.Commands.DeleteCustomer;
using ReALstate.UseCases.Customers.Dtos;
using ReALstate.UseCases.Customers.Querries.GetAllOwners;
using ReALstate.UseCases.Customers.Querries.GetOwnerById;

namespace ReALstate.API.Controllers
{
    // The CustomerController class is responsible for handling requests related to customers.
    [ApiController]
    [Route("/api/customer")]
    public class CustomerController(IMediator mediator) : ControllerBase
    {

        // The GetAll method is responsible for returning all customers.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetAll([FromQuery] GetAllCustomersQuery query)
        {
            var result = await mediator.Send(query);

            return Ok(result);
        }

        // The GetById method is responsible for returning a specific customer by its ID.
        [HttpGet("{Id}")]
        public async Task<ActionResult<CustomerDto>> GetById([FromRoute] GetCustomerByIdQuery query, [FromQuery] Guid resourceOwnerId)
        {
            query.ResourceOwnerId = resourceOwnerId;
            var customer = await mediator.Send(query );
            return Ok(customer);
        }

        // The Create method is responsible for creating a new customer.
        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerCommand command)
        {
            int id = await mediator.Send(command);
            return Ok(id);
        }

        // The Delete method is responsible for deleting a customer by its ID.
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] DeleteCustomerCommand command)
        {
            await mediator.Send(command);
            return Ok();
        }
    }
}
