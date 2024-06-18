using AutoMapper;
using ReALstate.Domain.Entities;
using ReALstate.UseCases.Customers.Commands.CreateCustomer;

namespace ReALstate.UseCases.Customers.Dtos
{
    // This class determines how the data is mapped. It inherits from Profile class from AutoMapper
    internal class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CreateCustomerCommand, Customer>();
            CreateMap<Customer, CustomerDto>();
        }
    }
}
