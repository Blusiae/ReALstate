using AutoMapper;
using ReALstate.Domain.Entities;
using ReALstate.UseCases.Customers.Commands.CreateCustomer;

namespace ReALstate.UseCases.Customers.Dtos
{
    internal class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CreateCustomerCommand, Customer>();
            CreateMap<Customer, CustomerDto>();
        }
    }
}
