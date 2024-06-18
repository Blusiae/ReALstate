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
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetAll()
        {
            var restult = await mediator.Send(new GetAllCustomersQuery());

            return Ok(restult);
        }

        // The GetById method is responsible for returning a specific customer by its ID.
        [HttpGet("{Id}")]
        public async Task<ActionResult<CustomerDto>> GetById([FromRoute] GetCustomerByIdQuery query)
        {
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
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteCustomerCommand command)
        {
            await mediator.Send(command);
            return Ok();
        }
    }
}
